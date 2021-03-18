<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebAppAndDB.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        ID:<asp:TextBox ID="txtID" runat="server"></asp:TextBox><br />
        Name:<asp:TextBox ID="txtName" runat="server" Text="AAA"></asp:TextBox><br />
        Birthday:<asp:TextBox ID="txtBirthday" runat="server" Text="2021/3/12"></asp:TextBox><br />
        NumberColumn:<asp:TextBox ID="txtNumberCol" runat="server" Text="32"></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Button1_Click" />

        <br />
        <asp:Button ID="Button2" runat="server" Text="Delte" OnClick="Button2_Click" />

    </form>
</body>
</html>
