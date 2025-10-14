using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio12_1
{
    public partial class FLaboratorio121 : Form
    {
        public FLaboratorio121()
        {
            InitializeComponent();
        }

        private void BLimpiar_Click(object sender, EventArgs e)
        {
            TVelocidad.Text = " ";
            TDuracion.Text = " ";
            TDistancia.Text = " ";
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BCalcular_Click(object sender, EventArgs e)
        {
            int velocidad, duracion, distancia;

            try
            {
                velocidad = int.Parse(TVelocidad.Text);
                duracion = int.Parse(TDuracion.Text);
            }
            catch (Exception ex)
            {

                System.Console.WriteLine($"Err type: {ex.GetType().Name}");
                System.Console.WriteLine($"Msg: {ex.Message}");
                return;
            }


            distancia = velocidad * duracion;

            TDistancia.Text = distancia.ToString();
        }

        private void FLaboratorio121_Load(object sender, EventArgs e)
        {

        }
    }
    
    

    }
 
