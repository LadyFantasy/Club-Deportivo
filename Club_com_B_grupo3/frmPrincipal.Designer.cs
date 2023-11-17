namespace Club_com_B_grupo3
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnRegistrarSocio = new System.Windows.Forms.Button();
            this.btnRegistNoSocio = new System.Windows.Forms.Button();
            this.btnListarVencimientos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCobrarActividad = new System.Windows.Forms.Button();
            this.btnCobrarCuota = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Papyrus", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(45, 50);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(707, 64);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Sistema de administración Omeguitas";
            // 
            // btnRegistrarSocio
            // 
            this.btnRegistrarSocio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRegistrarSocio.Font = new System.Drawing.Font("Papyrus", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarSocio.Location = new System.Drawing.Point(47, 168);
            this.btnRegistrarSocio.Margin = new System.Windows.Forms.Padding(0);
            this.btnRegistrarSocio.Name = "btnRegistrarSocio";
            this.btnRegistrarSocio.Size = new System.Drawing.Size(338, 55);
            this.btnRegistrarSocio.TabIndex = 1;
            this.btnRegistrarSocio.Text = "Registrar nuevo socio";
            this.btnRegistrarSocio.UseVisualStyleBackColor = false;
            this.btnRegistrarSocio.Click += new System.EventHandler(this.btnRegistrarSocio_Click);
            // 
            // btnRegistNoSocio
            // 
            this.btnRegistNoSocio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRegistNoSocio.Font = new System.Drawing.Font("Papyrus", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistNoSocio.Location = new System.Drawing.Point(47, 233);
            this.btnRegistNoSocio.Margin = new System.Windows.Forms.Padding(0);
            this.btnRegistNoSocio.Name = "btnRegistNoSocio";
            this.btnRegistNoSocio.Size = new System.Drawing.Size(338, 55);
            this.btnRegistNoSocio.TabIndex = 2;
            this.btnRegistNoSocio.Text = "Registrar nuevo no socio";
            this.btnRegistNoSocio.UseVisualStyleBackColor = false;
            // 
            // btnListarVencimientos
            // 
            this.btnListarVencimientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnListarVencimientos.Font = new System.Drawing.Font("Papyrus", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarVencimientos.Location = new System.Drawing.Point(47, 300);
            this.btnListarVencimientos.Margin = new System.Windows.Forms.Padding(0);
            this.btnListarVencimientos.Name = "btnListarVencimientos";
            this.btnListarVencimientos.Size = new System.Drawing.Size(338, 55);
            this.btnListarVencimientos.TabIndex = 3;
            this.btnListarVencimientos.Text = "Vencimientos";
            this.btnListarVencimientos.UseVisualStyleBackColor = false;
            this.btnListarVencimientos.Click += new System.EventHandler(this.btnListarVencimientos_Click);
            // 
            // btnCobrarCuota
            // 
            this.btnCobrarCuota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCobrarCuota.Font = new System.Drawing.Font("Papyrus", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrarCuota.Location = new System.Drawing.Point(414, 168);
            this.btnCobrarCuota.Margin = new System.Windows.Forms.Padding(0);
            this.btnCobrarCuota.Name = "btnCobrarCuota";
            this.btnCobrarCuota.Size = new System.Drawing.Size(338, 55);
            this.btnCobrarCuota.TabIndex = 4;
            this.btnCobrarCuota.Text = "Cobrar cuota socio";
            this.btnCobrarCuota.UseVisualStyleBackColor = false;
            // 
            // btnCobrarActividad
            // 
            this.btnCobrarActividad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCobrarActividad.Font = new System.Drawing.Font("Papyrus", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrarActividad.Location = new System.Drawing.Point(414, 233);
            this.btnCobrarActividad.Margin = new System.Windows.Forms.Padding(0);
            this.btnCobrarActividad.Name = "btnCobrarActividad";
            this.btnCobrarActividad.Size = new System.Drawing.Size(338, 55);
            this.btnCobrarActividad.TabIndex = 5;
            this.btnCobrarActividad.Text = "Cobrar actividad no socio";
            this.btnCobrarActividad.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Font = new System.Drawing.Font("Papyrus", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(414, 300);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(338, 55);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 433);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCobrarActividad);
            this.Controls.Add(this.btnCobrarCuota);
            this.Controls.Add(this.btnListarVencimientos);
            this.Controls.Add(this.btnRegistNoSocio);
            this.Controls.Add(this.btnRegistrarSocio);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnRegistrarSocio;
        private System.Windows.Forms.Button btnRegistNoSocio;
        private System.Windows.Forms.Button btnListarVencimientos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCobrarActividad;
        private System.Windows.Forms.Button btnCobrarCuota;
    }
}