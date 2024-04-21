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
    public partial class ClienteIndex : Form
    {
        private ClientesConsulta mClientesConsulta;

        public ClienteIndex()
        {
            mClientesConsulta = new ClientesConsulta();
            InitializeComponent();
            Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClienteCreate Formulario = new ClienteCreate();
            Formulario.Show();
        }
        private void Refresh()
        {
            dataGridView1.DataSource = mClientesConsulta.Get();
        }

    }
}
