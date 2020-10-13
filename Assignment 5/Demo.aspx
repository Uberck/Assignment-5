<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Demo.aspx.cs" Inherits="Assignment_5.Demo" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
   <head runat="server">
      <title></title>
   </head>
   <body>
      <form id="form1" runat="server">
         <div>
            <center>
               <asp:TextBox runat="server" ID="inputTxt"></asp:TextBox>
               <br /><br />
               <asp:Button ID="factorial" Text="Calculate Factorial!" OnClick="factorial_Click" runat="server" />
               <br /><br />
               <asp:Button ID="sum" Text="Calculate Sum!" OnClick="sum_Click" runat="server"/>
               <br /><br />
               <label>Result:&nbsp;</label>
               <asp:Label ID="result" Text="" style="font-size:18px;color:blue;font-weight:bold" runat="server"></asp:Label>
            </center>
         </div>
      </form>
   </body>
</html>