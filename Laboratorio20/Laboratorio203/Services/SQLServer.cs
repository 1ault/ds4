using Laboratorio203.Models.WS.Laptops;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace Laboratorio203.Services.SQLServer
{
    public class SQLServer
    {
        private SqlCommand SqlConsulta;
        private SqlConnection SqlConexion;
        private SqlDataReader SqlListar;

        private readonly string SqlConnectionString = @"Data Source = .; Initial Catalog = Productos; Integrated Security = True; Encrypt = False;TrustServerCertificate = True";

        public SQLServer() 
        {
            this.SqlConexion = new SqlConnection(this.SqlConnectionString);
            this.SqlConexion.Open();
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


        public void DBProductosLaptopInsert(Laptops laptops)
        {
            string sql = @"
            INSERT INTO 
            laptops (nombre, precio, stock)
            VALUES (@Nombre, @Precio, @Stock)
            ";

            this.SqlConsulta = new SqlCommand(sql, this.SqlConexion);

            this.SqlConsulta.Parameters.AddWithValue("@Nombre", laptops.nombre);
            this.SqlConsulta.Parameters.AddWithValue("@Precio", laptops.precio);
            this.SqlConsulta.Parameters.AddWithValue("@Stock", laptops.stock);

            this.Execute();
        }

        public void DBProductosLaptopUpdate(Laptops laptops)
        {
            string sql = @"
            UPDATE laptops 
            SET 
                nombre = @Nombre,
                precio = @Precio,
                stock = @Stock
            WHERE id = @id
            ";
            this.SqlConsulta = new SqlCommand(sql, this.SqlConexion);

            this.SqlConsulta.Parameters.AddWithValue("@id", laptops.id);
            this.SqlConsulta.Parameters.AddWithValue("@Nombre", laptops.nombre);
            this.SqlConsulta.Parameters.AddWithValue("@Precio", laptops.precio);
            this.SqlConsulta.Parameters.AddWithValue("@Stock", laptops.stock);

            this.Execute();
        }


        public void DBProductosLaptopSelect()
        {
            try
            {
                string command = "SELECT [id], [nombre], [precio], [stock] FROM [Productos].[dbo].[Laptops]";
                this.SqlConsulta = new SqlCommand(command, this.SqlConexion);
                this.Execute();
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"[Err]: conexión sql. {ex}");
                return;
            }
        }

        public void DBProductosLaptopIdSelect(int id)
        {

            string sql = @"
            SELECT 
                [id], 
                [nombre], 
                [precio], 
                [stock]
            FROM 
                [Productos].[dbo].[Laptops] 
            WHERE 
                [id] = @id
            ";

            this.SqlConsulta = new SqlCommand(sql, this.SqlConexion);

            this.SqlConsulta.Parameters.AddWithValue("@id", id);

            this.Execute();
        }


        public void DBProductosLaptopIdDelete(Laptops laptop)
        {

            string sql = @"
            DELETE
            FROM 
                [Productos].[dbo].[Laptops] 
            WHERE 
                [id] = @id
            ";

            this.SqlConsulta = new SqlCommand(sql, this.SqlConexion);

            this.SqlConsulta.Parameters.AddWithValue("@id", laptop.id);

            this.Execute();
        }
    }
}