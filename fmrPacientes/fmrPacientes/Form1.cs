using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fmrPacientes
    {    
    public partial class Form1 : Form
        {
        AccesoDatos D = new AccesoDatos(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Sergio-Note\Desktop\Pacientesss.accdb");
        const int tam = 50;
        Pacientes[] PP = new Pacientes[tam];
        int c;
        bool nuevo = false;

        public Form1() {
            InitializeComponent();
            c = 0;
            nuevo = false;
            for (int i = 0; i < tam; i++)
                {
                PP[i] = null;
                }
            }

        

        private void Form1_Load(object sender, EventArgs e)
            {
            this.cargarCombo(cboOS, "obraSocial");
            this.cargarLista("Pacientes");
            
            }

        private void cargarCombo(ComboBox combo, string nombreTabla)
            {
            DataTable tabla = new DataTable();
            tabla = D.consultarTabla(nombreTabla);
            combo.DataSource = tabla;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.SelectedIndex = -1;
            }


        private void cargarLista(string nombreTabla)
            {
            D.leerTabla(nombreTabla);
            c = 0;
            while(D.plector.Read())
                {
                Pacientes p = new Pacientes();
                if (!D.plector.IsDBNull(0))
                    p.pHC = D.plector.GetInt32(0);
                if (!D.plector.IsDBNull(1))
                    p.pnombre = D.plector["nombre"].ToString();
                if (!D.plector.IsDBNull(2))
                    p.papellido = D.plector["apellido"].ToString();
                if (!D.plector.IsDBNull(3))
                    p.ptelefono = D.plector.GetInt32(3);
                if (!D.plector.IsDBNull(4))
                    p.psexo = D.plector.GetInt32(4);
                if (!D.plector.IsDBNull(6))
                    p.pOS = D.plector.GetInt32(6);
                if (!D.plector.IsDBNull(5))
                    p.pfechaNac = D.plector.GetDateTime(5);
              
                PP[c] = p;
                c++;
                
                }
            D.plector.Close();
            D.Desconectar();
            listpacientes.Items.Clear();
            for (int i = 0; i < c; i++)
                {
                listpacientes.Items.Add(PP[i].ToString());
                }
            listpacientes.SelectedIndex = 0;
            }

        private void cargarCampos(int posicion)
            {
            txtHC.Text = PP[posicion].pHC.ToString();
            txtnombre.Text = PP[posicion].pnombre;
            txtapellido.Text = PP[posicion].papellido;
            txttelefono.Text = PP[posicion].papellido;
            if (PP[posicion].psexo == 1)
                rbtFemenino.Checked = true;
            else
                rbtMasculino.Checked = true;
            dtpfecha.Value = PP[posicion].pfechaNac;
            cboOS.SelectedValue = PP[posicion].pOS;

            }

        private void listpacientes_SelectedIndexChanged(object sender, EventArgs e)
            {
            this.cargarCampos(listpacientes.SelectedIndex);
            }
        }
    }
