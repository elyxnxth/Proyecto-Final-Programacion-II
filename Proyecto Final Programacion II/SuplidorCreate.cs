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
    public partial class SuplidorCreate : Form
    {
        private Suplidores eSuplidores;
        private SuplidoresConsulta mSuplidoresConsulta;
        public SuplidorCreate()
        {
            InitializeComponent();
            mSuplidoresConsulta = new SuplidoresConsulta();
        }

        private void guardar_btn_Click(object sender, EventArgs e)
        {

            if (nombre_text.Text == "" || nombre_text.Text == null || direccion_text.Text == "" || direccion_text.Text == null || telefono_text.Text == "" || telefono_text.Text == null)
            {
                MessageBox.Show("Los campos no pueden estar en blanco", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
              
                
                    try
                    {
                        mSuplidoresConsulta.Add();
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

