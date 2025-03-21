using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Registro
{
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent();


        } 

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            txtClientes.BackColor = Color.White;
            txtControl.BackColor = Color.White;
            txttelefono.BackColor = Color.Yellow;
            txtCorreo.BackColor = Color.White;
            txtPin.BackColor = Color.White;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtClientes.BackColor = Color.Yellow;
            txtControl.BackColor = Color.White;
            txttelefono.BackColor = Color.White;
            txtCorreo.BackColor = Color.White;
            txtPin.BackColor = Color.White;
        }

        private void lbPin_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_TextChanged(object sender, EventArgs e)
        {
            btnGuardar.BackColor = Color.AliceBlue;
            btnGuardar.BackColor = Color.White;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtClientes.Text))
            {
                MessageBox.Show("El campo usuario no puede estar vacío.");
                txtClientes.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtControl.Text))
            {
                MessageBox.Show("El campo numero de control no puede estar vacío.");
                txtControl.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txttelefono.Text))
            {
                MessageBox.Show("El campo telefono no puede estar vacío.");
                txttelefono.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("El campo correo no puede estar vacío.");
                txtCorreo.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPin.Text))
            {
                MessageBox.Show("El campo contraseña no puede estar vacío.");
                txtPin.Focus();
                return;
            }


            // Si todos los datos son válidos
            MessageBox.Show("Datos guardados correctamente.");
            this.Close();
        
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Aquí puedes agregar el código para cancelar la operación
            this.Close(); // Cierra el formulario actual
        }

        private void Registrarse_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        
    }

        private void txtControl_TextChanged(object sender, EventArgs e)
        {
            txtClientes.BackColor = Color.White;
            txtControl.BackColor = Color.Yellow;
            txttelefono.BackColor = Color.White;
            txtCorreo.BackColor = Color.White;
            txtPin.BackColor = Color.White;

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            txtClientes.BackColor = Color.White;
            txtControl.BackColor = Color.White;
            txttelefono.BackColor = Color.White;
            txtCorreo.BackColor = Color.Yellow;
            txtPin.BackColor = Color.White;
        }

        private void txtPin_TextChanged(object sender, EventArgs e)
        {
            txtClientes.BackColor = Color.White;
            txtControl.BackColor = Color.White;
            txttelefono.BackColor = Color.White;
            txtCorreo.BackColor = Color.White;
            txtPin.BackColor = Color.Yellow;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // color tratar mandar cambio
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            int radius = 20; // Radio de las esquinas redondeadas

            // Crear un camino con bordes redondeados
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            // Aplicar la forma redondeada al panel
            panel.Region = new Region(path);

            // Opcional: Dibujar borde
            using (Pen pen = new Pen(Color.Black, 2))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }
    }
}
