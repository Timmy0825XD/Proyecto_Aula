using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Direccion
    {
        public int IdDireccion { get; set; }
        public Cliente Cliente { get; set; }
        public string DireccionDes { get; set; }
        public Barrio Barrio { get; set; }
        public string CodigoPostal { get; set; }
    }
}
