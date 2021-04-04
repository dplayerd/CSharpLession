<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="JavaScriptProject.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div></div>

    <div id="id1">
        <p>123</p>
        <p class="c1">123
            <span>123</span>
            <span>123</span>
        </p>
        <p>123</p>
    </div>
        
    <div id="id2"></div>

    <input type="text" name="inp1" value="AAA" />

    <button type="button" onclick="func1()">alert val</button>
    <button type="button" onclick="func2()">append text</button>
    <button type="button" onclick="func3()">append html</button>

    <script>
        <asp:Literal runat="server" ID="ltArr"></asp:Literal>       
    </script>



    <script src="common.js"></script>
    </form>
</body>
</html>
