<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASP.NET_WebApplication.Default" %>
    <!DOCTYPE html>
    <html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
     <title></title>
    </head>
    <body>
     <form id="Form1" runat="server">
     <!-- Top header section code -->
     <div style="width:100%;background-color:#000000" >
     <!-- Header ASP.NET Label goes here -->
    <asp:Label ID="lblHeaderNav" runat="server" Font-Bold="True" Font-Size="Large" Text="Small
    Business Application" Width="597px" ForeColor="White"></asp:Label>
     <br />
     <br />
     </div>
     <!-- Welcome, login & message section code -->
     <div style="width:100%">
     <h1> Welcome to our Bussines!</h1>
     <p>
     We are excited to provide our valued members an overview of the value of our products
     and services.<br />
     </p>
     <!-- Prompt ASP.NET Label goes here -->
    <asp:Label ID="lblPrompt" runat="server" Font-Bold="True" Font-Size="Large" Text="Please enter
    credentials" Width="632px"></asp:Label>
         <br />
     <br />
     <table border="0" style="background-color:#EEE8AA">
     <tr><!-- Row 1 blank row for formatting -->
     <td colspan="3" style="width:400px;text-align:center;background-color:#EEE8AA">

     </td>
     </tr>
     <tr> <!-- Row 2 -->
     <td style="width: 100px">
     <!-- Username Label ASP,NET Control -->
   <asp:Label ID="lblUsername" runat="server" Text="Username" Font-Bold="True"></asp:Label>
     </td>
     <td style="width: 200px">
     <!-- Username Textbox ASP,NET Control -->
    <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
     </td>
     <td style="width: 100px">
     <!-- OK Button ASP,NET Control -->
    <asp:Button ID="btnOK" runat="server" Text="Ok" Width="100px" OnClick="btnOK_Click" />
     </td>
     </tr>
     <tr><!-- Row 3 -->
     <td style="width: 100px">
     <!—Password Lable ASP,NET Control -->
    <asp:Label ID="lblPassword" runat="server" Text="Password" Font-Bold="True"></asp:Label>
     </td>
     <td style="width: 200px">
     <!—Password Textbox ASP,NET Control -->
    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
     </td>
     <td style="width: 100px">
     <!-- Cancel Button ASP,NET Control -->
    <asp:Button ID="btnCancel" runat="server" Text="Cancel" Width="100px" OnClick="btnCancel_Click" />
     </td>
     </tr>
     <tr><!-- Row 4 Blank row for formatting-->
     <td colspan="3" style="width:400px;text-align:center;background-color:#EEE8AA">
     <br />
     </td>
     </tr>
     </table>

     <br />
     <br />
    <!-- Message section code & Message Label Control -->
    <asp:Label ID="lblMessage" runat="server" Font-Bold="True" Font-Size="Medium" Width="399px"
    ForeColor="#CC3300"></asp:Label>
     </div>
     <br />
     <br />
     <br />
     <br />
     <!-- Footer section code -->
     <div style="width:100%;background-color:#00CED1">
     <table border="0">
     <tr> <!-- Row 1 -->
     <td style="width:400px;text-align:left">
    <asp:Label ID="lblFooter" runat="server" Font-Bold="True" Font-Size="Large" Text="All About Us"
    Width="991px" ForeColor="Black"></asp:Label>
     </td>
     </tr>
     <tr> <!-- Row 2 -->
     <td style="width:400px;text-align:left">
    <asp:LinkButton ID="lkbAboutUs" Font-Bold="True" runat="server">About Us</asp:LinkButton>
     </td>
     </tr>
     <tr> <!-- Row 3 -->
     <td style="width:400px;text-align:left">
    <asp:LinkButton ID="lkbCareers" Font-Bold="True" runat="server">Careers</asp:LinkButton>
     </td>
     </tr> <!-- Row 4 -->
     <tr>
     <td style="width:400px;text-align:left">
    <asp:LinkButton ID="lkbBlogs" Font-Bold="True" runat="server">Blogs</asp:LinkButton>
     </td>
     </tr>
     <tr> <!-- Row 5 -->
     <td style="width:400px;text-align:left">
    <asp:LinkButton ID="lkbCompanyTours" Font-Bold="True" runat="server">Company Tours</asp:LinkButton>
     </td>
     </tr>
     </table>
     </div>
     </form>
    </body>
    </html>