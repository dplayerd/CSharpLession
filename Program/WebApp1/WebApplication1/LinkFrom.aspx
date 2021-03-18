<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LinkFrom.aspx.cs" Inherits="WebApplication1.LinkFrom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <a runat="server" id="aLink" href="LInkTo.aspx" target="_blank">LInkTo</a>
        <a href="LInkTo.aspx" target="_self">LInkTo</a>
        <br />
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">LinkButton</asp:LinkButton>
    </form>
</body>
</html>
