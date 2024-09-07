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
            /*Acceder al fomulario compras*/
            Stock Stock = new Stock();
            Stock.Show();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void productos_Click(object sender, EventArgs e)
        {
            /*Acceder al fomulario compras*/
            Productos Productos = new Productos();
            Productos.Show();
        }


        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Acceder al fomulario compras*/
            Compras Compras = new Compras();
            Compras.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Acceder al fomulario Clientes*/
            Clientes Clientes = new Clientes();
            Clientes.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Acceder al fomulario empleados*/
            Empleados Empleados = new Empleados();
            Empleados.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Acceder al fomulario ventas*/
            Ventas Ventas = new Ventas();
            Ventas.Show();
        }

        private void proveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /*Acceder al fomulario proveedores*/
            Proveedores Proveedores = new Proveedores();
            Proveedores.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
