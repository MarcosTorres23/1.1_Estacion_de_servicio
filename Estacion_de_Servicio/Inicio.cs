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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void inicio_secion_Click(object sender, EventArgs e)
        {
            /*Acceder al fomulario principal*/
            Home Home = new Home();
            Home.Show();
        }
    }
}
