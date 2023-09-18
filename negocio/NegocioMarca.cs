using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class NegocioMarca
    {
            public List<Marca> ListarMarcas()
            {
                List<Marca> ListaMarcas = new List<Marca>();
                AccesoDatos datos = new AccesoDatos();


                try
                {
                    datos.SetearConsulta("SELECT Id, Descripcion FROM MARCAS");
                    datos.EjecutarLectura();

                    while (datos.Lector.Read())
                    {
                        Marca aux = new Marca();
                        aux.Id = (int)datos.Lector["Id"];
                        aux.Descripcion = (string)datos.Lector["Descripcion"];
                        ListaMarcas.Add(aux);
                    }

                    return ListaMarcas;
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
