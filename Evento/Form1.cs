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

            // Verificar si el campo está vacío
            if (string.IsNullOrWhiteSpace(txtCrear.Text))
            {
                MessageBox.Show("El campo crear evento no puede estar vacío.");
                txtCrear.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNota.Text))
            {
                MessageBox.Show("El campo nota(s) no puede estar vacío.");
                txtNota.Focus();
                return;
            }
            // Desactivar botón y mostrar feedback
            btnAceptar.Enabled = false;
            btnAceptar.Text = "Guardando...";

            // Crear y ejecutar hilo

            Thread hiloAceptar = new Thread(() =>
            {
                // Simular operación de guardado lenta (ej. escribir en base de datos)
                Thread.Sleep(2000); // Simula 2 segundos de proceso

                // Volver al hilo principal (UI) para actualizar controles
                this.Invoke((MethodInvoker)delegate
                {
                    MessageBox.Show("Datos guardados correctamente.");

                    btnAceptar.Enabled = true;
                    btnAceptar.Text = "Guardar";

                    this.Close();
                    // Si todos los datos son válidos
                    //   MessageBox.Show("Datos guardados correctamente.");
                    //this.Close();
                });
            });
            hiloAceptar.IsBackground = true;
            hiloAceptar.Start();
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
        }

        private void Eventos1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void txtNota_TextChanged(object sender, EventArgs e)
        {
            txtNota.BackColor = Color.Yellow;
            txtCrear.BackColor = Color.White;
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
    }
}
