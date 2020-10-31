<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Landing.aspx.vb" Inherits="Ruby_Run.Landing" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <table><tr><td>Ruby Run</td></tr>
           <tr>
               <td>User: <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>               </td>
               <td>LifeTime Stats: <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label></td>
               <td>
                   <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#exampleModal">
  Account Info
</button>
               </td>

           </tr>
           <tr>
               <td>
                   Last Weeks Results
                   <table id="lastweek" runat="server"></table>
               </td>
               <td>My Picks   <h3>Week: <asp:Label ID="Label11" runat="server" Text="Label"></asp:Label></h3>
                   
                   <%--<table id="tw1" runat="server"></table>--%>
                   <asp:GridView ID="GridView2" runat="server"></asp:GridView>

               </td>
               <td>Place in my tear</td>
           </tr>
       </table>



        <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="exampleModalLabel">Modal title</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
       MyAccount
                   <table>
                       <tr><td colspan="2" style="background-color:#002649"><center>My Info</center></td></tr>
                       <tr><td>First Name</td><td><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td></tr>
                       <tr><td>Last Name</td><td><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></td></tr>
                       <tr><td>Address</td><td><asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></td></tr>
                       <tr><td>City</td><td><asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></td></tr>
                       <tr><td>Stata</td><td><asp:Label ID="Label5" runat="server" Text="Label"></asp:Label></td></tr>
                       <tr><td>Zip</td><td><asp:Label ID="Label6" runat="server" Text="Label"></asp:Label></td></tr>
                       <tr><td>Email</td><td><asp:Label ID="Label7" runat="server" Text="Label"></asp:Label></td></tr>
                       <tr><td>Phone</td><td><asp:Label ID="Label8" runat="server" Text="Label"></asp:Label></td></tr>
                   </table>
                   <table>
                       <tr><td style="background-color:#002649"><center>My Cards</center></td></tr>
                       <tr><td><asp:GridView ID="GridView1" runat="server"></asp:GridView></td></tr>
                       <tr><td><a href="addCard.aspx">Add Another Card</a></td></tr>
                       </table>

      </div>
    </div>
  </div>
</div>


    </form>
</body>
</html>
