<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="HtmlPratice.WebForm3" %>

<%@ Register Src="~/ucPractice.ascx" TagPrefix="uc1" TagName="ucPractice" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:ucPractice runat="server" ID="ucPractice" />
    <uc1:ucPractice runat="server" ID="ucPractice1" />
    <uc1:ucPractice runat="server" ID="ucPractice2" />
</asp:Content>
