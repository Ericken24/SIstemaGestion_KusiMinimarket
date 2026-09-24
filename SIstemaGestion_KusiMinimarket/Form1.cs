namespace SIstemaGestion_KusiMinimarket
{

    public partial class Form1 : Form
    {
        private ColaCaja listaClientes = new ColaCaja(); // Creamos una instancia de la clase ColaCaja para manejar la lista de clientes
        // ListaEnlazada<ClienteCaja> listaClientes = new ListaEnlazada<ClienteCaja>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validar que el nombre del cliente no esté vacío
            string nombre = txtCliente.Text.Trim(); // hacemos una variable y le asignamos el valor del textbox escrito en el recuadro del nombre del cliente
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Por favor, ingrese el nombre del cliente.");
                return;
            }

            // Validar que la cantidad de productos sea mayor a 0
            int NumeroProductos = (int)nudContadorProductos.Value; // hacemos una variable y le asignamos el valor del numeric up down escrito en el recuadro de la cantidad de productos
            if (NumeroProductos <= 0)
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida de productos.");
                return;
            }

            // Crear un nuevo cliente y agregarlo a la lista enlazada
            ClienteCaja nuevoCliente = new ClienteCaja
            {
                IdCliente = listaClientes.Cantidad + 1,
                Nombre = nombre,
                HoraLlegada = DateTime.Now,
                CantidadProductos = NumeroProductos
            };
            listaClientes.AgregarAlFinal(nuevoCliente);

            dgvTablaClientes.Rows.Add(nuevoCliente.IdCliente, nuevoCliente.Nombre, nuevoCliente.CantidadProductos, nuevoCliente.HoraLlegada); // Agregamos el nombre y la cantidad de productos a la tabla de clientes (tabla de dgvTablaClientes)

            txtCliente.Clear(); // Limpiamos el textbox del nombre del cliente
            nudContadorProductos.Value = nudContadorProductos.Minimum; // Reiniciamos el valor del numeric up down a su valor mínimo
            txtCliente.Focus(); // Colocamos el cursor en el textbox del nombre del cliente
        }

        private void btnAtenderSiguiente_Click(object sender, EventArgs e)
        {
            // Validar que haya clientes en la lista antes de atender al siguiente
            if (listaClientes.EstaVacia)
            {
                MessageBox.Show("No hay clientes en la lista.");
                return;
            }

            // Validar que haya clientes en la tabla antes de atender al siguiente
            if (dgvTablaClientes.Rows.Count == 0 ||
                dgvTablaClientes.Rows[0].IsNewRow)
            {
                MessageBox.Show("No hay clientes en la lista.");
                return;
            }

            // Atender al siguiente cliente en la lista enlazada, utilizando el método Desencolar() de la clase ColaCaja, y mostrar un mensaje con el nombre del cliente y la cantidad de productos que tiene
            ClienteCaja clienteAtendido = listaClientes.Desencolar();

            MessageBox.Show($"Atendiendo al cliente: {clienteAtendido.Nombre}, con {clienteAtendido.CantidadProductos} productos.");

            // Remover la primera fila de la tabla de clientes (dgvTablaClientes) después de atender al cliente
            dgvTablaClientes.Rows.RemoveAt(0);
        }

        private void dgvTablaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            listaClientes.ObtenerTodos(); // Obtenemos todos los clientes de la lista enlazada y los mostramos en la tabla de clientes (dgvTablaClientes)
        }
    }
}
