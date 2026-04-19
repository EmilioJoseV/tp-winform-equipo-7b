using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        private AccesoDatos accesoDatos;

        public ArticuloNegocio()
        {
            accesoDatos = new AccesoDatos();
        }

        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();

            try
            {

                accesoDatos.setearConsulta("SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio, I.ImagenUrl, C.Descripcion AS Categoria FROM ARTICULOS A INNER JOIN IMAGENES I ON A.Id = I.IdArticulo INNER JOIN CATEGORIAS C ON A.IdCategoria = C.Id");
                accesoDatos.ejecutarLectura();

                while (accesoDatos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)accesoDatos.Lector["Id"];
                    aux.Codigo = (string)accesoDatos.Lector["Codigo"];
                    aux.Nombre = (string)accesoDatos.Lector["Nombre"];
                    aux.Descripcion = (string)accesoDatos.Lector["Descripcion"];
                    aux.Precio = (float)(decimal)accesoDatos.Lector["Precio"];
                    aux.Imagenes = new List<Imagen>();
                    Imagen imagen = new Imagen();
                    imagen.ImagenUrl = (string)accesoDatos.Lector["ImagenUrl"];
                    aux.Imagenes.Add(imagen);
                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)accesoDatos.Lector["Categoria"];

                    lista.Add(aux);
                }
                accesoDatos.cerrarConexion();

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Articulo> buscarArticulos(String criterio)
        {
            return new List<Articulo>();
        }

        public Articulo crearArticulo(Articulo articulo)
        {
            return new Articulo();
        }

        public Articulo actualizarArticulo(Articulo articulo)
        {
            return new Articulo();
        }

        public Boolean eliminarArticulo(Articulo articulo)
        {
            return true;
        }
    }
}
