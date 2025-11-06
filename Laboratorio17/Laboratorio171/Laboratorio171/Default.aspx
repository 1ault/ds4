<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio171._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>

        <div class="row">

        <div>
              <asp:GridView id="MyGridView" DataSourceID="MyDataSource1"
                AllowSorting="True" AllowPaging="True"
                DataKeyNames="ProductID"
                AutoGenerateEditButton="True"
                Runat="Server" />

            
            <asp:SqlDataSource ID="MyDataSource1" runat="server"
                ConnectionString="Data Source=.;Initial Catalog=northwind;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;"
                ProviderName="System.Data.SqlClient"
                SelectCommand="SELECT ProductId, ProductName, UnitPrice FROM Products"
                UpdateCommand="UPDATE Products SET [ProductName]=@ProductName, [UnitPrice]=@UnitPrice WHERE [ProductId]=@ProductId">
            </asp:SqlDataSource>
        </div>

        </div>
    </main>

</asp:Content>
