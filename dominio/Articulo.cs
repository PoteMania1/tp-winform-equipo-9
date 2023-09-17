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
<<<<<<< HEAD
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
=======
        public Marca Marcas { get; set; }
        public Categoria Categorias { get; set; }
        //public List<byte[]> Imagenes { get; set; }
>>>>>>> 51cd2e0668ccc6760bf786640c588704530a4ecd
        public decimal Precio { get; set; }

    }
}
