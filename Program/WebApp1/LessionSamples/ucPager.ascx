<%@ Control Language="C#" AutoEventWireup="true"
    CodeBehind="ucPager.ascx.cs"
    Inherits="LessionSamples.ucPager" %>

<div>
    <a runat="Server" id="aLinkFirst" href="#">First</a>

    <a runat="Server" id="aPage1" href="#">1</a>
    <a runat="Server" id="aPage2" href="#">2</a>
    <a runat="Server" id="aPage3" href="#">3</a>

    <a runat="Server" id="aLinkLast" href="#">Last</a>
</div>
<div>
    <asp:literal runat="Server" id="ltCurrentPage" /> / 
    <asp:literal runat="Server" id="ltTotalPage" />
</div>

