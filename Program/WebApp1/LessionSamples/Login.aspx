<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LessionSamples.Login1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:PlaceHolder runat="server" ID="plc1">
        <asp:TextBox ID="txtAccount" runat="server" />
        <br />
        Password:
            <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" />
        <br />
        <asp:Button runat="server" ID="btnLogin" OnClick="btnLogin_Click" Text="Login" />
        <asp:Literal runat="server" ID="ltMessage"></asp:Literal>
    </asp:PlaceHolder>
    <asp:PlaceHolder runat="server" ID="plc2" Visible="false">
        <asp:Literal runat="server" ID="ltAccount"></asp:Literal>
        <asp:Button runat="server" ID="btnLogout" Text="Logout" OnClick="btnLogout_Click" />
    </asp:PlaceHolder>

</asp:Content>
