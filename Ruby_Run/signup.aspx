<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="signup.aspx.vb" Inherits="Ruby_Run.signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr><td>Firstname</td><td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td></tr>
            <tr><td>Last Name</td><td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td></tr>
            <tr><td>Mailing Address/PO BOX</td><td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td></tr>
            <tr><td>City</td><td><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td></tr>
            <tr><td>State</td><td><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td></tr>
            <tr><td>Zip</td><td><asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td></tr>
            <tr><td>Email</td><td><asp:TextBox ID="TextBox7" runat="server"></asp:TextBox></td></tr>
            <tr><td>Would you like Promo emails?</td><td><asp:CheckBox ID="CheckBox1" runat="server" /></td></tr>
            <tr><td>Would you like Alert emails?</td><td><asp:CheckBox ID="CheckBox2" runat="server" /></td></tr>
            <tr><td>Would you like Results emails?</td><td><asp:CheckBox ID="CheckBox3" runat="server" /></td></tr>
            <tr><td colspan="2"><asp:Button ID="Button1" runat="server" Text="Sign Me Up!" /></td></tr>
        </table>
    </form>
</body>
</html>
