using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fmrPacientes
    {
    class Pacientes
        {

        private int HC;
        private string nombre;
        private string apellido;
        private int telefono;
        private int sexo;
        private int OS;
        private DateTime fechaNac;

        public int pHC { get { return HC; } set { HC = value; } }

        public string pnombre { get { return nombre; } set { nombre = value; } }

        public string papellido { get { return apellido; } set { apellido = value; } }

        public int ptelefono { get { return telefono; } set { telefono = value; } }

        public int psexo
            { get { return sexo; } set { sexo = value; } }

        public int pOS { get { return OS; } set { OS = value; } }

        public DateTime pfechaNac { get { return fechaNac; } set { fechaNac = value; } } 

        public Pacientes(int hC, string nombre, string apellido, int telefono, int sexo, int oS, DateTime fechaNac)
            {
            this.HC = hC;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.sexo = sexo;
            this.OS = oS;
            this.fechaNac = fechaNac;
            }

        public Pacientes()
            {
            HC = 0;
            nombre = "";
            apellido = "";
            telefono = 0;
            sexo = 0;
            OS = 0;
            fechaNac = DateTime.Today;
            }
        override public string ToString()
            {
            return HC + " " + nombre + ", " + apellido + " " + OS;
            }
        }
    }
