using CrearTicketVenta;
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
    public partial class Pagos : Form
    {
        BD_Movements MovBD = new BD_Movements();
        Printer ticket = new Printer();

        public string id, precio1;
        public int precio;
        public Pagos()
        {
            InitializeComponent();

            DataTable dt = new DataTable();
            dt = MovBD.ViewClientes();

            cmbClientes.DisplayMember = "Name";
            cmbClientes.ValueMember = "Id_User";
            cmbClientes.DataSource = dt;

            DataTable da = new DataTable();
            da = MovBD.ViewServices();

            cmbServicios.DisplayMember = "Name";
            cmbServicios.ValueMember = "Id_Services";
            cmbServicios.DataSource = da;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtmonto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string monto, vuelto;
                int montopagar;
                monto = txtmonto.Text;

                if (monto.ToString().Length > 0)
                {
                    montopagar = Convert.ToInt32(monto);
                    vuelto = Convert.ToString(montopagar - precio);
                    lblcambio.Text = vuelto.ToString();
                }
            }
            catch (Exception)
            {
                
                MessageBox.Show("Error...");
            }
            

        }

        private void cmbServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtmonto.Text = "";
                lblcambio.Text = "";
                id = cmbServicios.SelectedValue.ToString();

                if (id.Length != 0)
                {
                    DataSet prices = new DataSet();
                    prices = MovBD.Search_Price(id.ToString());

                    if (prices.Tables[0].Rows.Count > 0)
                    {
                        precio1 = prices.Tables[0].Rows[0][0].ToString();
                    }
                }
                precio = Convert.ToInt32(precio1);
            }
            catch (Exception)
            {
                
               MessageBox.Show("Error...");
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblcambio_Click(object sender, EventArgs e)
        {

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {

            try
            {
                string info, nombre, apellidos, tel, serv, nomserv, precioserv, montopaga, vuelto;
                string id,services;
                bool ok = false;
                string[] Cliente;
                string[] Servicio;
                char delimitador = ' ';

                
                info = cmbClientes.Text;
                serv = cmbServicios.Text;

                Cliente = info.Split(delimitador);
                Servicio = serv.Split(delimitador);

                nombre = Cliente[0];
                apellidos = Cliente[1] + " " + Cliente[2];
                tel = Cliente[3];


                nomserv = Servicio[0];
                precioserv = Convert.ToString(precio);
                montopaga = txtmonto.Text;
                vuelto = lblcambio.Text;

                if (nombre.ToString().Length > 0 && apellidos.ToString().Length > 0 && tel.ToString().Length > 0 && vuelto.ToString().Length > 0 && montopaga.ToString().Length > 0)
                {
                    id = cmbClientes.SelectedValue.ToString();
                    services = cmbServicios.SelectedValue.ToString();
                    ok = MovBD.Insert_Rercord(id, services);

                    if (ok == true)
                    {
                        //Creamos una instancia d ela clase CrearTicket

                        //Ya podemos usar todos sus metodos
                        ticket.AbreCajon();//Para abrir el cajon de dinero.

                        //Datos de la cabecera del Ticket.
                        ticket.TextoCentro("WAY FITNESS");
                        ticket.TextoIzquierda("Telefono: +506 84416936");
                        ticket.TextoIzquierda("Birrisito-Cartago");
                        ticket.TextoIzquierda("Fecha: " + DateTime.Now.ToShortDateString() + "_" + "Hora: " +DateTime.Now.ToShortTimeString());
                        ticket.lineasAsteriscos();

                        //Sub cabecera.
                        ticket.TextoIzquierda("");
                        ticket.TextoIzquierda("Cliente :" + nombre);
                        ticket.TextoIzquierda("Motivo: Pago al contado de la   sesion de " + nomserv);
                        ticket.TextoIzquierda("");
                        ticket.lineasAsteriscos();

                        ticket.lineasAsteriscos();
                        ticket.TextoIzquierda("Costo del servicio :" + precioserv);
                        ticket.TextoIzquierda("Monto pagado :" + montopaga);
                        ticket.TextoIzquierda("Vuelto :" + vuelto);
                        ticket.lineasAsteriscos();

                        //Texto final del Ticket.
                        ticket.TextoIzquierda("");
                        ticket.TextoCentro("Gracias por su preferencia...");
                        ticket.CortaTicket();
                        ticket.ImprimirTicket("POS-58-Series");//Nombre de la impresora ticketera

                        MessageBox.Show("El ticket de pago se ha registrado con exito");

                    }
                    else
                    {
                        MessageBox.Show("Error al realizar el pago");
                    }
                }
                else
                {
                    MessageBox.Show("Error se necesitan todos los campos para realizar el pago");
                }



            }
            catch (Exception)
            {
                MessageBox.Show("Error...");
            }
            
        }

        private void txtmonto_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("El campo monto solo permite numeros, favor intente de nuevo");

            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

    }
}
