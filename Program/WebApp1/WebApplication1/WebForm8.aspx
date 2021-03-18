<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm8.aspx.cs" Inherits="WebApplication1.WebForm8" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem Value="1" Text="First"></asp:ListItem>
            <asp:ListItem Value="2">Second</asp:ListItem>
            <asp:ListItem>Third</asp:ListItem>        
        </asp:CheckBoxList>
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem Value="1" Text="First"></asp:ListItem>
            <asp:ListItem Value="2">Second</asp:ListItem>
            <asp:ListItem>Third</asp:ListItem>  
        </asp:RadioButtonList>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
