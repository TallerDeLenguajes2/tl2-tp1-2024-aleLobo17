namespace Cadetes{
    public class Cadete
    {
        const int PRECIO_ENVIO = 500;
        private int id;
        private string nombre;
        private string direccion;
        private string  telefono;
        private List<Pedido> pedidos;

        public Cadete(int id, string nombre, string direccion, string telefono, List<Pedido> pedidos)
        {
            this.id = id;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.pedidos = pedidos;
        }

        public int Id { get => id; }
        public string Nombre { get => nombre;}
        public string Direccion { get => direccion;}
        public string Telefono { get => telefono;}
        public List<Pedido> Pedidos { get => pedidos; set => pedidos = value; }
    }
}