<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CST8359_Lab8._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Thac0006 Lab 8 </h1>
        <p class="lead">Please choose an option below to explore!</p>
    </div>

    <div class="row">
        <div class="col-md-3">
            <h2>HTML Editor</h2>
            <a runat="server" href="~/HTMLEditer">HTML Editer</a>
        </div>
        <div class="col-md-3">
            <h2>Fancy Form</h2>
            <a runat="server" href="~/FancyForm">Fancy Form</a>
        </div>
        <div class="col-md-3">
            <h2>Tabs</h2>
            <a runat="server" href="~/Tabs">Tabs</a>
        </div>
    </div>

</asp:Content>
