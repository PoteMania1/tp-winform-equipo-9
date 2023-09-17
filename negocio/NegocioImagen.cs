using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using static System.Net.Mime.MediaTypeNames;

namespace negocio
{
    public class NegocionImagen
    {
<<<<<<< HEAD:negocio/NegocionImagen.cs
        public List<Imagen> ListarImagenes()
        {
            List<Imagen> ListaImagen = new List<Imagen>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select ImagenUrl From IMAGENES";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Imagen aux = new Imagen();
                    aux.ImagenUrl = (string)lector["ImagenUrl"];
                    ListaImagen.Add(aux);
                }

                conexion.Close();
                return ListaImagen;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
=======
   
    } 
>>>>>>> 4dd270b45ef0a182ec28d3ec19908c66ea0df439:negocio/NegocioImagen.cs
}
