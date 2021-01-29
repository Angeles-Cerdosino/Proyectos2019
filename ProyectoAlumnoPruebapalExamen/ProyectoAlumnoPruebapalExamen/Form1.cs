using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAlumnoPruebapalExamen
    {
    public partial class Form1 : Form
        {
        AccesoDatos datos = new AccesoDatos(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Sergio-Note\Desktop\DBF_ABM_alumno_personas.mdb");
        //const int tam = 50;
        //Alumno[] al = new Alumno[tam];
        //int c = 0;
        List<Alumno> la = new List<Alumno>(); //le digo que la lista contiene la clase alumno
        int accion = 1; //1-nuevo, 2-editar >> botones inicializados en 1       

        public Form1()
            {
            InitializeComponent();
            }

        private void Form1_Load(object sender, EventArgs e)
            {
            cargarLista("alumnos");
            cargarCombo(cboTipoDoc, "tipo_documento");
            cargarCombo(cboCarrera, "carreras");
            this.habilitarComponentes(false);
            }

        private void habilitarComponentes(bool value)
            {
            for (int i = 0; i < this.Controls.Count; i++)
                {
                this.Controls[i].Enabled = value;
                }
            lstAlumno.Enabled = !value;
            btnNuevo.Enabled = !value;
            btnCancelar.Enabled = !value;
            }

        private void cargarCombo(ComboBox combo, string nombreTabla)
            {
            DataTable dt = new DataTable();
            dt = datos.consultarTabla(nombreTabla);
            combo.DataSource = dt;
            combo.ValueMember = dt.Columns[0].ColumnName;
            combo.DisplayMember = dt.Columns[1].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.SelectedIndex = 0;
            }

        private void cargarLista(string nombreTabla)
            {
            la.Clear();
            datos.leerTabla(nombreTabla);
            while (datos.plector.Read())
                {
                Alumno a = new Alumno();
                if (!datos.plector.IsDBNull(0))
                    a.pApellido = datos.plector.GetString(0);
                if (!datos.plector.IsDBNull(1))
                    a.pNombre = datos.plector.GetString(1);
                if (!datos.plector.IsDBNull(2))
                    a.pFecha = datos.plector.GetDateTime(2);
                if (!datos.plector.IsDBNull(3))
                    a.pSexo = datos.plector.GetInt32(3);
                if (!datos.plector.IsDBNull(4))
                    a.pTipo_doc = datos.plector.GetInt32(4);
                if (!datos.plector.IsDBNull(5))
                    a.pDocumento = datos.plector.GetInt32(5);
                if (!datos.plector.IsDBNull(6))
                    a.pCalle = datos.plector.GetString(6);
                if (!datos.plector.IsDBNull(7))
                    a.pNumero = datos.plector.GetInt32(7);
                if (!datos.plector.IsDBNull(8))
                    a.pActividad = datos.plector.GetBoolean(8);
                if (!datos.plector.IsDBNull(9))
                    a.pCasado = datos.plector.GetBoolean(9);
                if (!datos.plector.IsDBNull(10))
                    a.pHijos = datos.plector.GetBoolean(10);
                if (!datos.plector.IsDBNull(11))
                    a.pCantidad = datos.plector.GetInt32(11);
                if (!datos.plector.IsDBNull(12))
                    a.pCarrera = datos.plector.GetInt32(12);

                la.Add(a);
                }

            datos.plector.Close();
            datos.desconectar();
            lstAlumno.Items.AddRange(la.ToArray()); //el array se agrega al nuevo objeto la
                                                    // que esta dentro del agregar range
                                                    //items de la lista
            }

        private void btnGrabar_Click(object sender, EventArgs e)
            {
            string consulta = ""; //parametro para ponerle datos string. va null
            Alumno a = new Alumno(); //instancio alumno a new 
            a.pApellido = txtApellido.Text;
            a.pNombre = txtNombre.Text;
            a.pFecha = dtpFecNac.Value; //porque esta en un combo value
            if (rbtMasculino.Checked) a.pSexo = 1; else a.pSexo = 2; //es radio button, siempre va un if
            a.pTipo_doc = Convert.ToInt32(cboTipoDoc.SelectedValue); //es combo box, siempre va selected value
            a.pDocumento = int.Parse(txtDocumento.Text);
            a.pCalle = txtCalle.Text;
            a.pNumero = Convert.ToInt32(txtNumero.Text); //se puede usar con parse tb funciona
            a.pActividad = chkActividad.Checked;
            a.pCasado = chkCasado.Checked;
            a.pHijos = chkHijo.Checked;
            a.pCantidad = Convert.ToInt32(txtCantidad.Text);
            a.pCarrera = Convert.ToInt32(cboCarrera.SelectedValue);

            if (accion == 1)
                {
                if (!existe(a))
                    {
                    consulta = "INSERT INTO alumnos VALUES ('" + a.pApellido + "','" + a.pNombre + "','" + a.pFecha.ToShortDateString() + "'," + a.pDocumento + ",'" + a.pCalle + "'," + a.pNumero + "," + a.pActividad + "," + a.pCasado + "," + a.pHijos + "," + a.pCantidad + "," + a.pCarrera + ")";
                    datos.actualizarBD(consulta);
                    }
                else

                    MessageBox.Show("Este producto ya se encuentra cargado");
                }
            else
                {
                consulta = "UPDATE alumnos set nombre='" + a.pNombre + "','" + a.pFecha.ToShortDateString() + "'," + a.pDocumento + ",'" + a.pCalle + "'," + a.pNumero + "," + a.pActividad + "," + a.pCasado + "," + a.pHijos + "," + a.pCantidad + "," + a.pCarrera + " WHERE apellido=" + a.pApellido;
                datos.actualizarBD(consulta);
                cargarLista("alumnos");
                }
            habilitarComponentes(false);

            }

        private bool existe(Alumno a)
            {
            string consulta = "SELECT * FROM alumnos WHERE tipo_documento = " + a.pTipo_doc.ToString() + "AND documento = " + a.pDocumento.ToString();
            DataTable tabla = datos.consultarTabla(consulta);
            return tabla.Rows.Count > 0;
            }

        private void chkHijo_CheckedChanged(object sender, EventArgs e)
            {
            if (chkHijo.Checked)
                txtCantidad.Enabled = true;
            else
                txtCantidad.Enabled = false;
            }

        private void lstAlumno_SelectedIndexChanged(object sender, EventArgs e)
            {
            cargarCampos(lstAlumno.SelectedIndex);
            }

        private void cargarCampos(int posicion)
            {
            Alumno selected = la[posicion];
            txtApellido.Text = selected.pApellido;
            txtNombre.Text = selected.pNombre;
            txtDocumento.Text = selected.pDocumento.ToString();
            txtCalle.Text = selected.pCalle;
            txtNumero.Text = selected.pNumero.ToString();
            dtpFecNac.Value = selected.pFecha;
            txtCantidad.Text = selected.pCantidad.ToString();
            cboCarrera.SelectedValue = selected.pCarrera;
            cboTipoDoc.SelectedValue = selected.pTipo_doc;
            chkActividad.Checked = selected.pActividad;
            chkCasado.Checked = selected.pCasado;
            chkHijo.Checked = selected.pHijos;
            if (selected.pSexo == 1)
                rbtMasculino.Checked = true;
            else
                rbtFemenino.Checked = true;

            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;

            }

        private void btnEliminar_Click(object sender, EventArgs e)
            {
            if (lstAlumno.SelectedIndex != -1)
                {
                Alumno selected = la[lstAlumno.SelectedIndex];
                if (MessageBox.Show("Seguro que desea eliminar el alumno?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                    string q = "DELETE From alumnos WHERE tipo_documento = " + selected.pTipo_doc.ToString() + " AND documento = " + selected.pDocumento.ToString();
                    datos.actualizarBD(q);

                    cargarLista("alumnos");

                    }
                }

            }


        private void btnNuevo_Click(object sender, EventArgs e)
            {
            habilitarComponentes(true);
            limpiarCampos();
            accion = 1;
            }

        private void habilitarBotones(bool value)
            {
            habilitarComponentes(value);
            btnCancelar.Enabled = value;
            btnGrabar.Enabled = value;
            btnEditar.Enabled = !value;
            btnEliminar.Enabled = !value;
            btnNuevo.Enabled = !value;

            }

        private void limpiarCampos()
            {
            for (int i = 0; i < this.Controls.Count; i++)
                {
                if (this.Controls[i] is TextBox)
                    this.Controls[i].Text = "";
                if (this.Controls[i] is CheckBox)
                    ((CheckBox)this.Controls[i]).Checked = false;
                if (this.Controls[i] is RadioButton)
                    ((RadioButton)this.Controls[i]).Checked = false;
                if (this.Controls[i] is DateTimePicker)
                    ((DateTimePicker)this.Controls[i]).Value = DateTime.Today;


                }
            }
        }
    }

