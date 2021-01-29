using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProducto
    {
    public partial class Form1 : Form
        {
        Datos D = new Datos(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Sergio-Note\Desktop\DBFProducto.mdb");

        const int tam = 50;
        Producto[] P = new Producto[tam];
        int c;
        bool nuevo = false;

        public Form1()
            {
            InitializeComponent();
            nuevo = false;
            c = 0;
            for (int i = 0; i < tam; i++)
                {
                P[i] = null;
                }
            }

        private void Form1_Load(object sender, EventArgs e)
            {
            this.cargarCombo(combomarca, "marca");
            this.cargarLista("Producto");
            }

        private void cargarLista(string nombreTabla)
            {
            D.leerTabla(nombreTabla);
            c = 0;
            while (D.plector.Read())
                {
                Producto O = new Producto();
                if (!D.plector.IsDBNull(0))
                    O.pCodigo = D.plector.GetInt32(0);
                if (!D.plector.IsDBNull(1))
                    O.pDetalle = D.plector["detalle"].ToString();
                if (!D.plector.IsDBNull(2))
                    O.pTipo = D.plector.GetInt32(2);
                if (!D.plector.IsDBNull(3))
                    O.pMarca = D.plector.GetInt32(3);
                if (!D.plector.IsDBNull(4))
                    O.pPrecio = D.plector.GetDouble(4);
                if (!D.plector.IsDBNull(5))
                    O.pFecha = D.plector.GetDateTime(5);
                P[c] = O;
                c++;
                }
            D.plector.Close();
            D.Desconectar();
            lstproducto.Items.Clear();
            for (int i = 0; i < c; i++)
                {
                lstproducto.Items.Add(P[i].ToString());
                }
            lstproducto.SelectedIndex = 0;

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

        private void btnnuevo_Click(object sender, EventArgs e)
            {
            this.nuevo = true;
            this.habilitar(true);
            this.limpiar();
            this.txtcodigo.Focus();
            }
        private void limpiar()
            {
            txtcodigo.Text = "";
            txtdetalle.Clear();
            combomarca.SelectedIndex = -1;
            btnnetbook.Checked = false;
            btnnotebook.Checked = false;
            dtpfecha.Value = DateTime.Today;
            }
        private void habilitar (bool x)
            {
            txtcodigo.Enabled = x;
            txtdetalle.Enabled = x;
            combomarca.Enabled = x;
            btnnetbook.Enabled = x;
            btnnotebook.Enabled = x;
            txtprecio.Enabled = x;
            dtpfecha.Enabled = x;
            btncancelar.Enabled = x;
            btngrabar.Enabled = x;

            btnnuevo.Enabled = !x;
            btneditar.Enabled = !x; 
            btnborrar.Enabled = !x;
            btnsalir.Enabled = !x;
            lstproducto.Enabled = !x;
            }

        private void btneditar_Click(object sender, EventArgs e)
            {
            this.habilitar(true);
            this.txtcodigo.Enabled = false;
            nuevo = false;
            this.txtdetalle.Focus();
            }
        private bool validar() //validaciones para que no quede vacio
            {
            if (string.IsNullOrEmpty(txtcodigo.Text)) //es verdad que esta ni nulo ni vacio   //verdadero, entra msj, focus en txtcodigo, retorno false porque el metod es bool
                {
                MessageBox.Show("El campo código no puede quedar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtcodigo.Focus();
                return false; //fuerzo el sistema para que no avance el codigo en la validacion
                }

            else
                {
                int codigo;
                if (!int.TryParse(txtcodigo.Text, out codigo))
                    {
                    MessageBox.Show("En el campo código debe ingresar solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtcodigo.Focus();
                    return false;
                    }
                }

            if (string.IsNullOrEmpty(txtdetalle.Text))
                {
                MessageBox.Show("En el campo detalle debe ingresar uno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtdetalle.Focus();
                return false;
                }


            if (combomarca.SelectedIndex == -1) //-1 no muestra datos. siempre empieza en cero
                {
                MessageBox.Show("En el campo marca debe ingresar una", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                combomarca.Focus();
                return false;
                }


            if (!btnnotebook.Checked && !btnnetbook.Checked)
                {
                MessageBox.Show("Debe seleccionar un tipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnnotebook.Focus();
                return false;
                }


            if (string.IsNullOrEmpty(txtprecio.Text))
                {
                MessageBox.Show("Debe Ingresar un precio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtprecio.Focus();
                return false;
                }

            if (dtpfecha.Value > DateTime.Now)
                {
                MessageBox.Show("Debe Ingresar una fecha futura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtpfecha.Focus();
                return false;
                }
            return true;

            }
        private bool existe(int pk) 
            {
            for (int i = 0; i < c; i++)
                {
                if (P[i].pCodigo == pk)
                    return true;
                }
            return false;
            }

        private void btngrabar_Click(object sender, EventArgs e)
            {
            if(validar())
                {
                string consulta = "";
                Producto O = new Producto();
                O.pCodigo = Convert.ToInt32(txtcodigo.Text);
                O.pDetalle = txtdetalle.Text;
                O.pMarca = Convert.ToInt32(combomarca.SelectedValue);
                if (btnnetbook.Checked)
                    O.pTipo = 1;
                else O.pTipo = 2;
                O.pPrecio = Convert.ToInt32(txtprecio.Text);
                O.pFecha = dtpfecha.Value;

                if(nuevo)
                    if(!existe(O.pCodigo))
                        {
                        consulta = "INSERT INTO Producto VALUES ("       
                                    + O.pCodigo + " ,' " + O.pDetalle + " ', " + O.pTipo + " , " + O.pMarca + " , " + O.pPrecio + " ,' " + O.pFecha.ToShortDateString() + " ')";
                        D.actualizarBD(consulta);
                        this.cargarLista("producto");
                        }
                else
                        MessageBox.Show("Este producto ya esta registrado", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                else
                    {
                    consulta = "UPDATE Producto SET Detalle='" + O.pDetalle + "'," + "Tipo=" + O.pTipo + "," + "Marca=" + O.pMarca + "," + "Precio=" + O.pPrecio + "," + "Fecha= " + O.pFecha.ToShortDateString() + " WHERE codigo=" + O.pCodigo;
                    D.actualizarBD(consulta);
                    this.cargarLista("Producto");
                    
                }
                habilitar(true);
                nuevo = false;
                }
            }
        }
    }