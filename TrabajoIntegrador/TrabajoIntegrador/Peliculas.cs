using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoIntegrador
    {
    class Peliculas
        {

        private int id_pelicula;
        private string nombre;
        private int duracion;
        private DateTime año_estreno;
        private int id_clasificacion;
        private int id_version;
        private int idgenero_pelicula;
               

        public int pId_pelicula
            { get { return id_pelicula; } set { id_pelicula = value; } }

        public string pNombre
            { get { return nombre; } set { nombre = value; } }

        public int pDuracion
            { get { return duracion; } set { duracion = value; } }

        public DateTime pAño_estreno
            { get { return año_estreno; } set { año_estreno = value; } }

        public int pId_clasificacion
            { get { return id_clasificacion; } set { id_clasificacion = value; } }

        public int pId_version
            { get { return id_version; } set { id_version = value; } }

        public int pIdgenero_pelicula
            { get { return idgenero_pelicula; } set { idgenero_pelicula = value; } }

        public Peliculas()
            {
            id_pelicula = 0;
            nombre = "";
            duracion = 0;
            año_estreno = DateTime.Today;
            id_clasificacion = 0;
            id_version = 0;
            idgenero_pelicula = 0;
            }

        public Peliculas(int id_pelicula, string nombre, int duracion, DateTime año_estreno, int id_clasificacion, int id_version, int idgenero_pelicula)
            {
            this.id_pelicula = id_pelicula;
            this.nombre = nombre;
            this.duracion = duracion;
            this.año_estreno = año_estreno;
            this.id_clasificacion = id_clasificacion;
            this.id_version = id_version;
            this.idgenero_pelicula = idgenero_pelicula;
            }

        public override string ToString()
            {
            return "Pelicula= " + nombre + ", con duracion = " + duracion + ", con año de estreno  = " + año_estreno.ToShortDateString() 
                + "\n ";
            }
        }
    }
