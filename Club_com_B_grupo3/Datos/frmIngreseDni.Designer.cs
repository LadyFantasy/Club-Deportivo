namespace Club_com_B_grupo3.Datos
{
    partial class frmIngreseDni
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnIngresarSocio = new System.Windows.Forms.Button();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnIngresarNoSocio = new System.Windows.Forms.Button();
            this.txtActividad = new System.Windows.Forms.TextBox();
            this.lblActividad = new System.Windows.Forms.Label();
            this.cboDatos = new System.Windows.Forms.Panel();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.cboPago = new System.Windows.Forms.GroupBox();
            this.cboCuotas = new System.Windows.Forms.GroupBox();
            this.rbt6 = new System.Windows.Forms.RadioButton();
            this.rbt3 = new System.Windows.Forms.RadioButton();
            this.rbt1 = new System.Windows.Forms.RadioButton();
            this.rbtEfectivo = new System.Windows.Forms.RadioButton();
            this.rbtTarjeta = new System.Windows.Forms.RadioButton();
            this.cboDatos.SuspendLayout();
            this.cboPago.SuspendLayout();
            this.cboCuotas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCancelar.Font = new System.Drawing.Font("Papyrus", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(436, 379);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(170, 49);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnIngresarSocio
            // 
            this.btnIngresarSocio.BackColor = System.Drawing.Color.Lime;
            this.btnIngresarSocio.Font = new System.Drawing.Font("Papyrus", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarSocio.Location = new System.Drawing.Point(212, 379);
            this.btnIngresarSocio.Margin = new System.Windows.Forms.Padding(0);
            this.btnIngresarSocio.Name = "btnIngresarSocio";
            this.btnIngresarSocio.Size = new System.Drawing.Size(170, 49);
            this.btnIngresarSocio.TabIndex = 10;
            this.btnIngresarSocio.Text = "Ingresar";
            this.btnIngresarSocio.UseVisualStyleBackColor = false;
            this.btnIngresarSocio.Visible = false;
            this.btnIngresarSocio.Click += new System.EventHandler(this.btnIngresarSocio_Click);
            // 
            // txtDni
            // 
            this.txtDni.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtDni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDni.Font = new System.Drawing.Font("Perpetua", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(164, 18);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(207, 31);
            this.txtDni.TabIndex = 9;
            this.txtDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Papyrus", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(10, 12);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(92, 44);
            this.lblDni.TabIndex = 8;
            this.lblDni.Text = "DNI:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Papyrus", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(161, 70);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(0, 64);
            this.lblTitulo.TabIndex = 7;
            // 
            // btnIngresarNoSocio
            // 
            this.btnIngresarNoSocio.BackColor = System.Drawing.Color.Lime;
            this.btnIngresarNoSocio.Font = new System.Drawing.Font("Papyrus", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarNoSocio.Location = new System.Drawing.Point(212, 379);
            this.btnIngresarNoSocio.Margin = new System.Windows.Forms.Padding(0);
            this.btnIngresarNoSocio.Name = "btnIngresarNoSocio";
            this.btnIngresarNoSocio.Size = new System.Drawing.Size(170, 49);
            this.btnIngresarNoSocio.TabIndex = 12;
            this.btnIngresarNoSocio.Text = "Ingresar";
            this.btnIngresarNoSocio.UseVisualStyleBackColor = false;
            this.btnIngresarNoSocio.Visible = false;
            this.btnIngresarNoSocio.Click += new System.EventHandler(this.btnIngresarNoSocio_Click);
            // 
            // txtActividad
            // 
            this.txtActividad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtActividad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtActividad.Font = new System.Drawing.Font("Perpetua", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActividad.Location = new System.Drawing.Point(164, 86);
            this.txtActividad.Name = "txtActividad";
            this.txtActividad.Size = new System.Drawing.Size(207, 31);
            this.txtActividad.TabIndex = 14;
            this.txtActividad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtActividad.Visible = false;
            this.txtActividad.WordWrap = false;
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Font = new System.Drawing.Font("Papyrus", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActividad.Location = new System.Drawing.Point(10, 80);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(152, 44);
            this.lblActividad.TabIndex = 13;
            this.lblActividad.Text = "Actividad:";
            this.lblActividad.Visible = false;
            // 
            // cboDatos
            // 
            this.cboDatos.Controls.Add(this.txtValor);
            this.cboDatos.Controls.Add(this.lblValor);
            this.cboDatos.Controls.Add(this.lblDni);
            this.cboDatos.Controls.Add(this.txtActividad);
            this.cboDatos.Controls.Add(this.txtDni);
            this.cboDatos.Controls.Add(this.lblActividad);
            this.cboDatos.Location = new System.Drawing.Point(64, 129);
            this.cboDatos.Name = "cboDatos";
            this.cboDatos.Size = new System.Drawing.Size(443, 182);
            this.cboDatos.TabIndex = 15;
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValor.Font = new System.Drawing.Font("Perpetua", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(164, 144);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(207, 31);
            this.txtValor.TabIndex = 16;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValor.Visible = false;
            this.txtValor.WordWrap = false;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Papyrus", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(10, 138);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(98, 44);
            this.lblValor.TabIndex = 15;
            this.lblValor.Text = "Valor:";
            this.lblValor.Visible = false;
            // 
            // cboPago
            // 
            this.cboPago.Controls.Add(this.cboCuotas);
            this.cboPago.Controls.Add(this.rbtEfectivo);
            this.cboPago.Controls.Add(this.rbtTarjeta);
            this.cboPago.Font = new System.Drawing.Font("Papyrus", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPago.Location = new System.Drawing.Point(545, 129);
            this.cboPago.Name = "cboPago";
            this.cboPago.Size = new System.Drawing.Size(180, 105);
            this.cboPago.TabIndex = 18;
            this.cboPago.TabStop = false;
            this.cboPago.Text = "Forma de pago";
            // 
            // cboCuotas
            // 
            this.cboCuotas.Controls.Add(this.rbt6);
            this.cboCuotas.Controls.Add(this.rbt3);
            this.cboCuotas.Controls.Add(this.rbt1);
            this.cboCuotas.Font = new System.Drawing.Font("Papyrus", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCuotas.Location = new System.Drawing.Point(22, 103);
            this.cboCuotas.Name = "cboCuotas";
            this.cboCuotas.Size = new System.Drawing.Size(155, 66);
            this.cboCuotas.TabIndex = 19;
            this.cboCuotas.TabStop = false;
            this.cboCuotas.Text = "Cuotas";
            this.cboCuotas.Visible = false;
            // 
            // rbt6
            // 
            this.rbt6.AutoSize = true;
            this.rbt6.Font = new System.Drawing.Font("Papyrus", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt6.Location = new System.Drawing.Point(106, 29);
            this.rbt6.Name = "rbt6";
            this.rbt6.Size = new System.Drawing.Size(44, 31);
            this.rbt6.TabIndex = 20;
            this.rbt6.TabStop = true;
            this.rbt6.Text = "6";
            this.rbt6.UseVisualStyleBackColor = true;
            // 
            // rbt3
            // 
            this.rbt3.AutoSize = true;
            this.rbt3.Font = new System.Drawing.Font("Papyrus", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt3.Location = new System.Drawing.Point(56, 29);
            this.rbt3.Name = "rbt3";
            this.rbt3.Size = new System.Drawing.Size(44, 31);
            this.rbt3.TabIndex = 19;
            this.rbt3.TabStop = true;
            this.rbt3.Text = "3";
            this.rbt3.UseVisualStyleBackColor = true;
            // 
            // rbt1
            // 
            this.rbt1.AutoSize = true;
            this.rbt1.Checked = true;
            this.rbt1.Font = new System.Drawing.Font("Papyrus", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt1.Location = new System.Drawing.Point(6, 29);
            this.rbt1.Name = "rbt1";
            this.rbt1.Size = new System.Drawing.Size(44, 31);
            this.rbt1.TabIndex = 18;
            this.rbt1.TabStop = true;
            this.rbt1.Text = "1";
            this.rbt1.UseVisualStyleBackColor = true;
            // 
            // rbtEfectivo
            // 
            this.rbtEfectivo.AutoSize = true;
            this.rbtEfectivo.Checked = true;
            this.rbtEfectivo.Font = new System.Drawing.Font("Papyrus", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtEfectivo.Location = new System.Drawing.Point(6, 29);
            this.rbtEfectivo.Name = "rbtEfectivo";
            this.rbtEfectivo.Size = new System.Drawing.Size(105, 31);
            this.rbtEfectivo.TabIndex = 16;
            this.rbtEfectivo.TabStop = true;
            this.rbtEfectivo.Text = "Efectivo";
            this.rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbtTarjeta
            // 
            this.rbtTarjeta.AutoSize = true;
            this.rbtTarjeta.Font = new System.Drawing.Font("Papyrus", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtTarjeta.Location = new System.Drawing.Point(6, 66);
            this.rbtTarjeta.Name = "rbtTarjeta";
            this.rbtTarjeta.Size = new System.Drawing.Size(97, 31);
            this.rbtTarjeta.TabIndex = 17;
            this.rbtTarjeta.Text = "Tarjeta";
            this.rbtTarjeta.UseVisualStyleBackColor = true;
            this.rbtTarjeta.CheckedChanged += new System.EventHandler(this.rbtTarjeta_CheckedChanged);
            // 
            // frmIngreseDni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboPago);
            this.Controls.Add(this.cboDatos);
            this.Controls.Add(this.btnIngresarNoSocio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIngresarSocio);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmIngreseDni";
            this.Text = "Ingrese Dni";
            this.Load += new System.EventHandler(this.frmIngreseDni_Load);
            this.cboDatos.ResumeLayout(false);
            this.cboDatos.PerformLayout();
            this.cboPago.ResumeLayout(false);
            this.cboPago.PerformLayout();
            this.cboCuotas.ResumeLayout(false);
            this.cboCuotas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnIngresarSocio;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnIngresarNoSocio;
        private System.Windows.Forms.TextBox txtActividad;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.Panel cboDatos;
        private System.Windows.Forms.GroupBox cboPago;
        private System.Windows.Forms.GroupBox cboCuotas;
        private System.Windows.Forms.RadioButton rbt6;
        private System.Windows.Forms.RadioButton rbt3;
        private System.Windows.Forms.RadioButton rbt1;
        private System.Windows.Forms.RadioButton rbtEfectivo;
        private System.Windows.Forms.RadioButton rbtTarjeta;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
    }
}