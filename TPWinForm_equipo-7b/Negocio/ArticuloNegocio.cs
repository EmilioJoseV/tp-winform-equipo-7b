using Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Negocio
{
    public class ArticuloNegocio
    {
        private readonly AccesoDatos AccesoDatos;
        private readonly ImagenNegocio ImagenNegocio;
        private readonly CategoriaNegocio CategoriaNegocio;
        private readonly MarcaNegocio MarcaNegocio;

        public ArticuloNegocio()
        {
            AccesoDatos = new AccesoDatos();
            ImagenNegocio = new ImagenNegocio();
            CategoriaNegocio = new CategoriaNegocio();
            MarcaNegocio = new MarcaNegocio();
        }

        public List<Articulo> Listar()
        {
            try
            {
                AccesoDatos.setearConsulta("SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio, A.IdMarca, A.IdCategoria FROM ARTICULOS A" );
                AccesoDatos.ejecutarLectura();
                List<Articulo> articulos =  MapearConsultaArticulos(AccesoDatos.Lector);
                AccesoDatos.cerrarConexion();
                return articulos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private List<Articulo> MapearConsultaArticulos(SqlDataReader reader)
        {
            List<Articulo> articulos = new List<Articulo>();
            
            try
            {
                while (reader.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.Id = (int)AccesoDatos.Lector["Id"];
                    articulo.Codigo = (string)AccesoDatos.Lector["Codigo"];
                    articulo.Nombre = (string)AccesoDatos.Lector["Nombre"];
                    articulo.Descripcion = (string)AccesoDatos.Lector["Descripcion"];
                    articulo.Precio = (float)(decimal)AccesoDatos.Lector["Precio"];

                    int categoriaId = (int)AccesoDatos.Lector["IdCategoria"];
                    articulo.Categoria = CategoriaNegocio.ObtenerPorId(categoriaId);
                    if (articulo.Categoria.Id == 0) articulo.Categoria = new Categoria(articulo.Categoria.Id, "Sin Categoria registrada");

                    int marcaId = (int)AccesoDatos.Lector["IdMarca"];
                    articulo.Marca = MarcaNegocio.ObtenerPorId(marcaId);
                    if (articulo.Marca.Id == 0) articulo.Marca = new Marca { Id = marcaId, Descripcion = "Sin Marca registrada" };

                    articulo.Imagenes = ImagenNegocio.ObtenerImagenesPorArticuloId(articulo.Id);
                    articulos.Add(articulo);
                }

                return articulos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Articulo> ListarConFiltros(string campo, string criterio, string filtro)
        {
            //Criterios para buscar: 

            //Buscar por categoria
            //Buscar por marca 
            //Buscar por nombre
            //Buscar por codigo 
            //Buscar por descripcion 

            try {
                string consulta = "SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio, A.IdMarca, A.IdCategoria FROM ARTICULOS A";
                string where = "";

                if (!string.IsNullOrEmpty(filtro))
                {
                    switch (campo)
                    {
                        case "Nombre":
                        case "Codigo":
                        case "Descripcion":
                            where = $" WHERE A.{campo} ";
                            switch (criterio)
                            {
                                case "Comienza con":
                                    where += "LIKE @filtro";
                                    filtro = filtro + "%";
                                    break;
                                case "Termina con":
                                    where += "LIKE @filtro";
                                    filtro = "%" + filtro;
                                    break;
                                case "Contiene":
                                    where += "LIKE @filtro";
                                    filtro = "%" + filtro + "%";
                                    break;
                                default:
                                    where += "= @filtro";
                                    break;
                            }
                            break;

                        case "Marca":
                            int idMarca;
                            if (int.TryParse(filtro, out idMarca))
                            {
                                where = " WHERE A.IdMarca = @filtro";
                            }
                            else
                            {
                                consulta += " INNER JOIN MARCAS M ON M.Id = A.IdMarca";
                                where = " WHERE M.Descripcion LIKE @filtro";
                                filtro = "%" + filtro + "%";
                            }
                            break;

                        case "Categoria":
                            int idCategoria;
                            if (int.TryParse(filtro, out idCategoria))
                            {
                                where = " WHERE A.IdCategoria = @filtro";
                            }
                            else
                            {
                                consulta += " INNER JOIN CATEGORIAS C ON C.Id = A.IdCategoria";
                                where = " WHERE C.Descripcion LIKE @filtro";
                                filtro = "%" + filtro + "%";
                            }
                            break;

                        default:
                            break;
                    }
                }

                consulta += where;
                AccesoDatos.setearConsulta(consulta);

                if (!string.IsNullOrEmpty(filtro))
                    AccesoDatos.setearParametro("@filtro", filtro);

                AccesoDatos.ejecutarLectura();

                List<Articulo> articulos = MapearConsultaArticulos(AccesoDatos.Lector);

                return articulos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                AccesoDatos.cerrarConexion();
            }
        }

        public void Crear(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                AccesoDatos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) VALUES (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @Precio)");
                AccesoDatos.setearParametro("@Codigo", articulo.Codigo);
                AccesoDatos.setearParametro("@Nombre", articulo.Nombre);
                AccesoDatos.setearParametro("@Descripcion", articulo.Descripcion);
                AccesoDatos.setearParametro("@IdMarca", articulo.Marca.Id);
                AccesoDatos.setearParametro("@IdCategoria", articulo.Categoria.Id);
                AccesoDatos.setearParametro("@Precio", articulo.Precio);
                AccesoDatos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                AccesoDatos.cerrarConexion();
            }
        }

        public void Actualizar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                AccesoDatos.setearConsulta("UPDATE ARTICULOS SET Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, Precio = @Precio, IdMarca = @IdMarca, IdCategoria = @IdCategoria WHERE Id = @Id");
                AccesoDatos.setearParametro("@Codigo", articulo.Codigo);
                AccesoDatos.setearParametro("@Nombre", articulo.Nombre);
                AccesoDatos.setearParametro("@Descripcion", articulo.Descripcion);
                AccesoDatos.setearParametro("@Precio", articulo.Precio);
                AccesoDatos.setearParametro("@IdMarca", articulo.Marca.Id);
                AccesoDatos.setearParametro("@IdCategoria", articulo.Categoria.Id);

                AccesoDatos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                AccesoDatos.cerrarConexion();
            }
        }

        public void Eliminar(Articulo articulo)
        {
            AccesoDatos.setearConsulta("DELETE FROM ARTICULOS WHERE Id = @Id");
            AccesoDatos.setearParametro("@Id", articulo.Id);
            AccesoDatos.ejecutarAccion();
        }
    }
}
