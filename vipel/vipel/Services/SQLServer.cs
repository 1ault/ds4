using Microsoft.Ajax.Utilities;
using Microsoft.Data.SqlClient;
using Sprache;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
//using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Management;
using System.Web.Mvc;
using System.Web.Security;
using System.Windows.Forms;
using vipel.Models.WS;
using vipel.Models.WS.Reply;

namespace vipel.Services
{
    public class SQLServer
    {

        public enum EnumHttp
        {
            HttpStatusOK = 200,
            HttpStatusNoContent = 204,
            HttpStatusBadRequest = 400,
            HttpStatusNotFound = 404,
            HttpStatusInternalServerError = 500,
        }

        public enum UserRole : int
        {
            Banned = -2,
            Inactive = -1,
            Applicant = 0,
            Invited = 1,
            User = 2,
            Moderator = 10,
            Admin = 100
        }

        //public  SQLServer() 
        //{

        //}

        //public void Init()
        //{
        //    this.SqlConexion = new SqlConnection(this.SqlConnectionString);
        //    this.SqlConexion.Open();
        //}

        //public void Quit()
        //{
        //    this.SqlConexion.Close();
        //}

        //public void Connect()
        //{
        //    this.SqlConexion = new SqlConnection(this.SqlConnectionString);
        //}

        //public void Open()
        //{
        //    this.SqlConexion.Open();
        //}


        //public void Close()
        //{
        //    this.SqlConexion.Close();
        //}


        //public Boolean Read()
        //{
        //    return this.SqlListar.Read();
        //}

        //public SqlDataReader List()
        //{
        //    return this.SqlListar;
        //}


        //private string command;
        //private SqlCommand SqlConsulta;
        //private SqlConnection SqlConexion;
        //private SqlDataReader SqlListar;
        //private readonly string SqlConnectionString = ConfigurationManager.ConnectionStrings["db.vipel"].ConnectionString;
        public static Reply<string> UserLogin(User user)
        {

            SqlConnection sql_connection = null;
            SqlCommand sql_command = null;
            SqlDataReader sql_data_reader = null;
            User db_user = null;

            try
            {
                sql_connection = new SqlConnection(Env.GetDBConnectionVipel());
                sql_connection.Open();

                //string command = @"
                //SELECT 1 [ID], [Username], [Password], [Email], [Role]
                //FROM [vipel].[dbo].[User]
                //WHERE [Username] = @Username AND [Email] = @Email 
                //";

                //sql_command = new SqlCommand(command, sql_connection);

                //sql_command.Parameters.AddWithValue("@Username", user.Username);
                //sql_command.Parameters.AddWithValue("@Email", user.Email);

                //sql_data_reader = sql_command.ExecuteReader();

                //if (sql_data_reader.Read() == false)
                //{
                //    return new Reply<string>
                //    {
                //        Result = false,
                //        Message = $"Bad request - {SQLServer.EnumHttp.HttpStatusBadRequest}",
                //        Data = "Username or Email are incorrect. Please try again.",
                //    };
                //}

                string command = @"
                SELECT 1 [ID], [Username], [Password], [Email], [Role]
                FROM [vipel].[dbo].[User]
                WHERE [Email] = @Email 
                ";

                sql_command = new SqlCommand(command, sql_connection);

                sql_command.Parameters.AddWithValue("@Email", user.Email);

                sql_data_reader = sql_command.ExecuteReader();

                if (sql_data_reader.Read() == false)
                {
                    return new Reply<string>
                    {
                        Result = false,
                        Message = $"Bad request - {SQLServer.EnumHttp.HttpStatusBadRequest}",
                        Data = "Username or Email are incorrect. Please try again.",
                    };
                }

                db_user = new User
                {
                    ID = $"{sql_data_reader["ID"]}",
                    Username = $"{sql_data_reader["Username"]}",
                    Password = $"{sql_data_reader["Password"]}",
                    Email = $"{sql_data_reader["Email"]}",
                    Role = $"{sql_data_reader["Role"]}"
                };

                if (Hash.PasswordCheck(password: user.Password, password_db: db_user.Password) == false)
                {
                    return new Reply<string>
                    {
                        Result = false,
                        Message = $"Bad request - {SQLServer.EnumHttp.HttpStatusBadRequest}",
                        Data = "password incorrect. Please try again.",
                    };
                }

                string token = JWT.GenerateToken(user: db_user);

                return new Reply<string>
                {
                    Result = true,
                    Message = $"Login successful - {SQLServer.EnumHttp.HttpStatusOK}",
                    Data = token,
                };
            }
            catch (Exception ex)
            {
                return new Reply<string>
                {
                    Result = false,
                    Message = $"Server Error - {SQLServer.EnumHttp.HttpStatusInternalServerError}",
                    Data = $"{ex}",
                };
            }
            finally
            {
                if (sql_data_reader != null)
                {
                    sql_data_reader.Close();
                    sql_data_reader.Dispose();
                }

                if (sql_command != null)
                {
                    sql_command.Dispose();
                }

                if (sql_connection != null)
                {
                    sql_connection.Close();
                    sql_connection.Dispose();
                }
            }

        }


        public static Reply<string> UserInsert(User user)
        {

            SqlConnection sql_connection = null;
            SqlCommand sql_command = null;
            SqlDataReader sql_data_reader = null;

            try
            {

                sql_connection = new SqlConnection(Env.GetDBConnectionVipel());
                sql_connection.Open();
                {
                    // Begin User and email exist ?
                    sql_command = new SqlCommand("[dbo].CheckUserAndMail", sql_connection);
                    sql_command.CommandType = CommandType.StoredProcedure;
                    //sql_command.Parameters.Add("@Username", user.Username);
                    sql_command.Parameters.Add("@Username", SqlDbType.NVarChar, 256).Value = user.Username;
                    sql_command.Parameters.Add("@Email", SqlDbType.NVarChar, 256).Value = user.Email;

                    object result = sql_command.ExecuteScalar();
                    string resultMessage = null;

                    if (result != null)
                        resultMessage = result.ToString();

                    //sql_data_reader = sql_command.ExecuteReader();
                    //bool user_exists = sql_data_reader.Read();

                    //sql_data_reader.Close();
                    //sql_data_reader.Dispose();
                    sql_command.Dispose();


                    if (resultMessage != "OK")
                    {
                        return new Reply<string>
                        {
                            Result = false,
                            Message = $"Bad request - {SQLServer.EnumHttp.HttpStatusBadRequest}",
                            Data = $"{resultMessage}",
                        };
                    }
                    // End User and email exist ?
                }



                {
                    // Begin User insert ?
                    string command = @"
                    INSERT INTO [vipel].[dbo].[user] ([Username], [Password], [Email], [Role])
                    VALUES (@Username, @Password, @Email, @Role)
                    ";

                    sql_command = new SqlCommand(command, sql_connection);

                    sql_command.Parameters.AddWithValue("@Username", user.Username);
                    sql_command.Parameters.AddWithValue("@Password", Hash.PasswordGenerate(user.Password));
                    sql_command.Parameters.AddWithValue("@Email", user.Email);
                    sql_command.Parameters.AddWithValue("@Role", (int)SQLServer.UserRole.Applicant);
                    


                    int row = sql_command.ExecuteNonQuery();
                    sql_command.Dispose();
                    
                    return new Reply<string>
                    {
                        Result = true,
                        Message = $"Registration successful - {SQLServer.EnumHttp.HttpStatusOK}",
                        Data = $"Insert row: {row}",
                    };
                    // End User insert ?
                }
            }
            catch (Exception ex)
            {
                return new Reply<string>
                {
                    Result = false,
                    Message = $"Server Error - {SQLServer.EnumHttp.HttpStatusInternalServerError}",
                    Data = $"{ex}",
                };
            }
            finally
            {
                if (sql_command != null) 
                {
                    sql_command.Dispose();
                }
                
                if (sql_data_reader != null)
                {
                    sql_data_reader.Dispose();
                }

                if (sql_connection != null)
                {
                    sql_connection.Close();
                    sql_connection.Dispose();
                }
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


        //private void SqlConnectionHistorial()
        //{

        //    try
        //    {
        //        this.Connect();

        //        this.Open();

        //        //this.SqlConsulta = new SqlCommand("SELECT [Num1], [Op], [Num2], [Result], [DateCalc] FROM [dbo].[Historial]", this.SqlConexion);

                

        //        //this.Execute();


        //        //this.Select("SELECT [Num1], [Op], [Num2], [Result] FROM [dbo].[Historial]");

        //        //this.lstHistorial.Items.Clear();
        //        ////this.lstHistorial.Items.Add($"Num1, OP, Num2, Result, DateCalc");
        //        //this.lstHistorial.Items.Add($"Num1, OP, Num2, Result");

        //        //while (this.SqlListar.Read())
        //        //{
        //        //    //this.lstHistorial.Items.Add($"{this.SqlListar["Num1"].ToString()}, {this.SqlListar["Op"].ToString()}, {this.SqlListar["Num2"].ToString()}, {this.SqlListar["Result"].ToString()}. {this.SqlListar["DateCalc"].ToString()}");
        //        //    this.lstHistorial.Items.Add($"{this.SqlListar["Num1"].ToString()}, {this.SqlListar["Op"].ToString()}, {this.SqlListar["Num2"].ToString()}, {this.SqlListar["Result"].ToString()}");
        //        //}

        //        this.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"[Err]: conexión sql. {ex}");
        //        return;
        //    }
        //}
    }
}