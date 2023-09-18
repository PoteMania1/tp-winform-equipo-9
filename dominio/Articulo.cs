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
        public Marca Marcas { get; set; }
        public Categoria Categorias { get; set; }
<<<<<<< HEAD
=======
        //public List<byte[]> Imagenes { get; set; }
>>>>>>> ef319bdb3aac644e3846d514eb4ce0eb3257f01c
        public decimal Precio { get; set; }

    }
}
