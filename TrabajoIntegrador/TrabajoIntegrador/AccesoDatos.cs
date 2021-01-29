using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace TrabajoIntegrador
    {
    class AccesoDatos
        {
        OleDbConnection conexion;
        OleDbCommand comando;
        OleDbDataReader lector;
        DataTable tabla;
        string cadenaConexion;

        public OleDbDataReader pLector { get { return lector; } set { lector = value; } }

        public string pcadenaConexion { get { return cadenaConexion; } set { cadenaConexion = value; } }

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
            this.conexion = new OleDbConnection(cadenaConexion);
            this.comando = new OleDbCommand();
            this.lector = null;
            this.tabla = new DataTable();
            this.cadenaConexion = cadenaConexion;
            }

        public void Conectar()
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
            tabla = new DataTable();
            Conectar();
            comando.CommandText = "SELECT * FROM " + nombreTabla;
            tabla.Load(comando.ExecuteReader());
            Desconectar();
            return tabla;
            }

        public DataTable consultas(string sql)
            {
            tabla = new DataTable();
            Conectar();
            comando.CommandText = sql;
            tabla.Load(comando.ExecuteReader());
            Desconectar();
            return tabla;


            }

        public void leerTabla(string nombreTabla)
            {
            this.Conectar();
            this.comando.CommandText = "SELECT * FROM " + nombreTabla;
            this.lector = comando.ExecuteReader();
            }

        public void actualizarBD(string consultasBD)
            {
            this.Conectar();
            this.comando.CommandText = consultasBD;
            comando.ExecuteNonQuery();
            this.Desconectar();
            }


        }
    

    }
