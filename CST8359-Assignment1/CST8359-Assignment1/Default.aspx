<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CST8359_Assignment1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>My Blog</h1>
        <h3>Check out the 5 latest blogs below or select an option to get started.</h3>

        <% if (!Request.IsAuthenticated) {%>

        <p>Please Sign Up or Login to continue: </p>
        <a runat="server" href="~/Account/Register" CssClass="btn btn-default">Register</a>
        <a runat="server" href="~/Account/Login" CssClass="btn btn-default">Log in</a>

        <%} else {%>

        <p>Edit User btn if authenticated</p>
        <p>ADMIN HOME btn if authenticated and admin</p>

        <%}%>
    </div>

    <div class="row">
        <p>Grid view Repeater of 5 latest blogs</p>
        <p>Page if greater then 5</p>
    </div>

</asp:Content>
