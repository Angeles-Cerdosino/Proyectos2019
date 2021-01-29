using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVentas
{
    class Venta
    {
        //declaracion de atributos de la clase
        private int Numero;
        private string Cliente, Articulo;
        private double Precio;
        private int Cantidad;
        //propiedades con set y get de la clase
        public int pNumero                      //propiedad del atributo numero
        {
            set { Numero = value; }
            get { return Numero; }
        }                                      //propiedad del atributo cliente
        public string pCliente
        {
            set { Cliente = value; }
            get { return Cliente; }
        }
        public double pPrecio
        {
            set { Precio = value; }
            get { return Precio; }
        }
        public int pCantidad
        {
            set { Cantidad = value; }
            get { return Cantidad; }
        }                               //metodo de la clase
        public double calcularImporte()  // metodo para calcular el importe
        {
            double i = 0;
            i = (Precio * Cantidad);
            return Math.Round(i, 2);
        }

        public Venta(string Clien, int Num, double Prec, int Cant) // este construc que recibe parametros, entonces inicializa sus atributos con sus atributos con el valor que se manda desde el main, es decir desde el FrmVenta.
        {
            this.Cliente = Clien;
            this.Numero = Num;
            this.Precio = Prec;
            this.Cantidad = Cant;
        }
        public Venta()
        {
            this.Cliente = 0; this.Numero = 0; this.Precio = 0; this.Cantidad = 0;
        }

        //metodo que muestra por consola el resultado como una cadena de caracteres
        public string toString()//metodo que muestra por consola el resultado como una cadena de caracteres, que estaba en double a string.
        {
            return "El cliente = " + nombre + " con numero = " + Convert.ToString(Numero) + // "\n" es igual a salto
                "tiene la siguiente compra=\nLa venta es= " + Convert.ToString(Cantidad) +
                "\nEl Total es= " + Convert.ToString(calcularImporte());

        }
        //public int CalcularCondicion() //metodo que devuelve un numero dependiendo de la condicion del alumno, se calcula con un metodo que devuelva un numero porque asi es mas facil operar con su resultado en el FrmAlumnos
        //{
            //if (calcularPromedio() >= 8)
            //{
                //return 1; // promocioado
            //}
            //else
            //{
                //if (this.calcularPromedio() >= 6)
                //{
                    //return 2; //regular
                //}
                //else
                //{
                   // return 3; // libre
               // }
            //}
        //}
        //public string MostrarCondicion() // metodo que muestr el texto usando el resultado de "CalcularCondicion()" de acuerdo a los numeros (1,2,3) 
        //{
          //  string condicion = ""; // se inicilializa una variable condicion
            //switch (CalcularCondicion()) // switch evalua resultados 
            //{
             //   case 1:
               //     condicion = "Promocionado";
                 //   break; // es una bandera
                //case 2:
                  //  condicion = "Regular";
                    //break;
                //case 3:
                  //  condicion = "Libre";
                    //break;
                //default:
                  //  condicion = "Error";
                    //break;
            //}
            //return condicion; // se devuelve condicion como string
        //}
    }
}
  