using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD  // Coincide con tu carpeta BD en el proyecto
{
    public class ConexionMySql
    {
        private MySqlConnection conexion;
        private string cadenaConexion;

        // Configura tus datos de conexión aquí
        private string database = "enfocatec";
        private string server = "localhost";
        private string user = "root";
        private string password = "";  // Si tienes contraseña, colócala aquí

        public ConexionMySql()
        {
            cadenaConexion = $"Server={server};Database={database};Uid={user};Pwd={password};";
            conexion = new MySqlConnection(cadenaConexion);
        }

        public MySqlConnection AbrirConexion()
        {
            try
            {
                if (conexion.State != System.Data.ConnectionState.Open)
                    conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
            }

            return conexion;
        }

        public void CerrarConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
                conexion.Close();
        }
    }
}
