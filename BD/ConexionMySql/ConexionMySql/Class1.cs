using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace BD
{
    public class ConexionMySql
    {
        private MySqlConnection conexion;

        public ConexionMySql()
        {
            string servidor = "localhost";
            string baseDatos = "enfocatec";
            string usuario = "root";
            string contraseña = " "; // Aquí NO debes poner la contraseña hasheada

            string cadenaConexion = $"server={servidor};database={baseDatos};uid={usuario};pwd={contraseña};";

            conexion = new MySqlConnection(cadenaConexion);
        }

        public MySqlConnection AbrirConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Closed)
            {
                conexion.Open();
            }
            return conexion;
        }

        public void CerrarConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }

        // Método para hashear contraseñas usando SHA256
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2")); // Formato hexadecimal
                }
                return sb.ToString();
            }
        }
    }
}


