using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmAlumno
    {
    public partial class Form1 : Form
        {
        double c, cl, cr, cp; // declaro las variables de la clase FrmAlumno. Declaro los contadores
        double a;             // declaro el acumulador

        public Form1() // metodo constructo de la clase Frmalumno //no deberia ponerse codigo antes del inizializeComponent porque se estaria ejecutando antes de que se cree el form y aveces puede tirar error
            {          
            InitializeComponent(); //el creador del form. Aqui se inicializan todos los componentes de la ventana del formulario. todo ese codigo esta en la otra clase parcial FrmAlumno.Designer.cs la cual se crea a medida que se agregan objetos graficos en la ventana
            c = 0; cl = 0; cr = 0; cp = 0; ////inicializo los contadores cuando inicializa el frm
            a = 0; //inicializo el contador
            }

        public bool isHandled(object sender, KeyPressEventArgs e) // funcion para evaluar si se apreto la tecla incorrecta
            {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)) //clase char. metodo estatico=no necesito instanciar la clase. se llama desde la clase
                {                                                              //si no es un numero y es distinto de back(borrar)... handled es true
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
                }
            return false;
            }
        private void textLegajo_KeyPress(object sender, KeyPressEventArgs e)//evento. cuando presione la tecla
            {
            e.Handled = isHandled(sender, e);//lo envio a la funcion para evaluar si se apretó
            }

        private void txtNota1_KeyPress(object sender, KeyPressEventArgs e)
            {
            e.Handled = isHandled(sender, e);
            }

        private void txtNota2_KeyPress(object sender, KeyPressEventArgs e)
            {
            e.Handled = isHandled(sender, e);
            }

        private void txtNota3_KeyPress(object sender, KeyPressEventArgs e)
            {
            e.Handled = isHandled(sender, e);
            }

        public bool validateGrade(object sender)//funcion para validar grado
            {
            if (Convert.ToDouble(((TextBox)sender).Text) < 1 || Convert.ToDouble(((TextBox)sender).Text) > 10)
                {
                MessageBox.Show("La nota debe ser entre 1 y 10");
                return true;
                }
            return false;
            }
   
        private void txtNota1_validating(object sender, CancelEventArgs e)//validar que la nota sea entre 1 y 10
            {
            e.Cancel = validateGrade(sender);
            }

        private void txtNota2_Validating(object sender, CancelEventArgs e)
            {
            e.Cancel = validateGrade(sender);
            }

        private void Form1_Load(object sender, EventArgs e)
            {

            }

        private void btnCalcular_Click(object sender, EventArgs e) //metodo del boton. aqui va todo el codigo, seria como el "main"
            {                                                      //validaciones al principio siempre
            if (this.validar() == true)
                {
                Alumno A = new Alumno(); //se instancia la clase alunmo, es decir, se crea un alumno nuevo
                A.pnombre = Convert.ToString(txtNombre.Text); //el dato ingresado en la caja de texto Nombre (que es tipo text) se guarda
                                                              //en la propiedad pNombre del objeto A de la clase Alumno. Se debe convertir 
                                                              //a string antes de pasarlo a la clase para que coincida el tipo de dato
                A.plegajo = Convert.ToInt32(txtLegajo.Text);
                A.pnota1 = Convert.ToDouble(txtNota1.Text);
                A.pnota2 = Convert.ToDouble(txtNota2.Text);
                A.pnota3 = Convert.ToDouble(txtNota3.Text);
                txtPromedio.Text = A.calcularPromedio().ToString(); //al calculo hecho por el metodo calcularPromedio() (tipo double) en la clase
                                                                    //Alumno se le debe aplicar el metodo tostring() y guardar en la caja de texto 
                                                                    //de promedio (tipo text) de FrmAlumno
                                                                    //se incrementa el contador
                c = c + 1;
                }
            }

        private void txtNota3_Validating(object sender, CancelEventArgs e)
            {
            e.Cancel = validateGrade(sender);
            }




        private void lblLegajo_Click(object sender, EventArgs e)
            {

            }

       
        private void txtLegajo_TextChanged(object sender, EventArgs e)
            {
        
            }
        }
    }
