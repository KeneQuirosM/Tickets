using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Way_Fit_Tickets.clases;

namespace Way_Fit_Tickets
{
    public partial class Servicios : Form
    {
        BD_Movements add = new BD_Movements();

        public Servicios()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnGuardarUsuarios_Click(object sender, EventArgs e)
        {
            string servicio, precio;
            bool ok= false;

            servicio = txtservicio.Text;
            precio = txtprecio.Text;


            if (servicio.ToString().Length > 0 && precio.ToString().Length > 0)
            {

                ok = add.Save_Services(servicio,precio);

                if (ok == true)
                {
                    MessageBox.Show("El servicio se ha guardado con exito");
                    txtprecio.Text = "";
                    txtservicio.Text = "";
                }
                else
                {
                    MessageBox.Show("Error al guardar el registro!");
                }
            }
            else
            {
                MessageBox.Show("No puede tener ningún campo en blanco, por favor asegurarse de ingresar Servicio y Precio");
            }
        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("El campo intereses solo permite numeros, favor intente de nuevo");

            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
