<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RepeaterPrerenderEvent.aspx.cs" Inherits="WebAppAndDB.RepeaterPrerenderEvent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Repeater ID="Repeater1" runat="server" 
            OnPreRender="Repeater1_PreRender">
            <ItemTemplate>
                <div>
                    <p><%# Eval("ID") %></p>
                    <p>
                        <asp:Literal runat="server" ID="ltName" 
                            Text='<%# Eval("Name") %>'></asp:Literal> 
                    </p>
                    <p><%# Eval("Birthday", 
                            "{0: yyyy/MM/dd}") %></p>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </form>
</body>
</html>
