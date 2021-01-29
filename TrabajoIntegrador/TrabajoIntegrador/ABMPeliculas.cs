using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoIntegrador
    {
    public partial class ABMPeliculas : Form
        {
        AccesoDatos datos = new AccesoDatos(@"Provider=SQLNCLI11;Data Source=SHEE\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=CINE_ESTRELLAS_FINAL");
        Peliculas[] ap = new Peliculas[tam];
        const int tam = 50;
        bool nuevo;
        int c = 0;


        public ABMPeliculas()
            {
            InitializeComponent();
            nuevo = false;
            c = 0;
            for (int i = 0; i < tam; i++)
                {
                ap[i] = null;
                }
            }

        private void ABMPeliculas_Load(object sender, EventArgs e)
            {
            cargarCombo(cboversion, "versiones");
            cargarCombo(cboclasificacion, "clasificaciones");
            cargarCombo(cbogenero, "generos_peliculas");
            cargarLista("PELICULAS");
            habilitar(false);
            }

        private void cargarLista(string nombreTabla)
            {
            datos.leerTabla(nombreTabla);
            c = 0;
            while (datos.pLector.Read())
                {
                Peliculas a = new Peliculas();
                if (!datos.pLector.IsDBNull(0))
                    a.pId_pelicula = datos.pLector.GetInt32(0);
                if (!datos.pLector.IsDBNull(1))
                    a.pNombre = datos.pLector.GetString(1);
                if (!datos.pLector.IsDBNull(2))
                    a.pDuracion = datos.pLector.GetInt32(2);
                if (!datos.pLector.IsDBNull(3))
                    a.pAño_estreno = datos.pLector.GetDateTime(3);
                if (!datos.pLector.IsDBNull(4))
                    a.pId_clasificacion = datos.pLector.GetInt32(4);
                if (!datos.pLector.IsDBNull(5))
                    a.pId_version = datos.pLector.GetInt32(5);
                if (!datos.pLector.IsDBNull(6))
                    a.pIdgenero_pelicula = datos.pLector.GetInt32(6);

                ap[c] = a;
                c++;

                }
            datos.pLector.Close();
            datos.Desconectar();
            lstpelicula.Items.Clear();
            for (int i = 0; i < c; i++)
                {
                lstpelicula.Items.Add(ap[i].ToString());
                }
            lstpelicula.SelectedIndex = 0;

            }
        private void btnnuevo_Click(object sender, EventArgs e)
            {
            this.nuevo = true;
            this.habilitar(true);
            this.limpiar();
            this.txtnombre.Focus();
            txtidpelicula.Text = Convert.ToString(c + 1);
            txtidpelicula.Enabled = false;
            lstpelicula.Enabled = true;
            }

        private void cargarCombo(ComboBox cbo, string nombreTabla)
            {
            DataTable tabla = new DataTable();
            tabla = datos.consultarTabla(nombreTabla);
            cbo.DataSource = tabla;
            cbo.ValueMember = tabla.Columns[0].ColumnName;
            cbo.DisplayMember = tabla.Columns[1].ColumnName;
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo.SelectedIndex = -1;

            }


        private void limpiar()
            {
            txtidpelicula.Text = "";
            txtnombre.Clear();
            dtpestreno.Value = DateTime.Today;
            txtduracion.Clear();
            cboversion.SelectedIndex = -1;
            cboclasificacion.SelectedIndex = -1;
            cbogenero.SelectedIndex = -1;

            }
        private void habilitar(bool x)
            {
            txtidpelicula.Enabled = x;
            txtnombre.Enabled = x;
            cboclasificacion.Enabled = x;
            cboversion.Enabled = x;
            cbogenero.Enabled = x;
            dtpestreno.Enabled = x;
            txtduracion.Enabled = x;
            btngrabar.Enabled = x;
            btnborrar.Enabled = x;
            btncancelar.Enabled = x;
            lstpelicula.Enabled = x;

            btnnuevo.Enabled = !x;
            btneditar.Enabled = !x;
            

            }

        private void btneditar_Click(object sender, EventArgs e)
            {
            this.habilitar(true);
            this.txtidpelicula.Enabled = false;
            nuevo = false;
            txtnombre.Focus();
            lstpelicula.Enabled = true;
            }

        private void btngrabar_Click(object sender, EventArgs e)
            {
            if (validar())
                {
                        string consultapeli = "";
                        Peliculas p = new Peliculas();
                        p.pId_pelicula = int.Parse(txtidpelicula.Text);
                        p.pNombre = txtnombre.Text;
                        p.pDuracion = int.Parse(txtduracion.Text);
                        p.pAño_estreno = dtpestreno.Value;
                        p.pId_clasificacion = Convert.ToInt32(cboclasificacion.SelectedValue);
                        p.pId_version = Convert.ToInt32(cboversion.SelectedValue);
                        p.pIdgenero_pelicula = Convert.ToInt32(cbogenero.SelectedValue);

                if (nuevo)
                    {
                    if (!existe(p.pId_pelicula))
                        {
                        consultapeli = "INSERT INTO PELICULAS values('" +
                                p.pNombre + "'," +
                                p.pDuracion + ",'" +
                                p.pAño_estreno.ToString("yyyy-MM-dd") + "'," +
                                p.pId_clasificacion + "," +
                                p.pId_version + "," +
                                p.pIdgenero_pelicula + ")";
                        datos.actualizarBD(consultapeli);
                        MessageBox.Show("La pelicula se cargó correctamente!");
                        this.cargarLista("peliculas");
                                                
                        }
                    else
                        {
                        MessageBox.Show("Esta pelicula ya esta registrada");
                        
                        }
                    }
                
                else
                    {
                    consultapeli = "UPDATE Peliculas SET " +
                            "nombre='" + p.pNombre + "', " +
                            "duracion=" + p.pDuracion + ", " +
                            "año_estreno= '" + p.pAño_estreno.ToShortDateString() + "', " +
                            "id_clasificacion=" + p.pId_clasificacion + ", " +
                            "id_version=" + p.pId_version + ", " +
                            "idgenero_pelicula=" + p.pIdgenero_pelicula +//espacio en blanco antes del where y comillas simples en fecha
                            " WHERE id_pelicula =" + p.pId_pelicula;
                    datos.actualizarBD(consultapeli);
                    this.cargarLista("peliculas");
                    MessageBox.Show("La pelicula se actualizó correctamente!");
                    
                
                    }

                    habilitar(false);
                    nuevo = false;
                lstpelicula.Enabled = true;
                }

                }
            
        
    
        private bool existe (int pk)
            {
            for (int i = 0; i< c;i++)
            {
                if (ap[i].pId_pelicula == pk)
                    return true;
                }
            return false;
            }

        private void btncancelar_Click(object sender, EventArgs e)
            {
            this.cargarCombo(cboversion, "versiones");
            this.cargarCombo(cboclasificacion, "clasificaciones");
            this.cargarCombo(cbogenero, "generos_peliculas");
            this.cargarLista("peliculas");
            this.habilitar(false);
            this.limpiar();
            }

        private void ABMPeliculas_FormClosing(object sender, FormClosingEventArgs e)
            {
            if (MessageBox.Show("Esta seguro que desea salir de la aplicación?"
                               , "SALIR"
                               , MessageBoxButtons.OKCancel
                               , MessageBoxIcon.Question
                               , MessageBoxDefaultButton.Button1)
                               == DialogResult.OK)
                e.Cancel = false;
            else
                e.Cancel = true;
            }

        private void btnborrar_Click(object sender, EventArgs e)
            {
            if (MessageBox.Show("Esta seguro de querer borrar la pelicula "
                + ap[lstpelicula.SelectedIndex].pNombre + " ?"
                , "ELIMINANDO"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Warning
                , MessageBoxDefaultButton.Button2)
                == DialogResult.Yes)
                {
                string consultaSQL = "DELETE FROM peliculas "
                + "WHERE id_pelicula="
                + ap[lstpelicula.SelectedIndex].pId_pelicula;

                datos.actualizarBD(consultaSQL);
                this.cargarLista("peliculas");
                }
            btnborrar.Enabled = true;
            lstpelicula.Enabled = true;
            }

        private void lstpelicula_SelectedIndexChanged(object sender, EventArgs e)
            {
            if(lstpelicula.SelectedIndex != -1)
                {
                cargarCampos(lstpelicula.SelectedIndex);
                }
            
            }

        private void cargarCampos(int posicion)
            {
            txtidpelicula.Text = ap[posicion].pId_pelicula.ToString();
            txtnombre.Text = ap[posicion].pNombre;
            dtpestreno.Value = ap[posicion].pAño_estreno;
            txtduracion.Text = ap[posicion].pDuracion.ToString();
            cboversion.SelectedValue = ap[posicion].pId_version;
            cboclasificacion.SelectedValue = ap[posicion].pId_clasificacion;
            cbogenero.SelectedValue = ap[posicion].pIdgenero_pelicula;
            
            }
        private bool validar() 
            {
            if (string.IsNullOrEmpty(txtidpelicula.Text)) 
                {
                MessageBox.Show("El campo código no puede quedar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtidpelicula.Focus();
                return false; 
                }

            else
                {
                int codigo;
                if (!int.TryParse(txtidpelicula.Text, out codigo))
                    {
                    MessageBox.Show("En el campo código debe ingresar solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtidpelicula.Focus();
                    return false;
                    }
                }

            if (string.IsNullOrEmpty(txtnombre.Text))
                {
                MessageBox.Show("En el campo Nombre debe ingresar uno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtnombre.Focus();
                return false;
                }
            else
            if(Regex.IsMatch(txtnombre.Text, "^[a-zA-Z ] +$"))
                {
                MessageBox.Show("El campo nombre admite solo letras");
                txtnombre.Focus();
                return false;
                }


            if (string.IsNullOrEmpty(txtduracion.Text)) //-1 no muestra datos. siempre empieza en cero
                {
                MessageBox.Show("En el campo duracion debe ingresar uno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtduracion.Focus();
                return false;
                }

            if(dtpestreno.Value > DateTime.Now)
                {
                MessageBox.Show("No puede ingresar una fecha futura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtpestreno.Focus();
                return false;
                }


            if (cboversion.SelectedIndex == -1)
                {
                MessageBox.Show("Debe seleccionar una version", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboversion.Focus();
                return false;
                }
            if (cboclasificacion.SelectedIndex == -1)
                {
                MessageBox.Show("Debe seleccionar una clasificación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboclasificacion.Focus();
                return false;
                }
            if(cbogenero.SelectedIndex == -1)
                {
                MessageBox.Show("Debe seleccionar una opción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbogenero.Focus();
                return false;
                }

            return true;

            }

        private void btnsalir_Click(object sender, EventArgs e)
            {
            this.Close();
            }

       
        }
    }
