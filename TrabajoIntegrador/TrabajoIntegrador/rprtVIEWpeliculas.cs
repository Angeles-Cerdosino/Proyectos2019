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
    public partial class rprtVIEWpeliculas : Form
        {
        AccesoDatos datos = new AccesoDatos(@"Provider=SQLNCLI11;Data Source=SHEE\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=CINE_ESTRELLAS_FINAL");
       
        public rprtVIEWpeliculas()
            {
            InitializeComponent();
            }

        private void rprtVIEWpeliculas_Load(object sender, EventArgs e)
            {
            //this.cargarLista("Peliculas");

            }
        }
    }
