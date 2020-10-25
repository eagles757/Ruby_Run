<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="default.aspx.vb" Inherits="Ruby_Run._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <table>
           <tr><td>Welcome to Ruby Run</td></tr>
           <tr><td>If you dont have an account <a href="signup.aspx">Click here to sign up ** ITS FREE **</a></td></tr>
           <tr><td>If you have an account sign in below</td></tr>
       </table>
       <table>
           <tr><td colspan="2" style="background-color:#002649;color:white">Login</td></tr>
           <tr><td>Username:</td><td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td></tr>
           <tr><td>Password:</td><td><asp:TextBox ID="TextBox2" runat="server" TextMode="Password" ></asp:TextBox></td></tr>
           <tr><td colspan="2"><asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" /></td></tr>
       </table>
    </form>
</body>
</html>
