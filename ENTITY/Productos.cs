using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Productos
    {
        public string Id_producto { get; set; }
        public string Nombre_producto { get; set; }
        public string Descripcion { get; set; }
        public int Stock { get; set; }
        public double Precio_unitario { get; set; }
        public double Descuento { get; set; }
    }
}
