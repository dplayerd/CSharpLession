<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RepeaterPage1.aspx.cs" Inherits="WebAppAndDB.RepeaterPage1"  %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
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
                <th>Act Buttons</th>
            </tr>

        <asp:Repeater ID="Repeater1" runat="server" 
            OnItemDataBound="Repeater1_ItemDataBound" OnItemCommand="Repeater1_ItemCommand">
            <ItemTemplate>
                <tr>
                    <td></td>
                    <td><%# Eval("ID") %></td>
                    <td><%# Eval("Name") %></td>
                    <td><%# Eval("Birthday", "{0: yyyy-MM-dd}") %></td>

                    <asp:Literal runat="server" ID="ltName" Visible="false"> - </asp:Literal>
                    <td>
                        <asp:Button runat="server" Text="Delete" CommandName="DeleteItem" CommandArgument='<%# Eval("ID") %>' />
                        <asp:Button runat="server" Text="Update" CommandName="UpdateItem" CommandArgument='<%# Eval("ID") %>' />
                    </td>
                </tr>

                
            </ItemTemplate>
        </asp:Repeater>
        </table>
    </form>
</body>
</html>
