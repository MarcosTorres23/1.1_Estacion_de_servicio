using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacion_de_Servicio
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table_stock.Visible = !table_stock.Visible;

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void agregaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pedirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productos_Click(object sender, EventArgs e)
        {
            table_prodcuctos.Visible = !table_prodcuctos.Visible;
        }

        private void nuevaCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void table_prodcuctos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
