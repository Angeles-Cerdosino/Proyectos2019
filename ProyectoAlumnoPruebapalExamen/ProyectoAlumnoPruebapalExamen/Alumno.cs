using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAlumnoPruebapalExamen
    {
    class Alumno
        {
        private string apellido; //0
        private string nombre;  //1
        private DateTime fecha; //2
        private int sexo;       //3
        private int tipo_doc;   //4
        private int documento;  //5
        private string calle;   //6
        private int numero;     //7
        private bool actividad; //8 
        private bool casado;    //9
        private bool hijos;     //10
        private int cantidad;   //11
        private int carrera;    //12

        public string pApellido
            { get { return apellido; } set { apellido = value; } }

        public string pNombre
            { get { return nombre; } set { nombre = value; } }

        public DateTime pFecha
            { get { return fecha; } set { fecha = value; } }

        public int pSexo
            { get { return sexo; } set { sexo = value; } }

        public int pTipo_doc
            { get { return tipo_doc; } set { tipo_doc = value; } }

        public int pDocumento
            { get { return documento; } set { documento = value; } }

        public string pCalle
            { get { return calle; } set { calle = value; } }

        public int pNumero
            { get { return numero; } set { numero = value; } }

        public bool pActividad
            { get { return actividad; } set { actividad = value; } }

        public bool pCasado
            { get { return casado; } set { casado = value; } }

        public bool pHijos
            { get { return hijos; } set { hijos = value; } }

        public int pCantidad
            { get { return cantidad; } set { cantidad = value; } }

        public int pCarrera
            { get { return carrera; } set { carrera = value; } }

        //constru con parametros crtl + .
        public Alumno(string apellido, string nombre, DateTime fecha, int sexo, int tipo_doc, int documento, string calle, int numero, bool actividad, bool casado, bool hijos, int cantidad, int carrera)
            {
            this.apellido = apellido;
            this.nombre = nombre;
            this.fecha = fecha;
            this.sexo = sexo;
            this.tipo_doc = tipo_doc;
            this.documento = documento;
            this.calle = calle;
            this.numero = numero;
            this.actividad = actividad;
            this.casado = casado;
            this.hijos = hijos;
            this.cantidad = cantidad;
            this.carrera = carrera;
            }

        public Alumno()
            {
            apellido = "";
            nombre = "";
            fecha = DateTime.Today;
            sexo = 0;
            tipo_doc = 0;
            documento = 0;
            calle = "";
            numero = 0;
            actividad = false;
            casado = false;
            hijos = false;
            cantidad = 0;
            carrera = 0;
            }

        public string toString()
            {
            return nombre + " , " + apellido;
            }
        public override string ToString()
            {
            return nombre + " , " + apellido;
            }
        }
    }
