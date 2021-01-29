using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoIntegrador
    {
    public partial class frmConsultas : Form
        {
        AccesoDatos Datos = new AccesoDatos(@"Provider=SQLNCLI11;Data Source=SHEE\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=CINE_ESTRELLAS_FINAL");
        public frmConsultas()
            {
            InitializeComponent();
            }
           
        private void button1_Click(object sender, EventArgs e)
            {
            

            string sql = "SELECT * FROM PELICULAS ";
            dataGridView1.DataSource = Datos.consulta(sql);
            }
        private void frmConsultas_Load(object sender, EventArgs e)
            {

            }

     
        }
    }
