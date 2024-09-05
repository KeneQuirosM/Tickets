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
    public partial class Historial : Form
    {
        public Historial()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Historial_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'wayF_TicketsDataSet.Table_Record' Puede moverla o quitarla según sea necesario.
            this.table_RecordTableAdapter.Fill(this.wayF_TicketsDataSet.Table_Record);
        

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
