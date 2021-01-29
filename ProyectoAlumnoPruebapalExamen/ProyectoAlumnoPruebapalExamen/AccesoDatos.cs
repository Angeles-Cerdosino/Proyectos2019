using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace ProyectoAlumnoPruebapalExamen
    {
    class AccesoDatos
        {
        OleDbConnection conexion;
        OleDbCommand comando;
        OleDbDataReader lector;
        DataTable tabla;
        string cadenaConexion;

        public OleDbDataReader plector
            { get { return lector; } set { lector = value; } }

        public string pcadenaConexion
            { get { return cadenaConexion; } set { cadenaConexion = value; } }
        
        //constructres c/s parametros
        public AccesoDatos()
        {
            conexion = new OleDbConnection();
            comando = new OleDbCommand();
            lector = null;
            tabla = new DataTable();
            cadenaConexion = "";
        }
        public AccesoDatos(string cadenaConexion)
            {
            this.conexion = new OleDbConnection();
            this.comando = new OleDbCommand();
            this.lector = null;
            this.cadenaConexion = cadenaConexion;
            }

        private void conectar()
        {
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            comando.Connection=conexion;
            comando.CommandType = CommandType.Text;
        }

        public void desconectar()
            {
            conexion.Close();
            conexion.Dispose();
            }
            
        public DataTable consultarTabla (string nombreTabla)
            {
            this.conectar();
            comando.CommandText = "SELECT * FROM " + nombreTabla;
            tabla.Load(comando.ExecuteReader());
            this.desconectar();
            return this.tabla;
            }

        public void leerTabla(string nombreTabla)
            {
            this.conectar();
            this.comando.CommandText = "SELECT * FROM " + nombreTabla;
            this.lector = this.comando.ExecuteReader();
            }

        public void actualizarBD(string consultasBD)
            {
            this.conectar();
            this.comando.CommandText = consultasBD;
            comando.ExecuteNonQuery();
            this.desconectar();
            }

        public DataTable consultar(string query)
            {
            tabla = new DataTable();
            conectar();
            comando.CommandText = query;
            tabla.Load(comando.ExecuteReader());
            desconectar();
            return tabla;
            }
        }
    }
