<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm7.aspx.cs" Inherits="WebApplication1.WebForm7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:CheckBox ID="CheckBox1" runat="server" Text="hihi" />
        <asp:CheckBox ID="CheckBox2" runat="server" Text="NGNG" />
        <br />

        <asp:RadioButton ID="RadioButton1" runat="server" Text="Radio1" GroupName="RB1" />
        <asp:RadioButton ID="RadioButton2" runat="server" Text="Radio2" GroupName="RB1" />

        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" /><br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
