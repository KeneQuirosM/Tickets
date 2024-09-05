namespace Way_Fit_Tickets
{
    partial class Usuarios
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
            System.Windows.Forms.Button btnGuardarUsuarios;
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtapellidos = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            btnGuardarUsuarios = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardarUsuarios
            // 
            btnGuardarUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            btnGuardarUsuarios.BackColor = System.Drawing.Color.Goldenrod;
            btnGuardarUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.White;
            btnGuardarUsuarios.FlatAppearance.BorderSize = 2;
            btnGuardarUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            btnGuardarUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            btnGuardarUsuarios.Font = new System.Drawing.Font("Agent Orange", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnGuardarUsuarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnGuardarUsuarios.Location = new System.Drawing.Point(616, 378);
            btnGuardarUsuarios.Name = "btnGuardarUsuarios";
            btnGuardarUsuarios.Size = new System.Drawing.Size(212, 50);
            btnGuardarUsuarios.TabIndex = 3;
            btnGuardarUsuarios.Text = "Guardar";
            btnGuardarUsuarios.UseVisualStyleBackColor = false;
            btnGuardarUsuarios.Click += new System.EventHandler(this.btnGuardarUsuarios_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.txtTel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtapellidos);
            this.panel1.Controls.Add(this.txtnombre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(btnGuardarUsuarios);
            this.panel1.Controls.Add(this.lbltitle);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 636);
            this.panel1.TabIndex = 0;
            // 
            // txtTel
            // 
            this.txtTel.BackColor = System.Drawing.Color.Goldenrod;
            this.txtTel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(282, 145);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(548, 35);
            this.txtTel.TabIndex = 10;
            this.txtTel.TextChanged += new System.EventHandler(this.txtTel_TextChanged_1);
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agent Orange", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(81, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 35);
            this.label3.TabIndex = 9;
            this.label3.Text = "Telefono :";
            // 
            // txtapellidos
            // 
            this.txtapellidos.BackColor = System.Drawing.Color.Goldenrod;
            this.txtapellidos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellidos.Location = new System.Drawing.Point(282, 279);
            this.txtapellidos.Multiline = true;
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(548, 41);
            this.txtapellidos.TabIndex = 8;
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.Goldenrod;
            this.txtnombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(282, 209);
            this.txtnombre.Multiline = true;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(548, 41);
            this.txtnombre.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agent Orange", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(81, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 35);
            this.label2.TabIndex = 6;
            this.label2.Text = "Apellidos :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agent Orange", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(81, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre :";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Agent Orange", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbltitle.Location = new System.Drawing.Point(348, 44);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(205, 49);
            this.lbltitle.TabIndex = 2;
            this.lbltitle.Text = "Clientes";
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(980, 660);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Usuarios";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtapellidos;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label3;
    }
}