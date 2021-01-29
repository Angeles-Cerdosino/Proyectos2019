using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProducto
    {
    class Producto
        {
        private int codigo;
        private int tipo;
        private string detalle;
        private int marca;
        private double precio;
        private DateTime fecha;

        public DateTime pFecha
            { get { return fecha; } set { fecha = value; } }

        public int pCodigo
            { get { return codigo; } set { codigo = value; } }

        public string pDetalle
            { get { return detalle; } set { detalle = value; } }

        public int pMarca
            { get { return marca; } set { marca = value; } }

        public double pPrecio
            { get { return precio; } set { precio = value; } }

        public int pTipo
            { get { return tipo; } set { tipo = value; } }

        public Producto()
            { precio = codigo = 0; detalle = ""; marca = 0; fecha = DateTime.Today; }

        public Producto(int codigo, string detalle, int marca, double precio, DateTime fecha)
            { this.codigo = codigo; this.detalle = detalle; this.marca = marca; this.precio = precio; this.fecha = fecha; }

        override public string ToString() // el virtual a diferencia del abstract hace algo y se puede utilizar
            {
            return "El producto con codigo:" + codigo +
              ", con descripcion: " + detalle +
              ", con marca: " + marca +
              ", tiene un precio: " + precio;
            }
        }
    }
