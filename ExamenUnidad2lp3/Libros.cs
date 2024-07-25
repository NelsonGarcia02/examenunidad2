using MySql.Data.MySqlClient;
using System.Data;
namespace examenunidad2
{
    public partial class FrmLibros : Form
    {
        MySqlConnection conexion;
        MySqlDataAdapter adaptador;
        DataTable Tabla;

        public FrmLibros()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;uid=root;Pwd=0207;Database=examenunidad2;";
            conexion = new MySqlConnection(connectionString);

            adaptador = new MySqlDataAdapter("SELECT * FROM examenunidad2.libros;", conexion);
            Tabla = new DataTable();
            adaptador.Fill(Tabla);
            dataGridView1.DataSource = Tabla;
        }
    }
}
