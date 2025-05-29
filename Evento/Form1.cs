using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BD;


namespace Evento
{
    public partial class Eventos1 : Form
     
    {
        public Eventos1()
        {
            InitializeComponent();
          
        }
        public void ManejarFechaSeleccionada(DateTime fecha)
        {
            // Aquí puedes manejar la fecha seleccionada
            MessageBox.Show("Fecha seleccionada: " + fecha.ToShortDateString());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //AgregarBordeRedondeadoBoton(btnGuardar);

            if (string.IsNullOrWhiteSpace(txtidevento.Text) ||
                string.IsNullOrWhiteSpace(txtdia.Text) ||
                string.IsNullOrWhiteSpace(txtCrear.Text) ||
                string.IsNullOrWhiteSpace(txtNota.Text)
               )
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            btnAceptar.Enabled = false;
            btnAceptar.Text = "Guardando...";

            Thread hiloGuardar = new Thread(() =>
            {
                try
                {
                    ConexionMySql conexionBD = new ConexionMySql();
                    var conexion = new ConexionMySql();
                    conexion.AbrirConexion();

                    string passwordHasheada = ConexionMySql.HashPassword(txtNota.Text.Trim());

                    string query = "INSERT INTO eventos (ideventos, dia, evento, notas) " +
                                   "VALUES (@ideventos, @dia, @evento, @notas)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion.AbrirConexion()))
                    {
                        cmd.Parameters.AddWithValue("@ideventos", txtidevento.Text.Trim());
                        cmd.Parameters.AddWithValue("@dia", txtdia.Text.Trim());
                        cmd.Parameters.AddWithValue("@evento", txtCrear.Text.Trim());
                        cmd.Parameters.AddWithValue("@notas", txtNota.Text.Trim());
                       // cmd.Parameters.AddWithValue("@contraseña", passwordHasheada);

                        cmd.ExecuteNonQuery();
                    }

                    conexionBD.CerrarConexion();

                    this.Invoke((MethodInvoker)delegate
                    {
                        MessageBox.Show("Usuario registrado correctamente.");

                        txtidevento.Clear();
                        txtdia.Clear();
                        txtCrear.Clear();
                        txtNota.Clear();

                        btnAceptar.Enabled = true;
                        btnAceptar.Text = "Guardar";
                    });
                }
                catch (Exception ex)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        MessageBox.Show("Error al guardar: " + ex.Message);
                        btnAceptar.Enabled = true;
                        btnAceptar.Text = "Guardar";
                    });
                }
            });

            hiloGuardar.IsBackground = true;
            hiloGuardar.Start();

        }

        private void btnNegar_Click(object sender, EventArgs e)
        {
            // Desactivar botón y mostrar feedback
            btnNegar.Enabled = false;
            btnNegar.Text = "Cancelando...";

            // Crear y ejecutar hilo

            Thread hiloNegar = new Thread(() =>
            {
                // Simular operación de guardado lenta (ej. escribir en base de datos)
                Thread.Sleep(500); // Simula 2 segundos de proceso

                // Volver al hilo principal (UI) para actualizar controles
                this.Invoke((MethodInvoker)delegate
                {
                    MessageBox.Show("Operacion Cancelada.");

                    btnNegar.Enabled = true;
                    btnNegar.Text = "Cancelado";

                    this.Close();
                    // Si todos los datos son válidos
                    //   MessageBox.Show("Datos guardados correctamente.");
                    //this.Close();
                });
            });
            hiloNegar.IsBackground = true;
            hiloNegar.Start();
           
        }

        private void txtCrear_TextChanged(object sender, EventArgs e)
        {
            txtCrear.BackColor = Color.Yellow;
            txtNota.BackColor = Color.White;
            txtdia.BackColor = Color.White;
            txtidevento.BackColor = Color.White;
        }

        private void Eventos1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void txtNota_TextChanged(object sender, EventArgs e)
        {
            txtNota.BackColor = Color.Yellow;
            txtCrear.BackColor = Color.White;
            txtdia.BackColor = Color.White;
            txtidevento.BackColor = Color.White;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void lbEventos_Click(object sender, EventArgs e)
        {
            
        }

        private void txtdia_TextChanged(object sender, EventArgs e)
        {
            txtCrear.BackColor = Color.White;
            txtNota.BackColor = Color.White;
            txtdia.BackColor = Color.Yellow;
            txtidevento.BackColor = Color.White;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            txtCrear.BackColor = Color.White;
            txtNota.BackColor = Color.White;
            txtdia.BackColor = Color.White;
            txtidevento.BackColor = Color.Yellow;
        }
    }
}
