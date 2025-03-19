using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registro;
using Agenda;

namespace iniciarSesion
{
    public partial class IniciarSesion : Form
    {
        private Timer resetColorTimer;
        public IniciarSesion()
        {
            InitializeComponent();
            txtUsuario.TextChanged += txtUsuario_TextChanged;
        }
      

        private void IniciarSesion_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

        }

        private void pnsesion_Paint(object sender, PaintEventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Registrarse registrarse1 = new Registrarse();
            registrarse1.Show();
        }

        private void btnSesion_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("El campo usuario no puede estar vacío.");
                txtUsuario.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("El campo numero de control no puede estar vacío.");
                txtContraseña.Focus();
                return;
            }
            FechaAct agenda1 = new FechaAct();
            agenda1.Show();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            txtUsuario.BackColor = Color.Yellow;
            txtContraseña.BackColor = Color.White;
           
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            txtContraseña.BackColor = Color.Yellow;
            txtUsuario.BackColor = Color.White;
        }
    }
}
//subir carpeta a git 
