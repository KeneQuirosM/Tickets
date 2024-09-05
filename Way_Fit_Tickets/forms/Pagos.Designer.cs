namespace Way_Fit_Tickets
{
    partial class Pagos
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
            System.Windows.Forms.Button btnPagar;
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblcambio = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmonto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbServicios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            btnPagar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPagar
            // 
            btnPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            btnPagar.BackColor = System.Drawing.Color.Goldenrod;
            btnPagar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            btnPagar.FlatAppearance.BorderSize = 2;
            btnPagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            btnPagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            btnPagar.Font = new System.Drawing.Font("Agent Orange", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnPagar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnPagar.Location = new System.Drawing.Point(573, 450);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new System.Drawing.Size(212, 50);
            btnPagar.TabIndex = 18;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(btnPagar);
            this.panel1.Controls.Add(this.lblcambio);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtmonto);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbServicios);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbClientes);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbltitle);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 636);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblcambio
            // 
            this.lblcambio.AutoSize = true;
            this.lblcambio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcambio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblcambio.Location = new System.Drawing.Point(317, 343);
            this.lblcambio.Name = "lblcambio";
            this.lblcambio.Size = new System.Drawing.Size(0, 28);
            this.lblcambio.TabIndex = 17;
            this.lblcambio.Click += new System.EventHandler(this.lblcambio_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agent Orange", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(140, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 35);
            this.label4.TabIndex = 16;
            this.label4.Text = "Cambio :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtmonto
            // 
            this.txtmonto.BackColor = System.Drawing.Color.Goldenrod;
            this.txtmonto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmonto.Location = new System.Drawing.Point(322, 269);
            this.txtmonto.Multiline = true;
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.Size = new System.Drawing.Size(463, 41);
            this.txtmonto.TabIndex = 15;
            this.txtmonto.TextChanged += new System.EventHandler(this.txtmonto_TextChanged);
            this.txtmonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmonto_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agent Orange", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(140, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 35);
            this.label2.TabIndex = 14;
            this.label2.Text = "Monto :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbServicios
            // 
            this.cmbServicios.BackColor = System.Drawing.Color.Goldenrod;
            this.cmbServicios.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbServicios.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbServicios.FormattingEnabled = true;
            this.cmbServicios.Location = new System.Drawing.Point(322, 203);
            this.cmbServicios.Name = "cmbServicios";
            this.cmbServicios.Size = new System.Drawing.Size(463, 36);
            this.cmbServicios.TabIndex = 13;
            this.cmbServicios.SelectedIndexChanged += new System.EventHandler(this.cmbServicios_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agent Orange", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(140, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 35);
            this.label1.TabIndex = 12;
            this.label1.Text = "Servicio :";
            // 
            // cmbClientes
            // 
            this.cmbClientes.BackColor = System.Drawing.Color.Goldenrod;
            this.cmbClientes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClientes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(322, 141);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(463, 36);
            this.cmbClientes.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agent Orange", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(140, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 35);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cliente :";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Agent Orange", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbltitle.Location = new System.Drawing.Point(408, 35);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(159, 49);
            this.lbltitle.TabIndex = 2;
            this.lbltitle.Text = "Pagos";
            // 
            // Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(980, 660);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Usuarios";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbServicios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmonto;
        private System.Windows.Forms.Label lblcambio;
    }
}