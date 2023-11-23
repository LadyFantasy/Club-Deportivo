namespace Club_com_B_grupo3
{
    partial class frmCarnet
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
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarnet));
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblSocioNro = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblClub = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(100, 150);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(150, 208);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(0, 20);
            this.lblNumero.TabIndex = 13;
            // 
            // lblSocioNro
            // 
            this.lblSocioNro.AutoSize = true;
            this.lblSocioNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocioNro.Location = new System.Drawing.Point(68, 208);
            this.lblSocioNro.Name = "lblSocioNro";
            this.lblSocioNro.Size = new System.Drawing.Size(85, 20);
            this.lblSocioNro.TabIndex = 12;
            this.lblSocioNro.Text = "Socio N°: ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(362, 141);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(68, 188);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(260, 20);
            this.lblNombre.TabIndex = 10;
            // 
            // lblClub
            // 
            this.lblClub.AutoSize = true;
            this.lblClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClub.Location = new System.Drawing.Point(131, 78);
            this.lblClub.Name = "lblClub";
            this.lblClub.Size = new System.Drawing.Size(361, 29);
            this.lblClub.TabIndex = 8;
            this.lblClub.Text = "CLUB DEPORTIVO DE EMMA";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(417, 12);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 14;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // frmCarnet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(516, 272);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblSocioNro);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.lblClub);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmCarnet";
            this.Text = "frmCarnet";
            this.Load += new System.EventHandler(this.frmCarnet_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblSocioNro;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblClub;
        private System.Windows.Forms.Button btnImprimir;
    }
}