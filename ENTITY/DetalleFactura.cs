using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class DetalleFactura
    {
        public string IdDetalle { get; set; }
        public Factura Factura { get; set; }
        public VarianteProducto VarianteProducto { get; set; }
        public decimal PrecioUnitario 
        { 
            get 
            { 
                return VarianteProducto.Producto.PrecioUnitario;
            } 
        }
        public int Cantidad { get; set; }
        public decimal Descuento 
        { 
            get 
            { 
                return VarianteProducto.Producto.Descuento;
            } 
        }
        public decimal IVA { 
            get
            {
                return (Subtotal * 19) / 100 ;
            }
        }
        public decimal Subtotal { get; set; }
    }
}
