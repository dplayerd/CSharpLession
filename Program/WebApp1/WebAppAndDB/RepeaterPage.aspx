<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RepeaterPage.aspx.cs" Inherits="WebAppAndDB.RepeaterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <a href="RepeaterDetail.aspx">新增</a>
        <table border="1">
            <tr>
                <th>ID</th>
                <th>Name</th>
                <th>Birthday</th>
            </tr>
            <asp:Repeater ID="Repeater1" runat="server" 
                OnItemDataBound="Repeater1_ItemDataBound">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("ID") %></td>
                        <td>
                            <asp:Literal runat="server" ID="ltlName" 
                                Text='<%# Eval("Name") %>'>
                            </asp:Literal>
                        </td>
                        <td><%# Eval("Birthday", 
                                "{0: yyyy/MM/dd}") %></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>

    </form>
</body>
</html>
