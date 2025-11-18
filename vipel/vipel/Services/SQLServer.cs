using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace vipel.Services.SQLServer
{
    public class SQLServer
    {
        private SqlCommand SqlConsulta;
        private SqlConnection SqlConexion;
        private SqlDataReader SqlListar;

        private readonly string SqlConnectionString = @"Data Source = .; Initial Catalog = Calc; Integrated Security = True; Encrypt = False;TrustServerCertificate = True";

        public SQLServer() 
        {
            this.SqlConexion = new SqlConnection(this.SqlConnectionString);
            this.SqlConexion.Open();
        }

        public void Init()
        {
            this.SqlConexion = new SqlConnection(this.SqlConnectionString);
            this.SqlConexion.Open();
        }

        public void Quit()
        {
            this.SqlConexion.Close();
        }

        public void Connect()
        {
            this.SqlConexion = new SqlConnection(this.SqlConnectionString);
        }

        public void Open()
        {
            this.SqlConexion.Open();
        }


        public void Close()
        {
            this.SqlConexion.Close();
        }

        public void Select(string command)
        {
            this.SqlConsulta = new SqlCommand(command, this.SqlConexion);
        }

        public void Execute()
        {
            this.SqlListar = this.SqlConsulta.ExecuteReader();
        }

        public Boolean Read()
        {
            return this.SqlListar.Read();
        }

        public SqlDataReader List()
        {
            return this.SqlListar;
        }



        public void SelectCalcHistorial()
        {
            try
            {
                this.Select("SELECT [id], [Num1], [Op], [Num2], [Result] FROM [Calc].[dbo].[Historial]");
                this.SqlListar = this.SqlConsulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"[Err]: conexión sql. {ex}");
                return;
            }
        }

        private void SqlConnectionHistorial()
        {

            try
            {
                this.Connect();

                this.Open();

                //this.SqlConsulta = new SqlCommand("SELECT [Num1], [Op], [Num2], [Result], [DateCalc] FROM [dbo].[Historial]", this.SqlConexion);

                

                this.Execute();


                //this.Select("SELECT [Num1], [Op], [Num2], [Result] FROM [dbo].[Historial]");

                //this.lstHistorial.Items.Clear();
                ////this.lstHistorial.Items.Add($"Num1, OP, Num2, Result, DateCalc");
                //this.lstHistorial.Items.Add($"Num1, OP, Num2, Result");

                //while (this.SqlListar.Read())
                //{
                //    //this.lstHistorial.Items.Add($"{this.SqlListar["Num1"].ToString()}, {this.SqlListar["Op"].ToString()}, {this.SqlListar["Num2"].ToString()}, {this.SqlListar["Result"].ToString()}. {this.SqlListar["DateCalc"].ToString()}");
                //    this.lstHistorial.Items.Add($"{this.SqlListar["Num1"].ToString()}, {this.SqlListar["Op"].ToString()}, {this.SqlListar["Num2"].ToString()}, {this.SqlListar["Result"].ToString()}");
                //}

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"[Err]: conexión sql. {ex}");
                return;
            }
        }
    }
}