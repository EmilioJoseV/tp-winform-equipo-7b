using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GestionArticulosCatalogoApp
{
    internal class ArticuloNegocio
    {
        public List<Articulos> listar()
        {
            List<Articulos> lista = new List<Articulos>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio, I.ImagenUrl From Imagenes I, Articulos A Where A.id = I.IdArticulo";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.Id = (int)lector["Id"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.Precio = (float)(decimal)lector["Precio"];
                    aux.Imagenes = new Imagenes();
                    aux.Imagenes.ImagenUrl = (string)lector["ImagenUrl"];

                    lista.Add(aux);
                }
                conexion.Close();

                return lista;
            }
            catch (Exception ex)
            {

                throw ex; 
            }
        }
    }
}
