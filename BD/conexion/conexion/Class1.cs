using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace conexion
{
    public class Conexion
    {
        private string server = "localhost";
        private string database = "enfocatec";
        private string user = "root";
        private string password = "";
        private string port = "3307";
        private string cadenaConexion;
        private MySqlConnection conexion;

        public Conexion()
        {
            cadenaConexion = $"Server={server};Database={database};Uid={user};Pwd={password};port={port}";
            conexion = new MySqlConnection(cadenaConexion);
        }

        public MySqlConnection AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
            return conexion;
        }

        public void CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }
    }
}

