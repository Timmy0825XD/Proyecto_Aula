namespace ENTITY
{
    public class Producto
    {
        public string IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int Stock { get; set; }
        public string ImagenURL { get; set; }
        public decimal Descuento { get; set; }
        public string Estado { get; set; }
        public ICollection<Categoria> Categorias { get; set; }
    }
}