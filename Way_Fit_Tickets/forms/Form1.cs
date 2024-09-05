using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Way_Fit_Tickets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void PantallaOK()
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void wrapper_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_load(object sender, EventArgs e)
        {
            //PantallaOK(); 
        }

        private void Salir(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Seguro que deseas salir del sistema ?", "Notificacion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

        }


        private Form FormularioActivo = null;
        private void AbrirPanelHijo(Form formhijo)
        {
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            FormularioActivo = formhijo;
            formhijo.TopLevel = false;
            formhijo.FormBorderStyle = FormBorderStyle.None;
            formhijo.Dock = DockStyle.Fill;
            wrapper.Controls.Add(formhijo);
            wrapper.Tag = formhijo;
            formhijo.BringToFront();
            formhijo.Show();
        }


        private void bntServicios_Click_1(object sender, EventArgs e)
        {
            AbrirPanelHijo(new Servicios());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirPanelHijo(new Usuarios());
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            AbrirPanelHijo(new Historial());
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            AbrirPanelHijo(new Pagos());
        }
    }
}
