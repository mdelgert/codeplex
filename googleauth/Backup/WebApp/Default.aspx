<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApp.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>Google Authenticator Multifactor Authentication Demo</div>
    <br />
    <div><asp:HyperLink ID="linkBegin" runat="server" NavigateUrl="~/Login.aspx">Click here to begin</asp:HyperLink></div>
    <br />
    <div>To install the Google Authenticator application on your mobile device, visit <a href="http://support.google.com/accounts/bin/answer.py?hl=en&answer=1066447">GOOGLE AUTHENTICATOR!</a></div>
    <br />
    <div>To associate Google Authenticator with your account, scan the barcode below with your Google Authenticator application.</div>
    <br />
    <div><iframe width="300" height="300" frameborder="0" src="http://chart.apis.google.com/chart?cht=qr&chs=200x200&chl=otpauth%3A//totp/mdelgert%40yahoo.com%3Fsecret%3Dcfzym44idrpzrg23&chld=H|0"></iframe></div>
    </form>
</body>
</html>
