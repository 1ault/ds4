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
using System.Data.SqlClient;

namespace Laboratorio13
{
    public partial class Laboratorio13 : Form
    {

        string connectionString = @"Data Source =.; Initial Catalog = Northwind; Integrated Security = True; Encrypt=False;TrustServerCertificate=True";
        
    

        public Laboratorio13()
        {
            InitializeComponent();
        }

        private void Conexion_Click(object sender, EventArgs e)
        {
            SqlDataReader listar;
            SqlCommand consulta;
            SqlConnection conexion;
            try
            {
                conexion = new SqlConnection(connectionString);
                conexion.Open();
                MessageBox.Show("Se abrió la conexión con el servidor SQL Server y se seleccionó la base de datos");

                consulta = new SqlCommand("select ProductName from [dbo].[Products]", conexion);
                listar = consulta.ExecuteReader();

                ListProductos.Items.Clear();
                while (listar.Read())
                {
                    ListProductos.Items.Add(listar["ProductName"].ToString());

                }

                conexion.Close();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"Err type: {ex.GetType().Name}");
                System.Console.WriteLine($"Msg: {ex.Message}");
                return;
            }


            MessageBox.Show("Se cerró la conexión.");
        }
    }
}
