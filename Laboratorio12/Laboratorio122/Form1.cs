using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio122
{
    public partial class Laboratorio122 : Form
    {
        public Laboratorio122()
        {
            InitializeComponent();
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BLimpiar_Click(object sender, EventArgs e)
        {
            TSemestre1.Text = " ";
            TSemestre2.Text = " ";
            TSemestre3.Text = " ";
            TPromedioG.Text = " ";
        }

        private void BCalcular_Click(object sender, EventArgs e)
        {
            int semestreuno, semestredos, semestretres, promedio;
            float resultado;

            try 
            {
                semestreuno = int.Parse(TSemestre1.Text);
                semestredos = int.Parse(TSemestre2.Text);
                semestretres = int.Parse(TSemestre3.Text);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"Err type: {ex.GetType().Name}");
                System.Console.WriteLine($"Msg: {ex.Message}");
                return;
            }

            promedio = semestreuno + semestredos + semestretres;

            resultado = promedio / 3;

            TPromedioG.Text = resultado.ToString();

        }

        private void TSemestre1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
