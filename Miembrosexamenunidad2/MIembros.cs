using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
namespace Miembrosexamenunidad2
{
    public partial class FrmMiembros : Form
    {
        MySqlConnection conexion;
        MySqlDataAdapter adaptador;
        DataTable TablaMiembro;
        public FrmMiembros()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;uid=root;Pwd=0207;Database=examenunidad2;";
            conexion = new MySqlConnection(connectionString);

            adaptador = new MySqlDataAdapter("SELECT * FROM examenunidad2.miembros;", conexion);
            TablaMiembro = new DataTable();
            adaptador.Fill(TablaMiembro);
            dataGridView1miembro.DataSource = TablaMiembro ;

        }
    }
}
