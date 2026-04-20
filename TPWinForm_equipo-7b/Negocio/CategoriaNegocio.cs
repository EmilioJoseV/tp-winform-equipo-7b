using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class CategoriaNegocio
    {
        private AccesoDatos AccesoDatos;

        public CategoriaNegocio()
        {
            AccesoDatos = new AccesoDatos();
        }   

        public List<Categoria> Listar()
        {
            List<Categoria> lista = new List<Categoria>();

            try
            {
                AccesoDatos.setearConsulta("Select Id, Descripcion From CATEGORIAS");
                AccesoDatos.ejecutarLectura();

                while (AccesoDatos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.Id = (int)AccesoDatos.Lector["Id"];
                    aux.Descripcion = (string)AccesoDatos.Lector["Descripcion"];

                    lista.Add(aux);
                }


                return lista;
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

        public Categoria ObtenerPorId(int id)
        {
            try
            {
                Categoria categoria = new Categoria();

                AccesoDatos.setearConsulta("SELECT Id, Descripcion FROM CATEGORIAS WHERE Id = @id");
                AccesoDatos.setearParametro("@id", id);
                AccesoDatos.ejecutarLectura();
                
                while (AccesoDatos.Lector.Read())
                {
                    categoria.Id = (int)AccesoDatos.Lector["Id"];
                    categoria.Descripcion = (string)AccesoDatos.Lector["Descripcion"];
                }

                return categoria;
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
    }
}
