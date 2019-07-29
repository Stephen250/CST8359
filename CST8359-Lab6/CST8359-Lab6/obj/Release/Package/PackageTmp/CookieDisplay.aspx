<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CookieDisplay.aspx.cs" Inherits="CST8359_Lab6.CookieDisplay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <h2>Cookie Display</h2>
    <br />
    <p>
        Cookies provide a means in Web applications to store user-specific information, such as history or user preferences. A cookie is a small bit of text that accompanies requests and responses as they go between the Web server and client. 
        The cookie contains information that the Web application can read whenever the user visits the site.
    </p>
    <p>https://msdn.microsoft.com/en-us/library/78c837bd.aspx</p>
    <hr />
    <asp:Label ID="lblFName" runat="server" class="control-label col-md-6" Text=""/>
    <br />
    <asp:Label ID="lblLName" runat="server" class="control-label col-md-6" Text=""/>
    <br />
    <asp:Label ID="lblEmail" runat="server" class="control-label col-md-6" Text=""/>
    <br />
    <asp:Label ID="lblCalendar" runat="server" class="control-label col-md-6" Text=""/>  
</asp:Content>
