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
    public partial class Usuarios : Form
    {
        BD_Movements add = new BD_Movements();
        
        public Usuarios()
        {
            InitializeComponent();
           
        }

        private void btnGuardarUsuarios_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre, apellidos, telefono;
                bool ok = false;


                nombre = txtnombre.Text;
                apellidos = txtapellidos.Text;
                telefono = txtTel.Text;

                if (nombre != null && apellidos != null && telefono != null)
                {
                    ok = add.Save_Users(nombre, apellidos, telefono);
                    if (ok == true)
                    {
                        MessageBox.Show("Cliente ingresado con éxito");
                        txtnombre.Text = "";
                        txtapellidos.Text = "";
                        txtTel.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Error al ingresar el cliente");
                    }
                }
                else
                {
                    MessageBox.Show("No puede tener ningún campo en blanco, por favor asegurarse de ingresar nombre,apellidos y telefono");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error...");
            }
            
        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {
           
           
        }

        private void txtTel_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTel_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                string tel;

                tel = txtTel.Text;
                if (tel.ToString().Length > 0)
                {
                    DataSet search_users = new DataSet();
                    search_users = add.Search_Users(tel);

                    if (search_users.Tables[0].Rows.Count > 0)
                    {

                        txtnombre.Text = search_users.Tables[0].Rows[0][1].ToString();
                        txtapellidos.Text = search_users.Tables[0].Rows[0][2].ToString();
                    }
                    else
                    {
                        txtnombre.Text = "";
                        txtapellidos.Text = "";
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error...");
            }
           
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("El campo telefono solo permite numeros, favor intente de nuevo");

            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
