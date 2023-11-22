namespace Club_com_B_grupo3.Datos
{
    partial class frmVencimientos
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
            this.grdVencimientos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSinVencimientos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdVencimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // grdVencimientos
            // 
            this.grdVencimientos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdVencimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVencimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.Mail});
            this.grdVencimientos.Location = new System.Drawing.Point(51, 110);
            this.grdVencimientos.Name = "grdVencimientos";
            this.grdVencimientos.RowHeadersWidth = 51;
            this.grdVencimientos.RowTemplate.Height = 24;
            this.grdVencimientos.Size = new System.Drawing.Size(705, 288);
            this.grdVencimientos.TabIndex = 5;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 125;
            // 
            // Mail
            // 
            this.Mail.HeaderText = "Mail";
            this.Mail.MinimumWidth = 400;
            this.Mail.Name = "Mail";
            this.Mail.ReadOnly = true;
            this.Mail.Width = 400;
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.Location = new System.Drawing.Point(584, 52);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(188, 38);
            this.lblDia.TabIndex = 4;
            this.lblDia.Text = "_________";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(29, 52);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(516, 38);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Vencimientos del cuotas del día ";
            // 
            // lblSinVencimientos
            // 
            this.lblSinVencimientos.AutoSize = true;
            this.lblSinVencimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinVencimientos.Location = new System.Drawing.Point(181, 233);
            this.lblSinVencimientos.Name = "lblSinVencimientos";
            this.lblSinVencimientos.Size = new System.Drawing.Size(406, 38);
            this.lblSinVencimientos.TabIndex = 6;
            this.lblSinVencimientos.Text = "No hay vencimientos hoy";
            this.lblSinVencimientos.Visible = false;
            // 
            // frmVencimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSinVencimientos);
            this.Controls.Add(this.grdVencimientos);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmVencimientos";
            this.Text = "Vencimientos de cuotas";
            this.Load += new System.EventHandler(this.frmVencimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdVencimientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdVencimientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSinVencimientos;
    }
}