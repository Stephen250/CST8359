<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RequestDisplay.aspx.cs" Inherits="CST8359_Lab6.RequestDisplay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Query String Display</h2>
    <br />
    <p>
        The QueryString collection retrieves the values of the variables in the HTTP query string. 
        The HTTP query string is specified by the values following the question mark (?). Several different processes can generate a query string.  
    </p>
    <p>https://msdn.microsoft.com/en-us/library/ms524784(v=vs.90).aspx</p>
    <hr />
    <asp:Label ID="lblFName" runat="server" class="control-label col-md-6" Text=""/>
    <br />
    <asp:Label ID="lblLName" runat="server" class="control-label col-md-6" Text=""/>
    <br />
    <asp:Label ID="lblEmail" runat="server" class="control-label col-md-6" Text=""/>
    <br />
    <asp:Label ID="lblCalendar" runat="server" class="control-label col-md-6" Text=""/>  
</asp:Content>
