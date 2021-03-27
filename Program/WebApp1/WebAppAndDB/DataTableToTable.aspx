<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataTableToTable.aspx.cs" Inherits="WebAppAndDB.DataTableToTable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <table border="1">
            <asp:Literal runat="server" ID="ltTableBody"></asp:Literal>
        </table>

    </form>
</body>
</html>
