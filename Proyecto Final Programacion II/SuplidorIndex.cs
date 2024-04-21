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
    public partial class SuplidorIndex : Form
    {
        private SuplidoresConsulta mSuplidoresConsulta; 

        public SuplidorIndex()
        {
            mSuplidoresConsulta = new SuplidoresConsulta(); 
            InitializeComponent();
            Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SuplidorCreate Formulario = new SuplidorCreate();
            Formulario.Show();
        }

        private void Refresh()
        {
            dataGridView1.DataSource = mSuplidoresConsulta.Get();
        }
    }
}
