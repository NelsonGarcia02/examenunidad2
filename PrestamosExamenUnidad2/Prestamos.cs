using System.Data;
using MySql.Data.MySqlClient;
namespace PrestamosExamenUnidad2
{
    public partial class FrmPrestamos : Form
    {
        MySqlConnection conexion;
        MySqlDataAdapter adaptador;
        DataTable TablaPrestamos;
        public FrmPrestamos()
        {
            InitializeComponent();
        }
        private void FrmPrestamos_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;uid=root;Pwd=0207;Database=examenunidad2;";
            conexion = new MySqlConnection(connectionString);

            adaptador = new MySqlDataAdapter("SELECT * FROM examenunidad2.prestamos;", conexion);
            TablaPrestamos = new DataTable();
            adaptador.Fill(TablaPrestamos);
            dataGridView1.DataSource = TablaPrestamos;
        }
    }
}
