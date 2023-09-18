using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class NegocioCategoria
    {
        public List<Categoria> ListarCategorias()
        {
            List<Categoria> ListaCategoria = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();


            try
            {
                datos.SetearConsulta("SELECT Id, Descripcion FROM CATEGORIAS");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    ListaCategoria.Add(aux);
                }

                return ListaCategoria;
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
