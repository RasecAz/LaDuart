namespace LaDuartProject.Server.Entityes
{
    public class Productos
    {
        public int Id_producto { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public DateTime Fecha_creacion { get; set; }
        public DateTime Fecha_ingreso { get; set; }
        public DateTime Fecha_caducidad { get; set; }
        public float Cantidad { get; set; }
        public int Precio { get; set; }
    }
}
