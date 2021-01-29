using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace fmrPacientes
    { 
    class AccesoDatos
        {
        OleDbConnection conexion;
        OleDbCommand comando;
        DataTable tabla;
        OleDbDataReader lector;
        string cadenaConexion;

        public OleDbDataReader plector { get { return lector; } set { lector = value; } }

        public string pcadenaConexion { get { return cadenaConexion; } set { cadenaConexion = value; } }

        public AccesoDatos()
            {
            conexion = new OleDbConnection();
            comando = new OleDbCommand();
            tabla = new DataTable();
            lector = null;
            cadenaConexion = "";
            }

        public AccesoDatos(string cadenaConexion)
            {
            conexion = new OleDbConnection();
            comando = new OleDbCommand();
            tabla = new DataTable();
            lector = null;
            this.cadenaConexion = cadenaConexion;
            }

        private void Conectar()
            {
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            }
        
        public void Desconectar()
            {
            conexion.Close();
            conexion.Dispose();
            }

        public DataTable consultarTabla(string nombreTabla)
            {
            this.Conectar();
            comando.CommandText = "SELECT * FROM " + nombreTabla;
            tabla.Load(comando.ExecuteReader());
            this.Desconectar();
            return this.tabla;
            }

        public void leerTabla(string nombreTabla)
            {
            this.Conectar();
            comando.CommandText = "SELECT * FROM " + nombreTabla;
            this.lector = this.comando.ExecuteReader();
            }
        
        public void actualizarBD(string consultasql)
            {
            this.Conectar();
            this.comando.CommandText = consultasql;
            comando.ExecuteNonQuery();
            this.Desconectar();
            }
        

        }
    }
