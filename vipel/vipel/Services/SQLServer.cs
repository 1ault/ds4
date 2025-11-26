using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows.Forms;
using vipel.Models.WS;
using vipel.Models.WS.Reply;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace vipel.Services
{
    public class SQLServer
    {
        private int HttpStatusOK = 200;
        private int HttpStatusNoContent = 204;
        private int HttpStatusBadRequest = 400;
        private int HttpStatusNotFound = 404;
        private int HttpStatusInternalServerError = 500;

        private string command;
        private SqlCommand SqlConsulta;
        private SqlConnection SqlConexion;
        private SqlDataReader SqlListar;

        private readonly string SqlConnectionString = @"Data Source = .; Initial Catalog = Calc; Integrated Security = True; Encrypt = False;TrustServerCertificate = True";

        public  SQLServer() 
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

        public static Reply<string> UserInsert(User user)
        {
            if (string.IsNullOrWhiteSpace(user.Username) || string.IsNullOrWhiteSpace(user.Password))
            {
                return new Reply<string>
                {
                    Result = false,
                    Message = $"Bad request - {this.HttpStatusBadRequest}",
                    Data = "Username and password are required. Please try again.",
                };
            }

            try
            {
                using (SqlConnection conn =)
                        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();

            using (SqlCommand cmd1 = new SqlCommand(sql1, conn))
                cmd1.ExecuteNonQuery();

            using (SqlCommand cmd2 = new SqlCommand(sql2, conn))
                cmd2.ExecuteNonQuery();
        }
                this.command = @"
                SELECT TOP 1 [Username]
                FROM [Vipel].[dbo].[user]
                WHERE Username = @Username";

                this.SqlConsulta = new SqlCommand(this.command, this.SqlConexion);

                this.SqlConsulta.Parameters.AddWithValue("@Username", user.Username);

                this.Execute();

                this.Quit();

                if (this.Read() == false)
                {
                    return new Reply<string>
                    {
                        Result = false,
                        Message = $"Bad request - {this.HttpStatusBadRequest}",
                        Data = "Username already exists.",
                    };
                }
            }
            catch (Exception ex)
            {
                return new Reply<string>
                {
                    Result = false,
                    Message = "Server Error - {this.HttpStatusInternalServerError}",
                    Data = $"{ex}",
                };
            }


            try
            {
                this.command = @"
                INSERT INTO 
                [Vipel].[dbo].[user] ([Username], [Password], [Email], [Role])
                VALUES (@Username, @Password, @Email, @Role)
                ";

                this.SqlConsulta = new SqlCommand(this.command, this.SqlConexion);

                this.SqlConsulta.Parameters.AddWithValue("@Username", user.Username);
                this.SqlConsulta.Parameters.AddWithValue("@Password", user.Password);
                this.SqlConsulta.Parameters.AddWithValue("@Email", user.Email);
                this.SqlConsulta.Parameters.AddWithValue("@Role", user.Role);

                this.Execute();

                this.Quit();

                return new Reply<string>
                {
                    Result = true,
                    Message = "Registration successful - {this.HttpStatusOK}",
                    Data = $"",
                };
            }
            catch (Exception ex)
            {
                return new Reply<string>
                {
                    Result = false,
                    Message = "Server Error - {this.HttpStatusInternalServerError}",
                    Data = $"{ex}",
                };
            }
        }


        //public void SelectCalcHistorial()
        //{
        //    try
        //    {
        //        this.Select("SELECT [id], [Num1], [Op], [Num2], [Result] FROM [Calc].[dbo].[Historial]");
        //        this.SqlListar = this.SqlConsulta.ExecuteReader();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"[Err]: conexión sql. {ex}");
        //        return;
        //    }
        //}


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