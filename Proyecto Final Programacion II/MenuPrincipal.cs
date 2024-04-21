using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Programacion_II
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void verclientes_Click(object sender, EventArgs e)
        {
            ClienteIndex Formulario = new ClienteIndex();
            Formulario.Show();
        }

        private void versuplidores_Click(object sender, EventArgs e)
        {
            SuplidorIndex Formulario = new SuplidorIndex();
            Formulario.Show();
        }

        private void verproductos_Click(object sender, EventArgs e)
        {
            ProductoIndex Formulario = new ProductoIndex();
            Formulario.Show();
        }
    }
}
