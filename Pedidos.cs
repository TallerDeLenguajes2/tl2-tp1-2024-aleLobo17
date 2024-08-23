namespace GestionarPedidos
{
    public enum EstadoPedido    
    {
        Ingresado,
        Entregado, 
        EnCamino,
        Cancelado
    }
    public class Pedido
    {
        private int nroPedido;
        private string observacionPedido;
        private Cliente cliente;
        private EstadoPedido estado;

        public int NroPedido { get => nroPedido;}
        public string ObservacionPedido { get => observacionPedido; }
    
        public EstadoPedido Estado { get => estado; set => estado = value; }

        public Pedido(int nroPedido, string observacionPedido,string nombreCliente,string direccionCliente,string telefonoCliente, string datosReferencia, EstadoPedido estado)
        {
            this.nroPedido = nroPedido;
            this.observacionPedido = observacionPedido;
            this.cliente = new Cliente(nombreCliente,direccionCliente,telefonoCliente,datosReferencia);
            this.estado = estado;
        }
    }
}