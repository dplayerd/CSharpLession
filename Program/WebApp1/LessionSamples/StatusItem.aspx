<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StatusItem.aspx.cs" Inherits="LessionSamples.StatusItem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label runat="server" ID="lblMsg"></asp:Label>
        <asp:button ID="btn1" runat="server" OnClick="btn1_Click" Text="Click Me" />
    </form>
</body>
</html>
