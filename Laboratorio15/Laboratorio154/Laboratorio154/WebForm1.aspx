<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboratorio154.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            +<asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sumar" />
        </p>
        <p>
            Resultado: <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
