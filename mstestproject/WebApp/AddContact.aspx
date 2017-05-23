<%@ Page Language="C#" MasterPageFile="~/App_Master/Site.master" AutoEventWireup="true"
    CodeBehind="AddContact.aspx.cs" Inherits="WebApp.AddContact" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 115px;
        }
    </style>
    <script type="text/JavaScript">
        function ShowAlert() {
            alert('Contact saved!');
        }
    </script>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Add Contact</h2>
    <div>
        <table class="style1">
            <tr>
                <td class="style2" style="font-weight: bold">
                    First Name:
                </td>
                <td>
                    <asp:TextBox ID="txtFirstName" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2" style="font-weight: bold">
                    Middle Name:
                </td>
                <td>
                    <asp:TextBox ID="txtMiddleName" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2" style="font-weight: bold">
                    Last Name:
                </td>
                <td>
                    <asp:TextBox ID="txtLastName" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2" style="font-weight: bold">
                    Email Address:
                </td>
                <td>
                    <asp:TextBox ID="txtEmailAddress" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2" style="font-weight: bold">
                    Phone:
                </td>
                <td>
                    <asp:TextBox ID="txtPhone" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2" style="font-weight: bold">
                    Address Line:
                </td>
                <td>
                    <asp:TextBox ID="txtAddressLine" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2" style="font-weight: bold">
                    City:
                </td>
                <td>
                    <asp:TextBox ID="txtCity" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2" style="font-weight: bold">
                    State Province:
                </td>
                <td>
                    <asp:TextBox ID="txtStateProvince" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2" style="font-weight: bold">
                    Postal Code:
                </td>
                <td>
                    <asp:TextBox ID="txtPostalCode" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td class="style2">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" Width="327px" OnClick="btnSubmit_Click" onclientclick="ShowAlert();" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
