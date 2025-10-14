using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class VarianteProducto
    {
        public int IdVariante { get; set; }
        public Producto Producto { get; set; }
        public string Talla { get; set; }
        public string Color { get; set; }
        public int StockVariante { get; set; }
        public string Estado { get; set; }
    }
}
