<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DrapDownList.aspx.cs" Inherits="BasicWebForm.DrapDownList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            您喜歡什麼水果呢?
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Value="蘋果">蘋果</asp:ListItem>
                <asp:ListItem Value="香蕉">香蕉</asp:ListItem>
                <asp:ListItem Value="鳳梨" Selected="True">鳳梨</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Button ID="Button1" runat="server" Text="送出" OnClick="Button1_Click" />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
