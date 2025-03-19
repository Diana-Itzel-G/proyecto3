namespace Evento
{
    partial class Eventos1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.txtCrear = new System.Windows.Forms.TextBox();
            this.lbCrear = new System.Windows.Forms.Label();
            this.lbNota = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbEventos = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnNegar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.txtNota);
            this.panel1.Controls.Add(this.txtCrear);
            this.panel1.Controls.Add(this.lbCrear);
            this.panel1.Controls.Add(this.lbNota);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.btnNegar);
            this.panel1.Location = new System.Drawing.Point(120, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 287);
            this.panel1.TabIndex = 0;
            // 
            // txtNota
            // 
            this.txtNota.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNota.Location = new System.Drawing.Point(208, 162);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(160, 20);
            this.txtNota.TabIndex = 6;
            this.txtNota.TextChanged += new System.EventHandler(this.txtNota_TextChanged);
            // 
            // txtCrear
            // 
            this.txtCrear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCrear.Location = new System.Drawing.Point(208, 118);
            this.txtCrear.Name = "txtCrear";
            this.txtCrear.Size = new System.Drawing.Size(160, 20);
            this.txtCrear.TabIndex = 5;
            this.txtCrear.TextChanged += new System.EventHandler(this.txtCrear_TextChanged);
            // 
            // lbCrear
            // 
            this.lbCrear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCrear.AutoSize = true;
            this.lbCrear.Location = new System.Drawing.Point(139, 126);
            this.lbCrear.Name = "lbCrear";
            this.lbCrear.Size = new System.Drawing.Size(41, 13);
            this.lbCrear.TabIndex = 4;
            this.lbCrear.Text = "Evento";
            this.lbCrear.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbNota
            // 
            this.lbNota.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNota.AutoSize = true;
            this.lbNota.Location = new System.Drawing.Point(139, 165);
            this.lbNota.Name = "lbNota";
            this.lbNota.Size = new System.Drawing.Size(41, 13);
            this.lbNota.TabIndex = 3;
            this.lbNota.Text = "Nota(s)";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.lbEventos);
            this.panel2.Location = new System.Drawing.Point(188, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 42);
            this.panel2.TabIndex = 2;
            // 
            // lbEventos
            // 
            this.lbEventos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbEventos.AutoSize = true;
            this.lbEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEventos.ForeColor = System.Drawing.SystemColors.Control;
            this.lbEventos.Location = new System.Drawing.Point(45, 11);
            this.lbEventos.Name = "lbEventos";
            this.lbEventos.Size = new System.Drawing.Size(102, 20);
            this.lbEventos.TabIndex = 0;
            this.lbEventos.Text = "Crear Evento";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAceptar.Location = new System.Drawing.Point(326, 244);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Guardar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnNegar
            // 
            this.btnNegar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNegar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNegar.Location = new System.Drawing.Point(432, 244);
            this.btnNegar.Name = "btnNegar";
            this.btnNegar.Size = new System.Drawing.Size(75, 23);
            this.btnNegar.TabIndex = 0;
            this.btnNegar.Text = "Cancelar";
            this.btnNegar.UseVisualStyleBackColor = false;
            this.btnNegar.Click += new System.EventHandler(this.btnNegar_Click);
            // 
            // Eventos1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Eventos1";
            this.Text = "Evento";
            this.Load += new System.EventHandler(this.Eventos1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.TextBox txtCrear;
        private System.Windows.Forms.Label lbCrear;
        private System.Windows.Forms.Label lbNota;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbEventos;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnNegar;
    }
}

