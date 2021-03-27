<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HtmlTable.aspx.cs" Inherits="WebAppAndDB.HtmlTable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table border="1">
            <tr>
                <th>欄1</th>
                <th>欄2</th>
                <th>欄2</th>
                <th>欄2</th>
            </tr>
            <asp:Literal runat="server" ID="ltTableContent"></asp:Literal>
        </table>
    </form>
</body>
</html>
