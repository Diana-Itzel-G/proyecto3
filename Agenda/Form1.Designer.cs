namespace Agenda
{
    partial class FechaAct
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
            this.pnCalendario = new System.Windows.Forms.Panel();
            this.Calendario = new System.Windows.Forms.MonthCalendar();
            this.cbHoy = new System.Windows.Forms.ComboBox();
            this.cbMañana = new System.Windows.Forms.ComboBox();
            this.cbVacaciones = new System.Windows.Forms.ComboBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnCalendario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnCalendario
            // 
            this.pnCalendario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnCalendario.BackColor = System.Drawing.SystemColors.GrayText;
            this.pnCalendario.Controls.Add(this.Calendario);
            this.pnCalendario.Location = new System.Drawing.Point(241, 94);
            this.pnCalendario.Name = "pnCalendario";
            this.pnCalendario.Size = new System.Drawing.Size(428, 258);
            this.pnCalendario.TabIndex = 0;
            // 
            // Calendario
            // 
            this.Calendario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Calendario.Location = new System.Drawing.Point(86, 51);
            this.Calendario.Name = "Calendario";
            this.Calendario.TabIndex = 0;
            this.Calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendario_DateChanged);
            // 
            // cbHoy
            // 
            this.cbHoy.FormattingEnabled = true;
            this.cbHoy.Location = new System.Drawing.Point(53, 145);
            this.cbHoy.Name = "cbHoy";
            this.cbHoy.Size = new System.Drawing.Size(121, 21);
            this.cbHoy.TabIndex = 1;
            this.cbHoy.Text = "Hoy";
            // 
            // cbMañana
            // 
            this.cbMañana.FormattingEnabled = true;
            this.cbMañana.Location = new System.Drawing.Point(53, 198);
            this.cbMañana.Name = "cbMañana";
            this.cbMañana.Size = new System.Drawing.Size(121, 21);
            this.cbMañana.TabIndex = 2;
            this.cbMañana.Text = "Mañana";
            // 
            // cbVacaciones
            // 
            this.cbVacaciones.FormattingEnabled = true;
            this.cbVacaciones.Location = new System.Drawing.Point(53, 249);
            this.cbVacaciones.Name = "cbVacaciones";
            this.cbVacaciones.Size = new System.Drawing.Size(121, 21);
            this.cbVacaciones.TabIndex = 3;
            this.cbVacaciones.Text = "Vacaciones";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Location = new System.Drawing.Point(690, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(98, 23);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar Sesion";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // FechaAct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.cbVacaciones);
            this.Controls.Add(this.cbMañana);
            this.Controls.Add(this.cbHoy);
            this.Controls.Add(this.pnCalendario);
            this.Name = "FechaAct";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.Agenda_Load);
            this.pnCalendario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnCalendario;
        private System.Windows.Forms.MonthCalendar Calendario;
        private System.Windows.Forms.ComboBox cbHoy;
        private System.Windows.Forms.ComboBox cbMañana;
        private System.Windows.Forms.ComboBox cbVacaciones;
        private System.Windows.Forms.Button btnCerrar;
    }
}

