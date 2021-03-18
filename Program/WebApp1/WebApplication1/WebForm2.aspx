<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title> 毛豆的第一個網頁 </title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 runat="server" id="h1_1">毛豆的第一個網頁</h1>
            <%--<h2>簡單介紹一下</h2>--%>
            <!--<h2>簡單介紹一下</h2>-->

            <% for (int i = 0; i < 20; i++) %>
            <% { %>
                <% if(i % 2 == 0) %>
                <% { %>
                <p>123 <%= i %></p>
                <% } %>
            <% } %>

            <div>
                <%= DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") %>
            </div>
        </div>
    </form>
</body>
</html>
