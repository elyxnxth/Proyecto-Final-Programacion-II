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
    public partial class ProductoIndex : Form
    {
        private ProductosConsulta mProductosConsulta;

        public ProductoIndex()
        {
            mProductosConsulta = new ProductosConsulta();
            InitializeComponent();
            Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProductoCreate Formulario = new ProductoCreate();
            Formulario.Show();
        }
        private void Refresh()
        {
            dataGridView1.DataSource = mProductosConsulta.Get();
        }
    }
}
