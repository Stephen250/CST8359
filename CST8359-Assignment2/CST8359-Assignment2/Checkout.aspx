<%@ Page Title="Checkout" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="CST8359_Assignment2.Checkout" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Checkout - THIS IS FAKE!!!!</h3>
    <hr />
    
    <p>Name on Card: </p><asp:TextBox ID="TextBox1" runat="server"/>
    <p>Credit Card Number: </p><asp:TextBox ID="TextBox2" runat="server"/>
    <p>Expiry Date: </p><asp:TextBox ID="TextBox3" runat="server"/>
    <ajaxToolkit:CalendarExtender ID="TextBox3_CalendarExtender" runat="server" BehaviorID="TextBox3_CalendarExtender" TargetControlID="TextBox3" />
    <br />
    <br />
    <asp:Button ID="btn_BuyNow" runat="server" Text="Complete Transaction" class="btn btn-success" OnClick="btn_BuyNow_Click"/>
    <asp:HyperLink NavigateUrl='~/' runat="server" role="button" class="btn btn-primary">Cancel Transaction</asp:hyperlink>

</asp:Content>
