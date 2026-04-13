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
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            //conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
            //comando.CommandType = System.Data.CommandType.Text;
            //comando.CommandText = "S";
            //comando.Connection = conexion;

            try
            {

                return lista;
            }
            catch (Exception ex)
            {

                throw ex; 
            }
        }
    }
}
