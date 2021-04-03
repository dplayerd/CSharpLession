<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StatusWriter.aspx.cs" Inherits="LessionSamples.StatusWriter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button runat="server" ID="btnAdd"  Text ="Add" OnClick="btnAdd_Click"/>
        <br />
          <asp:Button runat="server" ID="btn"  Text="Remove" OnClick="btn_Click"/>
    </form>
</body>
</html>
