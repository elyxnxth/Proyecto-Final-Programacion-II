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
    public partial class ProductoCreate : Form
    {
        private Productos eProductos;
        private ProductosConsulta mProductosConsulta;
        public ProductoCreate()
        {
            InitializeComponent();
            mProductosConsulta = new ProductosConsulta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (descripcion_text.Text == "" || descripcion_text.Text == null || costo_text.Text == "" || costo_text.Text == null || precio_text.Text == "" || precio_text.Text == null || existencia_text.Text == "" || existencia_text.Text == null)
            {
                MessageBox.Show("Los campos no pueden estar en blanco", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                try
                {
                    mProductosConsulta.Add();
                    MessageBox.Show("Se han guardados los datos correctamente", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error inesperado en los datos .\n Detalles del error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
    }


}
         





