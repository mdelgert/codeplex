<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApp.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <h1>Login</h1>
    <br />
    <div>User Name: - Default "Admin"</div>
    <br />
    <div><div><asp:TextBox ID="txtUser" runat="server" Width="500px" Text="Admin"></asp:TextBox></div></div>
    <br />
    <div>Password: - Default "Password"</div>
    <br />
    <div><div><asp:TextBox ID="txtPass" runat="server" Width="500px" Text="Password"></asp:TextBox></div></div>
    <br />
    <div><asp:Button ID="btnLogin" runat="server" Text="Login" 
            onclick="btnLogin_Click1" Width="500px"/></div>
    <br />
    <div><asp:Label ID="lblMessage" runat="server" Text=""></asp:Label></div>
    </form>
</body>
</html>
