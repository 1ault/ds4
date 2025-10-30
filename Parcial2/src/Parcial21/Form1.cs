using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;

namespace Parcial21
{
    public partial class Form1 : Form
    {

        SqlDataReader SqlListar;
        SqlCommand SqlConsulta;
        SqlConnection SqlConexion;

        string SqlConnectionString = @"Data Source = .; Initial Catalog = historial; Integrated Security = True; Encrypt=False; TrustServerCertificate=True";

        public Form1()
        {
        // 1 Metro = 1.0936133 Yardas
            InitializeComponent();
            this.button1.Text = "->";
            this.button2.Text = "->";

            this.textBox4.Enabled = false;
            this.textBox3.Enabled = false;

            this.label1.Text = "Yardas a metros";
            this.label2.Text = "Metros a yardas";


            try
            {
                this.SqlConexion = new SqlConnection(this.SqlConnectionString);
                this.SqlConexion.Open();

                this.SqlConsulta = new SqlCommand("SELECT [typo], [original], [calc] FROM historial_data", this.SqlConexion);

                this.SqlListar = this.SqlConsulta.ExecuteReader();

                this.listBox1.Items.Clear();
                this.listBox1.Items.Add($"Typo, Original, Calc");

                while (this.SqlListar.Read())
                {
                    this.listBox1.Items.Add($"{this.SqlListar["typo"].ToString()}, {this.SqlListar["original"].ToString()}, {this.SqlListar["calc"].ToString()}");
                }

                this.SqlConexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"[Err]: conexión sql {ex}");
                return;
            }
        }

        private void restart_list()
        {
            try
            {
                this.SqlConexion = new SqlConnection(this.SqlConnectionString);
                this.SqlConexion.Open();

                this.SqlConsulta = new SqlCommand("SELECT [typo], [original], [calc] FROM historial_data", this.SqlConexion);

                this.SqlListar = this.SqlConsulta.ExecuteReader();

                this.listBox1.Items.Clear();
                this.listBox1.Items.Add($"Typo, Original, Calc");

                while (this.SqlListar.Read())
                {
                    this.listBox1.Items.Add($"{this.SqlListar["typo"].ToString()}, {this.SqlListar["original"].ToString()}, {this.SqlListar["calc"].ToString()}");
                }

                this.SqlConexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"[Err]: conexión sql {ex}");
                return;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        double parse_double = 0;
        double result = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            // 1 Metro = 1.0936133 Yardas
            // Yardas a metros
            string text_box1 = this.textBox1.Text;
            try
            {
                this.parse_double = double.Parse(text_box1);
            }
            catch (Exception ex)
            {
                return;
            }

            int i = 0;
            while (true)
            {
                if (i > this.parse_double) { break; }

                this.result = this.parse_double - 0.0936133;
                this.textBox3.Text = $"{this.result}";

                i = i + 1;
            }

            try
            {
                this.SqlConexion = new SqlConnection(this.SqlConnectionString);
                this.SqlConexion.Open();

                string SqlQuery = $"INSERT INTO historial_data (typo, original, calc) VALUES('Yardas -> Metros', {this.parse_double}, {this.result})";
                this.SqlConsulta = new SqlCommand(SqlQuery, this.SqlConexion);
                this.SqlConsulta.CommandType = CommandType.Text;
                this.SqlConsulta.ExecuteNonQuery();
                this.SqlConexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"[Err]: insert sql. {ex}");
                return;
            }

            this.parse_double = 0;
            this.result = 0;
            this.restart_list();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Yardas a metros
            string text_box = this.textBox2.Text;
            try
            {
                this.parse_double = double.Parse(text_box);
            }
            catch (Exception ex)
            {
                return;
            }

            int i = 0;
            while (true)
            {
                if (i > this.parse_double) { break; }

                this.result = this.parse_double + 0.0936133;
                this.textBox4.Text = $"{this.result}";

                i = i + 1;
            }


            try
            {
                this.SqlConexion = new SqlConnection(this.SqlConnectionString);
                this.SqlConexion.Open();

                string SqlQuery = $"INSERT INTO historial_data (typo, original, calc) VALUES('Metros -> Yardas', {this.parse_double}, {this.result})";
                this.SqlConsulta = new SqlCommand(SqlQuery, this.SqlConexion);
                this.SqlConsulta.CommandType = CommandType.Text;
                this.SqlConsulta.ExecuteNonQuery();
                this.SqlConexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"[Err]: insert sql. {ex}");
                return;
            }


            this.parse_double = 0;
            this.result = 0;
            this.restart_list();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
