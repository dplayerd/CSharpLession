<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RepeaterDetail.aspx.cs" Inherits="WebAppAndDB.RepeaterDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <%= Request.QueryString["ID"] %>

        Name: <asp:TextBox runat="server" ID="txtName"></asp:TextBox><br />
        Birthday: <asp:TextBox runat="server" ID="txtBirthday"></asp:TextBox><br />
        <asp:Button runat="server" Text="Save" OnClick="Unnamed_Click" />
    </form>
</body>
</html>
