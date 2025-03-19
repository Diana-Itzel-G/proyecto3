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

        private void Calendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime fechaSeleccionada = Calendario.SelectionStart;

            // Llamar al método del otro proyecto
            Eventos1 eventos2 = new Eventos1();
            eventos2.ManejarFechaSeleccionada(fechaSeleccionada);
            bool DatosCorrectos = true;
            if (DatosCorrectos)
            {
                DialogResult result = MessageBox.Show("¿quieres agregar un evento?", "confirmacion",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                   
                    eventos2.Show();
                }
                else
                {
                   
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
