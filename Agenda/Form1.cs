using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Evento;

namespace Agenda
{
    public partial class FechaAct : Form
    {
        public FechaAct()
        {
            InitializeComponent();
        }

        private void Agenda_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private async void Calendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime fechaSeleccionada = Calendario.SelectionStart;

            // Ejecutar en segundo plano con Task.Run
            await Task.Run(() =>
            {
                Eventos1 eventos2 = new Eventos1();
                eventos2.ManejarFechaSeleccionada(fechaSeleccionada);

                bool DatosCorrectos = true;

                if (DatosCorrectos)
                {
                    // Mostrar el MessageBox en el hilo principal 
                    DialogResult result = DialogResult.None;

                    Invoke(new Action(() =>
                    {
                        result = MessageBox.Show("¿Quieres agregar un evento?", "Confirmación",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    }));

                    if (result == DialogResult.Yes)
                    {
                        // Mostrar el formulario en el hilo principal
                        Invoke(new Action(() =>
                        {
                            eventos2.Show();
                        }));
                    }
                }
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
