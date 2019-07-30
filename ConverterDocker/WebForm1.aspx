<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ConverterDocker.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <b>CONVERTER</b>
        <br />
        <br />
        Required power (mW):<br />
        <asp:TextBox ID="TextBox1" runat="server" Width="208px" OnTextChanged="Label1_TextChanged"></asp:TextBox>
        <br />
        <br />
        Antenna gain :<br />
        <asp:TextBox ID="TextBox2" runat="server" Width="205px" OnTextChanged="Label2_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Exe_Btn" runat="server" OnClick="Button1_Click" Text="Execute" Width="259px" />
   </form>
</body>
</html>
