<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page1.aspx.cs" Inherits="HtmlPratice.Page1" %>

<%@ Register Src="~/ucPractice.ascx" TagPrefix="uc1" TagName="ucPractice" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        123123<br />
        321321<br />
        <uc1:ucPractice runat="server" id="ucPractice" UCName="1" />
        <uc1:ucPractice runat="server" id="ucPractice1" UCName="2" />
    </form>
</body>
</html>
