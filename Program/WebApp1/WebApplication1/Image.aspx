<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Image.aspx.cs" Inherits="WebApplication1.Image" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:PlaceHolder ID="PlaceHolder1" runat="server">
            <img src="images/IMG1.png" /><br />
            <img src="https://1.bp.blogspot.com/-WusqFXyxZyE/X9lJsqgJy7I/AAAAAAABc8M/gyc7RdN77JQPZfGa-rrjL7OMIzvpr4XcgCNcBGAsYHQ/s400/yukata_kids_couple.png" /><br />
        </asp:PlaceHolder>

        <asp:Image ID="Image1" runat="server" Visible="false" /><br />

        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Text="1"></asp:ListItem>
            <asp:ListItem Text="2"></asp:ListItem>
        </asp:DropDownList><br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </form>

    <% Response.Write(this.AAA); %>
</body>
</html>
