using Microsoft.Ajax.Utilities;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using Newtonsoft.Json;
using Sprache;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
//using System.Data.SqlClient;
using System.Drawing;


//using System.Data;
//using System.Data.SqlClient;

//using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
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





        public static Reply<string> AdminSetRole(User user)
        {
            SqlConnection sql_connection = null;
            SqlCommand sql_command = null;
            SqlDataReader sql_data_reader = null;
            //User db_user = null;

            try
            {
                sql_connection = new SqlConnection(Env.GetDBConnectionVipel());
                sql_command = new SqlCommand("[dbo].[AlterUserRol]", sql_connection);
                sql_command.CommandType = CommandType.StoredProcedure;

                sql_command.Parameters.Add("@ID", SqlDbType.Int).Value = user.ID;
                sql_command.Parameters.Add("@Username", SqlDbType.VarChar, 256).Value = user.Username;
                sql_command.Parameters.Add("@Email", SqlDbType.VarChar, 256).Value = user.Email;
                //sql_command.Parameters.Add("@Role", SqlDbType.Int).Value = user.Role;
                sql_command.Parameters.Add("@UpdateRole", SqlDbType.Int).Value = user.Role;

                sql_connection.Open();

                string resultMessage = (string)sql_command.ExecuteScalar();

                return new Reply<string>
                {
                    Result = true,
                    Message = $"Ok",
                    Data = resultMessage,
                };
            }
            catch (SqlException ex)
            {
                System.Diagnostics.Debug.WriteLine($"SQL ERROR {ex.Number}: {ex.Message}");
                return new Reply<string>
                {
                    Result = false,
                    Message = $"Server error. Please try again later.",
                    Data = $"Server Error - {SQLServer.EnumHttp.HttpStatusInternalServerError}",
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

        public static async Task<int> PageCreate()
        {
            SqlConnection sql_connection = null;
            SqlCommand sql_command = null;

            try
            {
                sql_connection = new SqlConnection(Env.GetDBConnectionVipel());
                await sql_connection.OpenAsync();

                sql_command = new SqlCommand("[dbo].[PageCreate]", sql_connection);
                sql_command.CommandType = CommandType.StoredProcedure;

                var obj = await sql_command.ExecuteScalarAsync();
                return Convert.ToInt32(obj);
            }
            finally
            {
                if (sql_command != null) sql_command.Dispose();
                if (sql_connection != null) sql_connection.Dispose();
            }
        }


        public static async Task<Reply<string>> UserInsertPost(int pageId, PagePayload payload)
        {
            SqlConnection sql_connection = null;
            SqlCommand sql_command = null;
            SqlDataReader sql_data_reader = null;
            SqlTransaction sql_transaction = null;

            try
            {
                sql_connection = new SqlConnection(Env.GetDBConnectionVipel());
                //sql_connection.Open();
                await sql_connection.OpenAsync();

                sql_transaction = sql_connection.BeginTransaction();

                foreach (var mod in payload.Modules)
                {
                    System.Diagnostics.Debug.WriteLine(
                        JsonConvert.SerializeObject(mod, Formatting.Indented)
                    );
                    int moduleTypeId = mod.IdType;
                    //int moduleTypeId = mod.ModuleTypeID;
                    int moduleOrder = mod.Order;
                    string moduleJson = JsonConvert.SerializeObject(mod);

                    var response = await CallUserInsertPost(sql_connection, sql_transaction, pageId, moduleTypeId, moduleOrder, moduleJson);
                    if (!response.ok)
                    {
                        sql_transaction.Rollback();
                        return new Reply<string> { Result = false, Message = response.message, Data = null };
                    }
                }

                sql_transaction.Commit();
                return new Reply<string> { Result = true, Message = "Inserted modules", Data = pageId.ToString() };
            }
            catch (Exception ex)
            {
                if (sql_transaction != null) { try { sql_transaction.Rollback(); } catch { } }
                return new Reply<string> { Result = false, Message = ex.Message, Data = null };
            }
            finally
            {
                if (sql_data_reader != null) { sql_data_reader.Close(); }

                if (sql_command != null) { sql_command.Dispose(); }

                if (sql_connection != null) { sql_connection.Close(); }

                if (sql_transaction != null) sql_transaction.Dispose();
            }
        }


        private static async Task<(bool ok, string message)> CallUserInsertPost(
        SqlConnection sql_connection, 
        SqlTransaction sql_transaction,
        int pageId, 
        int moduleTypeId, 
        int moduleOrder, 
        string moduleJson)
        {
            SqlCommand sql_command = null;
            SqlDataReader sql_data_reader = null;

            try
            {
                sql_command = new SqlCommand("[dbo].[UserInsertPost]", sql_connection, sql_transaction);
                sql_command.CommandType = CommandType.StoredProcedure;

                sql_command.Parameters.Add("@PageID", SqlDbType.Int).Value = pageId;
                sql_command.Parameters.Add("@ModuleTypeID", SqlDbType.Int).Value = moduleTypeId;
                sql_command.Parameters.Add("@ModuleOrder", SqlDbType.Int).Value = moduleOrder;
                sql_command.Parameters.Add("@ModuleJson", SqlDbType.NVarChar).Value = moduleJson;

                sql_data_reader = await sql_command.ExecuteReaderAsync();

                if (await sql_data_reader.ReadAsync())
                {
                    var msg = (sql_data_reader["Message"] ?? "").ToString();
                    var ok = !msg.StartsWith("Insertion failed", StringComparison.OrdinalIgnoreCase);
                    return (ok, msg);
                }

                return (false, "Stored procedure returned no rows");
            }
            finally
            {
                if (sql_data_reader != null) sql_data_reader.Dispose();
                if (sql_command != null) sql_command.Dispose();
            }
        }

        public static Reply<List<object>> UserGetPostID(int id)
        {
            SqlConnection sql_connection = null;
            SqlCommand sql_command = null;
            SqlDataReader sql_data_reader = null;
            User db_user = null;

            List<object> list = new List<object>();

            try
            {
                sql_connection = new SqlConnection(Env.GetDBConnectionVipel());
                sql_connection.Open();

                sql_command = new SqlCommand("[dbo].[UserGetPostId]", sql_connection);
                sql_command.CommandType = CommandType.StoredProcedure;

                sql_command.Parameters.AddWithValue("@ID", id);

                sql_data_reader = sql_command.ExecuteReader();


                while (sql_data_reader.Read())
                {
                    object item = new
                    {
                        PageID = sql_data_reader.GetInt32(sql_data_reader.GetOrdinal("PageID")),
                        ModuleID = sql_data_reader.GetInt32(sql_data_reader.GetOrdinal("ModuleID")),
                        ModuleTypeID = sql_data_reader.GetInt32(sql_data_reader.GetOrdinal("ModuleTypeID")),
                        ModuleOrder = sql_data_reader.GetInt32(sql_data_reader.GetOrdinal("ModuleOrder")),
                        ModuleJson = sql_data_reader.GetString(sql_data_reader.GetOrdinal("ModuleJson"))
                    };

                    list.Add(item);
                }


                return new Reply<List<object>>
                {
                    Result = true,
                    Message = $"Post Ok ID",
                    Data = list,
                };

            }
            catch (Exception ex)
            {
                return new Reply<List<object>>
                {
                    Result = false,
                    Message = $"Server error. Please try again later.",
                    Data = new List<object>(),
                };
            }
            finally
            {
                if (sql_data_reader != null) { sql_data_reader.Close(); }

                if (sql_command != null) { sql_command.Dispose(); }

                if (sql_connection != null) { sql_connection.Close(); sql_connection.Dispose(); }
            }
        }

        public static Reply<List<object>> UserGetPost()
        {
            SqlConnection sql_connection = null;
            SqlCommand sql_command = null;
            SqlDataReader sql_data_reader = null;
            User db_user = null;

            List<object> list = new List<object>();

            try
            {
                sql_connection = new SqlConnection(Env.GetDBConnectionVipel());
                sql_connection.Open();

                sql_command = new SqlCommand("[dbo].[UserGetPost]", sql_connection);
                sql_command.CommandType = CommandType.StoredProcedure;


                sql_data_reader = sql_command.ExecuteReader();


                while (sql_data_reader.Read())
                {
                    object item = new
                    {
                        PageID = sql_data_reader.GetInt32(sql_data_reader.GetOrdinal("PageID")),
                        ModuleID = sql_data_reader.GetInt32(sql_data_reader.GetOrdinal("ModuleID")),
                        ModuleTypeID = sql_data_reader.GetInt32(sql_data_reader.GetOrdinal("ModuleTypeID")),
                        ModuleOrder = sql_data_reader.GetInt32(sql_data_reader.GetOrdinal("ModuleOrder")),
                        ModuleJson = sql_data_reader.GetString(sql_data_reader.GetOrdinal("ModuleJson"))
                    };

                    list.Add(item);
                }


                return new Reply<List<object>>
                {
                    Result = true,
                    Message = $"Post Ok",
                    Data = list,
                };

            }
            catch (Exception ex)
            {
                return new Reply<List<object>>
                {
                    Result = false,
                    Message = $"Server error. Please try again later.",
                    Data = new List<object>(),
                };
            }
            finally
            {
                if (sql_data_reader != null) { sql_data_reader.Close(); }

                if (sql_command != null) { sql_command.Dispose(); }

                if (sql_connection != null) { sql_connection.Close(); sql_connection.Dispose(); }
            }
        }

        public static Reply<List<User>> AdminGetUser()
        {

            SqlConnection sql_connection = null;
            SqlCommand sql_command = null;
            SqlDataReader sql_data_reader = null;
            List<User> list_user = new List<User>();
            try
            {
                string command = @"
                SELECT [ID], [Username], [Email], [Role]
                FROM [vipel].[dbo].[User]
                ";
                
                sql_connection = new SqlConnection(Env.GetDBConnectionVipel());
                sql_connection.Open();

                sql_command = new SqlCommand(command, sql_connection);

                sql_data_reader = sql_command.ExecuteReader();

                while (sql_data_reader.Read())
                {
                    //this.lstHistorial.Items.Add($"{this.SqlListar["Num1"].ToString()}, {this.SqlListar["Op"].ToString()}, {this.SqlListar["Num2"].ToString()}, {this.SqlListar["Result"].ToString()}. {this.SqlListar["DateCalc"].ToString()}");

                    list_user.Add(
                        new User
                        {
                            ID = sql_data_reader["ID"].ToString(),
                            Email = sql_data_reader["Email"].ToString(),
                            Username = sql_data_reader["Username"].ToString(),
                            Role = sql_data_reader["Role"].ToString(),
                        });                  
                }

                return new Reply<List<User>>
                {
                    Result = false,
                    Message = $"Ok",
                    Data = list_user,
                };
            }
            catch (Exception ex)
            {
                return new Reply<List<User>>
                {
                    Result = false,
                    Message = $"Server error. Please try again later.",
                    Data = new List<User>(),
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
                        //Message = $"Bad request - {SQLServer.EnumHttp.HttpStatusBadRequest}",
                        Message = $"Username or Email are incorrect. Please try again.",
                        Data = "Bad request - {SQLServer.EnumHttp.HttpStatusBadRequest}",
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
                        Message = $"password incorrect. Please try again.",
                        Data = "Bad request - {SQLServer.EnumHttp.HttpStatusBadRequest}",
                    };
                }

                string token = JWT.GenerateToken(user: db_user);

                return new Reply<string>
                {
                    Result = true,
                    Message = $"Login successful",
                    Data = token,
                };
            }
            catch (Exception ex)
            {
                return new Reply<string>
                {
                    Result = false,
                    Message = $"Server error. Please try again later.",
                    Data = $"Server Error - {SQLServer.EnumHttp.HttpStatusInternalServerError}",
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

                    string command0 = @"SELECT COUNT(*) FROM [vipel].[dbo].[user]";

                    sql_command = new SqlCommand(command0, sql_connection);
                    int totalTableUser = (int)sql_command.ExecuteScalar();


                    string command = @"
                    INSERT INTO [vipel].[dbo].[user] ([Username], [Password], [Email], [Role])
                    VALUES (@Username, @Password, @Email, @Role)
                    ";

                    sql_command = new SqlCommand(command, sql_connection);

                    sql_command.Parameters.AddWithValue("@Username", user.Username);
                    sql_command.Parameters.AddWithValue("@Password", Hash.PasswordGenerate(user.Password));
                    sql_command.Parameters.AddWithValue("@Email", user.Email);

                    if (totalTableUser == 0)
                    {
                        sql_command.Parameters.AddWithValue("@Role", (int)SQLServer.UserRole.Admin);
                    } else
                    {
                        sql_command.Parameters.AddWithValue("@Role", (int)SQLServer.UserRole.Applicant);
                    }
                    


                    int row = sql_command.ExecuteNonQuery();
                    sql_command.Dispose();
                    
                    return new Reply<string>
                    {
                        Result = true,
                        Message = $"Registration successful - {SQLServer.EnumHttp.HttpStatusOK}",
                        Data = $"Registration successful.",
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