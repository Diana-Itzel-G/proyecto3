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
using System.Threading;
using System.Data.SqlClient;


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
            // Definir colores
            Color defaultColor = Color.White;
            Color highlightColor = Color.LightBlue;

            // Restablecer todos los TextBox al color por defecto
            txtClientes.BackColor = defaultColor;
            txtControl.BackColor = defaultColor;
            txttelefono.BackColor = defaultColor;
            txtCorreo.BackColor = defaultColor;
            txtPin.BackColor = defaultColor;

            // Resaltar solo el TextBox activo
            if (sender is TextBox textBox)
            {
                textBox.BackColor = highlightColor;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Establecer el color de fondo para todos los TextBox
            Color defaultColor = Color.White;
            Color highlightColor = Color.LightBlue;

            // Aplicar colores
            txtClientes.BackColor = highlightColor;
            txtControl.BackColor = defaultColor;
            txttelefono.BackColor = defaultColor;
            txtCorreo.BackColor = defaultColor;
            txtPin.BackColor = defaultColor;
        }

        private void lbPin_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_TextChanged(object sender, EventArgs e)
        {
            btnGuardar.BackColor = Color.AliceBlue;
            btnGuardar.BackColor = Color.White;
        }

        using BD;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
        AgregarBordeRedondeadoBoton(btnGuardar);

        if (string.IsNullOrWhiteSpace(txtClientes.Text) ||
            string.IsNullOrWhiteSpace(txtControl.Text) ||
            string.IsNullOrWhiteSpace(txttelefono.Text) ||
            string.IsNullOrWhiteSpace(txtCorreo.Text) ||
            string.IsNullOrWhiteSpace(txtPin.Text))
        {
            MessageBox.Show("Todos los campos son obligatorios.");
            return;
        }

        btnGuardar.Enabled = false;
        btnGuardar.Text = "Guardando...";

        Thread hiloGuardar = new Thread(() =>
        {
            try
            {
                ConexionMySql conexionBD = new ConexionMySql();
                var conexion = conexionBD.AbrirConexion();

                string passwordHasheada = ConexionMySql.HashPassword(txtPin.Text.Trim());

                string query = "INSERT INTO usuarios (usuario, numero_control, telefono, correo, contraseña) " +
                               "VALUES (@usuario, @control, @telefono, @correo, @contraseña)";
                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@usuario", txtClientes.Text.Trim());
                    cmd.Parameters.AddWithValue("@control", txtControl.Text.Trim());
                    cmd.Parameters.AddWithValue("@telefono", txttelefono.Text.Trim());
                    cmd.Parameters.AddWithValue("@correo", txtCorreo.Text.Trim());
                    cmd.Parameters.AddWithValue("@contraseña", passwordHasheada);

                    cmd.ExecuteNonQuery();
                }

                conexionBD.CerrarConexion();

                this.Invoke((MethodInvoker)delegate
                {
                    MessageBox.Show("Usuario registrado correctamente.");
                    btnGuardar.Enabled = true;
                    btnGuardar.Text = "Guardar";
                    this.Close();
                });
            }
            catch (Exception ex)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    MessageBox.Show("Error al guardar: " + ex.Message);
                    btnGuardar.Enabled = true;
                    btnGuardar.Text = "Guardar";
                });
            }
        });

        hiloGuardar.Start();
    }

        private void AgregarBordeRedondeadoBoton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0; // Eliminar el borde predeterminado
            button.Paint += (s, e) =>
            {
                int radio = 20; // Tamaño de las esquinas redondeadas
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, radio, radio, 180, 90);
                path.AddArc(button.Width - radio, 0, radio, radio, 270, 90);
                path.AddArc(button.Width - radio, button.Height - radio, radio, radio, 0, 90);
                path.AddArc(0, button.Height - radio, radio, radio, 90, 90);
                path.CloseFigure();

                button.Region = new Region(path);

                using (Pen pen = new Pen(Color.Gray, 2))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, path);
                }
            };
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            AgregarBordeRedondeadoBoton(btnCancelar);

            // Aquí puedes agregar el código para cancelar la operación
            this.Close(); // Cierra el formulario actual
        }

        private void Registrarse_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        
    }

        private void txtControl_TextChanged(object sender, EventArgs e)
        {
            // Definir colores
            Color defaultColor = Color.White;
            Color highlightColor = Color.LightBlue;

            // Restablecer todos los TextBox al color por defecto
            txtClientes.BackColor = defaultColor;
            txtControl.BackColor = defaultColor;
            txttelefono.BackColor = defaultColor;
            txtCorreo.BackColor = defaultColor;
            txtPin.BackColor = defaultColor;

            // Resaltar solo el TextBox activo
            if (sender is TextBox textBox)
            {
                textBox.BackColor = highlightColor;
            }

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            // Definir colores
            Color defaultColor = Color.White;
            Color highlightColor = Color.LightBlue;

            // Restablecer todos los TextBox al color por defecto
            txtClientes.BackColor = defaultColor;
            txtControl.BackColor = defaultColor;
            txttelefono.BackColor = defaultColor;
            txtCorreo.BackColor = defaultColor;
            txtPin.BackColor = defaultColor;

            // Resaltar solo el TextBox activo
            if (sender is TextBox textBox)
            {
                textBox.BackColor = highlightColor;
            }
        }

        private void txtPin_TextChanged(object sender, EventArgs e)
        {
            // Definir colores
            Color defaultColor = Color.White;
            Color highlightColor = Color.LightBlue;

            // Restablecer todos los TextBox al color por defecto
            txtClientes.BackColor = defaultColor;
            txtControl.BackColor = defaultColor;
            txttelefono.BackColor = defaultColor;
            txtCorreo.BackColor = defaultColor;
            txtPin.BackColor = defaultColor;

            // Resaltar solo el TextBox activo
            if (sender is TextBox textBox)
            {
                textBox.BackColor = highlightColor;
            }
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

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            int radio = 20; // Tamaño del radio de las esquinas redondeadas

            // Crear un gráfico de la ruta del panel
            GraphicsPath path = new GraphicsPath();

            // Agregar las esquinas redondeadas con base en el tamaño del panel
            path.AddArc(0, 0, radio, radio, 180, 90); // Esquina superior izquierda
            path.AddArc(panel.Width - radio, 0, radio, radio, 270, 90); // Esquina superior derecha
            path.AddArc(panel.Width - radio, panel.Height - radio, radio, radio, 0, 90); // Esquina inferior derecha
            path.AddArc(0, panel.Height - radio, radio, radio, 90, 90); // Esquina inferior izquierda
            path.CloseFigure(); // Cierra la figura para formar un contorno cerrado

            // Aplicar la región redondeada al panel
            panel.Region = new Region(path);

            // Dibujar el borde del panel (opcional)
            using (Pen pen = new Pen(Color.Gray, 2))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias; // Mejorar la calidad del dibujo
                e.Graphics.DrawPath(pen, path); // Dibujar el borde
            }

        }

        private void lbControl_Click(object sender, EventArgs e)
        {

        }

        private void lbRegistrarse_Click(object sender, EventArgs e)
        {

        }
    }
}
