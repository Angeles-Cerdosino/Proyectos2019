using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace TrabajoIntegrador
    {
    public partial class Consultas : Form
        {
        AccesoDatos Datos = new AccesoDatos(@"Provider=SQLNCLI11;Data Source=SHEE\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=CINE_ESTRELLAS_FINAL");
        public Consultas()
            {
            InitializeComponent();
            //limpiar();
            }

        private void btnconsultar_Click(object sender, EventArgs e)
            {
            if (validar())
                {
                string sql;
                if (rbtidpelicula.Checked)
                    {
                    sql = "SELECT * FROM PELICULAS "
                        + " where ID_PELICULA = " + txtnombre.Text
                        + " ORDER BY 1";

                    }
                else
                    {
                    sql = "SELECT * FROM PELICULAS "
                           + "WHERE NOMBRE LIKE '" + txtnombre.Text + "%' "
                           + "ORDER BY 2";
                    }
                dataGridView1.DataSource = Datos.consultas(sql);
                txtnombre.Focus();

                //limpiar();
                }

            }

        //void limpiar()
        //    {
        //    rbtidpelicula.Enabled = false;
        //    rbtnombre.Enabled = false;
        //    txtnombre.Enabled = false;
        //    btnconsultar.Enabled = true;
        //    btnborrar.Enabled = true;
        //    }
        private void btnborrar_Click(object sender, EventArgs e)
            {
            if (MessageBox.Show("Seguro que quiere borrar?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                DataTable dt = (DataTable)dataGridView1.DataSource;
                dt.Clear();
                }

            }
        private void Consultas_FormClosing(object sender, FormClosingEventArgs e)
            {
            if (MessageBox.Show("Desea abandonar la aplicación ?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
            }

        private void btnsalir_Click(object sender, EventArgs e)
            {
            this.Close();
            }

        private bool validar()
            {
            if (string.IsNullOrEmpty(txtnombre.Text))
                {
                MessageBox.Show("Debe completar el código...");
                txtnombre.Focus();
                return false;
                }
               else
                {
                if (rbtnombre.Checked && !Regex.IsMatch(txtnombre.Text, "^[a-zA-Z ]+$"))
                    
                     { 
                      MessageBox.Show("Coloque sólo letras.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        txtnombre.Focus();
                        return false;
                        }
                    
                else
                    {
                    if (rbtidpelicula.Checked)
                        {
                        try { Int32.Parse(txtnombre.Text); }
                        catch { MessageBox.Show("Coloque solo números.", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation); }
                        rbtidpelicula.Focus();
                        return false;
                        }
                    }
                
                }
                return true;
            }
       }
 }
    

    