
using Parcial31.Models.WS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Web;

namespace Parcial31.Services
{
    public class SQLServer
    {
        private SqlCommand SqlConsulta;
        private SqlConnection SqlConexion;
        private SqlDataReader SqlListar;

        //private readonly string SqlConnectionString = @"Data Source = .; Initial Catalog = whitney; Integrated Security = True; Encrypt = False;TrustServerCertificate = True";


        static public Reply<User> UserLogin(User user)
        {
            string SqlConnectionString = @"Data Source = .; Initial Catalog = whitney; Integrated Security = True; Encrypt = False;TrustServerCertificate = True";
            SqlConnection sql_connection = null;
            SqlCommand sql_command = null;
            SqlDataReader sql_data_reader = null;
            User db_user = null;

            try
            {
                sql_connection = new SqlConnection(SqlConnectionString);
                sql_connection.Open();


                string command = @"
                SELECT 1 [ID], [Username], [Password], [Role]
                FROM [whitney].[dbo].[wa_User]
                WHERE [Username] = @Username AND [Password] = @Password
                ";

                sql_command = new SqlCommand(command, sql_connection);

                sql_command.Parameters.AddWithValue("@Username", user.Username);
                sql_command.Parameters.AddWithValue("@Password", user.Password);
                

                sql_data_reader = sql_command.ExecuteReader();

                if (sql_data_reader.Read() == false)
                {
                    return new Reply<User>
                    {
                        Result = false,
                        Message = $"",
                        Data = new User
                        {
                            ID = $"",
                            Username = $"",
                            Password = $"",
                            Role = $""
                        }
                    };
                }

                db_user = new User
                {
                    ID = $"{sql_data_reader["ID"]}",
                    Username = $"{sql_data_reader["Username"]}",
                    Password = $"{sql_data_reader["Password"]}",
                    Role = $"{sql_data_reader["Role"]}"
                };


                return new Reply<User>
                {
                    Result = true,
                    Message = "",
                    Data = db_user,
                };
            }
            catch (Exception ex)
            {
                return new Reply<User>
                {
                    Result = false,
                    Message = $"",
                    Data = new User
                    {
                        ID = $"",
                        Username = $"",
                        Password = $"",
                        Role = $""
                    }
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



        public void Execute()
        {

            if (this.SqlConexion.State != ConnectionState.Open)
            {
                this.SqlConexion.Open();
            }

            this.SqlListar = this.SqlConsulta.ExecuteReader();
        }

        public void Quit()
        {
            this.SqlConexion.Close();
        }

        public Boolean ListRead()
        {
            return this.SqlListar.Read();
        }

        public SqlDataReader ListData()
        {
            return this.SqlListar;
        }


    }
}