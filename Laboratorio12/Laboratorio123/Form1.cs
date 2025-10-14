using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace Laboratorio_12_3
{
    public partial class Laboratorio123 : Form
    {
        public Laboratorio123()
        {
            InitializeComponent();
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BLimpiar_Click(object sender, EventArgs e)
        {
            TLadoA.Text = "";
            TLadoB.Text = "";
            TLadoC.Text = "";
            TSemiperimetro.Text = "";
            TArea.Text = "";

        }

        private void BCSPerimetro_Click(object sender, EventArgs e)
        {
            int ladouno, ladodos, ladotres, semiperimetro;
            float resultado;

            try
            {
                ladouno = int.Parse(TLadoA.Text);
                ladodos = int.Parse(TLadoB.Text);
                ladotres = int.Parse(TLadoC.Text);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"Err type: {ex.GetType().Name}");
                System.Console.WriteLine($"Msg: {ex.Message}");
                return;
            }



            semiperimetro = ladouno + ladodos + ladotres;

            resultado = semiperimetro / 2;

            TSemiperimetro.Text = resultado.ToString();



        }

        private void BCArea_Click(object sender, EventArgs e)
        {

            int ladouno, ladodos, ladotres, semiperimetro;
            float s;

            float suno,sdos,stres,sld,slr;
            double resultado;


            try
            {
                ladouno = int.Parse(TLadoA.Text);
                ladodos = int.Parse(TLadoB.Text);
                ladotres = int.Parse(TLadoC.Text);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"Err type: {ex.GetType().Name}");
                System.Console.WriteLine($"Msg: {ex.Message}");
                return;
            }


            semiperimetro = ladouno + ladodos + ladotres;

            s = semiperimetro / 2;

            suno = s - ladouno;
            sdos = s - ladodos;
            stres= s - ladotres;

            sld = suno * sdos * stres;

            slr = sld * s;

            resultado = Math.Sqrt(slr);

            TArea.Text = resultado.ToString();

        }

        private void Laboratorio123_Load(object sender, EventArgs e)
        {

        }
    }
}
