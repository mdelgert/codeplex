<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MFA.aspx.cs" Inherits="WebApp.MFA" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>Google Authenticator Multifactor Authentication</div>
    <br />
    <div></div>
    <br />
    <div>1. Run the Google Authenticator application on your mobile device</div>
    <br />
    <div>2. Enter your current verification code in the box below</div>
    <br />
    <div>3. Click Authenticate</div>
    <br />
    <div><asp:TextBox ID="txtToken" runat="server" Width="500px"></asp:TextBox></div>
    <br />
    <div><asp:Button ID="btnLogin" runat="server" Text="Authenticate" 
            onclick="btnLogin_Click" Width="500px" /></div>
    <br />
    <div><asp:Label ID="lblMessage" runat="server" Text=""></asp:Label></div>
    </form>
</body>
</html>
