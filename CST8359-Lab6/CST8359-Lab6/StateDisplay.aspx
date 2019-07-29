<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StateDisplay.aspx.cs" Inherits="CST8359_Lab6.StateDisplay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Session State Display</h2>
    <br />
    <p>
        ASP.NET session state enables you to store and retrieve values for a user as the user navigates the different ASP.NET pages that make up a Web application.
    </p>
    <p>https://msdn.microsoft.com/en-us/library/87069683(v=vs.85).aspx</p>
    <hr />
    <asp:Label ID="lblFName" runat="server" class="control-label col-md-6" Text=""/>
    <br />
    <asp:Label ID="lblLName" runat="server" class="control-label col-md-6" Text=""/>
    <br />
    <asp:Label ID="lblEmail" runat="server" class="control-label col-md-6" Text=""/>
    <br />
    <asp:Label ID="lblCalendar" runat="server" class="control-label col-md-6" Text=""/>  
</asp:Content>
