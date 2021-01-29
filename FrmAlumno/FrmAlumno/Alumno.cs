using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmAlumno
{
    class Alumno
        {
        private string nombre; //atributos de la clase
        private int legajo;
        private double nota1;
        private double nota2;
        private double nota3;

        public string pnombre  // propiedades del atributo para que se puedan acceder a los atributos con los metodos
            {
            set { nombre = value; }
            get { return nombre; }
            }
        public int plegajo
            {
            set { legajo = value; }
            get { return legajo; }
            }
        public double pnota1
            {
            set { nota1 = value; }
            get { return nota1; }
            }
        public double pnota2
            {
            set { nota2 = value; }
            get { return nota2; }
            }
        public double pnota3
            {
            set { nota3 = value; }
            get { return nota3; }
            }

        public Alumno(int legajo, string nombre, double nota1, double nota2, double nota3)  // metodo constructor con parametros //metodo constructor que recibe parametros, entonces iniciliza sus atributos con el valor que se manda desde el main, en este caso desde el FrmAlumno
            {
            this.legajo = legajo; this.nombre = nombre; this.nota1 = nota1; this.nota2 = nota2; this.nota3 = nota3;
            }

        public Alumno() //metodo constructor sin parametros, entonces inicializo los atributos en cero
            {
            legajo = 0; nombre = ""; nota1 = 0; nota2 = 0; nota3 = 0;
            }

        public double calcularPromedio() // metodo que calcula promedio
            {
            double p = 0;
            p = (nota1 + nota2 + nota3) / 3;
            return Math.Round(p, 2); // al ser un metodo le indico dentro de () que quiero que me devuelva, en este caso el resultado de p, 2 decimales
            }

        public string toString() //metodo que muestra en MessageBox el resultado como una cadena de caracteres
            {
            return "El Alumno = " + nombre + "con Legajo = " + legajo + Convert.ToString(legajo) +
                    "\n tiene las siguientes notas = \n Nota 1 = " + Convert.ToString(nota1) +
                    "\n Nota 2 = " + Convert.ToString(nota2) +
                    "\n Nota 3 = " + Convert.ToString(nota3) +
                    "El Promedio es =" + Convert.ToString(calcularPromedio());
            }
        public int calcularCondicion() // metodo que devuelve un NUMERO dependiendo de la condicion del alumno
            {
            if(calcularPromedio()>=8)
                {
                return 1; // promocionado
                }
            if(this.calcularPromedio()>=6)
                {
                return 2; // regular
                }
            else
                {
                return 3; // libre
                }
            }

        public string MostrarCondicion() //metodo que muestra en texto la condicion del alumno de acuerdo al resultado de CalcularCondicion()
            {
            string condicion = ""; // se declara e inicializa  una variable condicion
            switch(calcularCondicion()) // swith permite sacar resultados, evaluar condiciones. dentro de () ponemos la variable o el metodo que queremos que valide
                 {
                case 1:
                    condicion = "Promocionado";
                    break;
                case 2:
                    condicion = "Regular";
                    break;
                case 3:
                    condicion = "libre";
                    break;
                default:                 // el default se usa en el caso que no encuentre ninguna de las opciones anteriores
                    condicion = "Error";
                    break;
                }
            return condicion; // devuelve condicion como string
            }
        }
}
