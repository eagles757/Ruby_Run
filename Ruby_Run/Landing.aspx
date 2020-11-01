<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Landing.aspx.vb" Inherits="Ruby_Run.Landing" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
       <title>Eagle Pics</title>
    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>

</head>
<body>
    <form id="form1" runat="server">
       <table style="width:100%"><tr><td>Ruby Run</td></tr>
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
               <td style="vertical-align:top;text-align:center">
                   Last Weeks Results
                   <table id="lastweek" runat="server" style="width:80%"></table>
               </td>
               <td style="vertical-align:top">My Picks   <h3>Week: <asp:Label ID="Label11" runat="server" Text="Label"></asp:Label></h3>
                   
                   <table id="tw1" runat="server" style="width:80%"></table>
                 <%--  <asp:GridView ID="GridView2" runat="server"></asp:GridView>--%>
                   <asp:Button ID="Button1" runat="server" Text="Save" OnClick="Button1_Click" />

               </td>
               <td style="vertical-align:top;text-align:center">Place in my tear</td>
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
