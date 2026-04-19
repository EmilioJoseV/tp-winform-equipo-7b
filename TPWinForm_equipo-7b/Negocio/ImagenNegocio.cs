using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ImagenNegocio
    {
        public List<Imagen> Listar()
        {
            List <Imagen> lista = new List<Imagen>();    
            AccesoDatos datos = new AccesoDatos();
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
