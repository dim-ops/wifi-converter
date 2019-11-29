<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ConverterDocker.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>        
    <title>Converter</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="page">
        <h1 class="font-weight-light mt-4 text-white">CONVERTER</h1>
        <br />
        <br />
        <p>Required power (mW):</p>
            <asp:TextBox ID="TextBox1" runat="server" Width="237px" OnTextChanged="TextBox_1"></asp:TextBox>
        <br />
        <br />
        <p>Antenna gain :</p>
            <asp:TextBox ID="TextBox2" runat="server" Width="241px" OnTextChanged="TextBox_2"></asp:TextBox>
        <br />
        <br />
            <asp:Button ID="Exe_Btn" runat="server" OnClick="Button1_Click" Text="Execute" Width="259px" />
        <br />
        <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
   </form>
    <footer id="sticky-footer" class="py-4 bg-dark text-white-50">
    <div class="container text-center">
      <small>Copyright &copy; Dimitri GRISARD</small>
    </div>
  </footer>
</body>
</html>
