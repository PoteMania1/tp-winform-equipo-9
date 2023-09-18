using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
       
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int IdMarcas { get; set; }
        public int IdCategorias { get; set; }

        //public Imagen imagen { get; set; } 
        //public List<byte[]> Imagenes { get; set; }
        public decimal Precio { get; set; }

    }
}
