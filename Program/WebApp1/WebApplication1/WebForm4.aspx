<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication1.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        .ImportantText {
            color: red;
        }

        .BigSizeText {
            font-size: 3em;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="Button1" runat="server" Text="Button1" OnClick="Button1_Click" />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Button2" OnClick="Button1_Click" />
        <br />
        <asp:Label runat="server" ID="lblMsg" CssClass="ImportantText BigSizeText">Main</asp:Label>
        <div class="ImportantText BigSizeText" title="Hello">
            123
        </div>

    </form>
</body>
</html>
