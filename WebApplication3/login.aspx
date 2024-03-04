<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication3.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="loginstyle.css" />
</head>
<body>
  <div class="login-page">
  <div class="form">
    <form class="login-form" runat="server">
        <asp:TextBox ID="TextBox1" placeholder="email" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox2" placeholder="password" runat="server"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" Text="login" OnClick="Button2_Click" />
      <p class="message">Not registered? <a href="#">Create an account</a></p>
    </form>
  </div>
</div>
    <script>$('.message a').click(function () {
            $('form').animate({ height: "toggle", opacity: "toggle" }, "slow");
        });</script>
</body>
</html>
