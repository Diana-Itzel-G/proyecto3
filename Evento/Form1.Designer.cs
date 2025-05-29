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
            this.btnNegar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lbNota = new System.Windows.Forms.Label();
            this.lbCrear = new System.Windows.Forms.Label();
            this.txtCrear = new System.Windows.Forms.TextBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.lbEventos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbdia = new System.Windows.Forms.Label();
            this.lbidevento = new System.Windows.Forms.Label();
            this.txtdia = new System.Windows.Forms.TextBox();
            this.txtidevento = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNegar
            // 
            this.btnNegar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNegar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNegar.Location = new System.Drawing.Point(224, 223);
            this.btnNegar.Name = "btnNegar";
            this.btnNegar.Size = new System.Drawing.Size(74, 23);
            this.btnNegar.TabIndex = 0;
            this.btnNegar.Text = "Cancelar";
            this.btnNegar.UseVisualStyleBackColor = false;
            this.btnNegar.Click += new System.EventHandler(this.btnNegar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAceptar.Location = new System.Drawing.Point(118, 223);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(74, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Guardar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lbNota
            // 
            this.lbNota.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNota.AutoSize = true;
            this.lbNota.Location = new System.Drawing.Point(99, 183);
            this.lbNota.Name = "lbNota";
            this.lbNota.Size = new System.Drawing.Size(41, 13);
            this.lbNota.TabIndex = 3;
            this.lbNota.Text = "Nota(s)";
            // 
            // lbCrear
            // 
            this.lbCrear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCrear.AutoSize = true;
            this.lbCrear.Location = new System.Drawing.Point(99, 157);
            this.lbCrear.Name = "lbCrear";
            this.lbCrear.Size = new System.Drawing.Size(41, 13);
            this.lbCrear.TabIndex = 4;
            this.lbCrear.Text = "Evento";
            this.lbCrear.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCrear
            // 
            this.txtCrear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCrear.Location = new System.Drawing.Point(168, 150);
            this.txtCrear.Name = "txtCrear";
            this.txtCrear.Size = new System.Drawing.Size(115, 20);
            this.txtCrear.TabIndex = 5;
            this.txtCrear.TextChanged += new System.EventHandler(this.txtCrear_TextChanged);
            // 
            // txtNota
            // 
            this.txtNota.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNota.Location = new System.Drawing.Point(168, 176);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(115, 20);
            this.txtNota.TabIndex = 6;
            this.txtNota.TextChanged += new System.EventHandler(this.txtNota_TextChanged);
            // 
            // lbEventos
            // 
            this.lbEventos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbEventos.AutoSize = true;
            this.lbEventos.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEventos.ForeColor = System.Drawing.SystemColors.Control;
            this.lbEventos.Location = new System.Drawing.Point(109, 30);
            this.lbEventos.Name = "lbEventos";
            this.lbEventos.Size = new System.Drawing.Size(215, 27);
            this.lbEventos.TabIndex = 0;
            this.lbEventos.Text = "CREAR EVENTO";
            this.lbEventos.Click += new System.EventHandler(this.lbEventos_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.txtidevento);
            this.panel1.Controls.Add(this.txtdia);
            this.panel1.Controls.Add(this.lbidevento);
            this.panel1.Controls.Add(this.lbdia);
            this.panel1.Controls.Add(this.lbEventos);
            this.panel1.Controls.Add(this.txtNota);
            this.panel1.Controls.Add(this.txtCrear);
            this.panel1.Controls.Add(this.lbCrear);
            this.panel1.Controls.Add(this.lbNota);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.btnNegar);
            this.panel1.Location = new System.Drawing.Point(37, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 291);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // lbdia
            // 
            this.lbdia.AutoSize = true;
            this.lbdia.Location = new System.Drawing.Point(102, 126);
            this.lbdia.Name = "lbdia";
            this.lbdia.Size = new System.Drawing.Size(23, 13);
            this.lbdia.TabIndex = 7;
            this.lbdia.Text = "Dia";
            // 
            // lbidevento
            // 
            this.lbidevento.AutoSize = true;
            this.lbidevento.Location = new System.Drawing.Point(69, 105);
            this.lbidevento.Name = "lbidevento";
            this.lbidevento.Size = new System.Drawing.Size(93, 13);
            this.lbidevento.TabIndex = 8;
            this.lbidevento.Text = "numero de evento";
            // 
            // txtdia
            // 
            this.txtdia.Location = new System.Drawing.Point(168, 124);
            this.txtdia.Name = "txtdia";
            this.txtdia.Size = new System.Drawing.Size(115, 20);
            this.txtdia.TabIndex = 9;
            this.txtdia.TextChanged += new System.EventHandler(this.txtdia_TextChanged);
            // 
            // txtidevento
            // 
            this.txtidevento.Location = new System.Drawing.Point(168, 98);
            this.txtidevento.Name = "txtidevento";
            this.txtidevento.Size = new System.Drawing.Size(115, 20);
            this.txtidevento.TabIndex = 10;
            this.txtidevento.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Eventos1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(459, 315);
            this.Controls.Add(this.panel1);
            this.Name = "Eventos1";
            this.Text = "Evento";
            this.Load += new System.EventHandler(this.Eventos1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNegar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lbNota;
        private System.Windows.Forms.Label lbCrear;
        private System.Windows.Forms.TextBox txtCrear;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label lbEventos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbidevento;
        private System.Windows.Forms.Label lbdia;
        private System.Windows.Forms.TextBox txtidevento;
        private System.Windows.Forms.TextBox txtdia;
    }
}

