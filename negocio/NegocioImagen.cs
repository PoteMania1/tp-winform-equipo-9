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

        public List<Imagen> ListarImagenes()
        {
            List<Imagen> ListaImagen = new List<Imagen>();
            AccesoDatos datos = new AccesoDatos();


            try
            {
                datos.SetearConsulta("SELECT ImagenUrl, I.Id, A.Id From IMAGENES I, ARTICULOS A where I.Id = A.Id");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Imagen aux = new Imagen();
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Id = (int)datos.Lector["Id"];
                    ListaImagen.Add(aux);
                }

                return ListaImagen;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally 
            { 
                datos.CerrarConexion(); 
            }
        }
    }
   
}
