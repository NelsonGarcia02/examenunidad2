using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography.X509Certificates;
namespace ExamenUnidad2
{
    public partial class frmLibros : Form
    {
        MySqlConnection conexion;
        MySqlDataAdapter adaptador;
        DataTable tabla;
        public frmLibros()
        {
            InitializeComponent();
        }

        private void frmLibros_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=Mysql@127.0.0.1:3306; user=root;pwd=1234;Database=ExamenUnidad2";
            conexion= new MySqlConnection(connectionString);
            adaptador = new MySqlDataAdapter("SELECT * FROM examenunidad2.libros;", conexion);
            tabla= new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            dataGridView1.Columns["libro_Codigo"].Visible = false;
            dataGridView1.Columns["Imagen"].Visible = false;
        } 
        








        
           
        

    
           
        








    } 
}  