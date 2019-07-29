<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CST8359_Lab6._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>CST8359 Lab 6</h1>
        <p class="lead">Check out different session management devices by clicking a button below:</p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Cookies</h2>
            <p>
                <a class="btn btn-default" href="Cookie.aspx">Cookies Example &raquo;</a>
            </p>
        </div>

        <div class="col-md-4">
            <h2>Request String</h2>
            <p>
                <a class="btn btn-default" href="Request.aspx">Request Example  &raquo;</a>
            </p>
        </div>
        
        <div class="col-md-4">
            <h2>State</h2>
            <p>
                <a class="btn btn-default" href="State.aspx">State Example &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
