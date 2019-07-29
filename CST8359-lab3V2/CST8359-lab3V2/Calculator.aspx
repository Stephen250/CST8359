<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="CST8359_Lab3.Calculator" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="Label1" runat="server">Number 1: </asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="TextBox1" runat="server" ErrorMessage="Only Numbers allowed" ValidationExpression="((\+|-)?([0-9]+)(\.[0-9]+)?)|((\+|-)?\.?[0-9]+)"></asp:RegularExpressionValidator>
   
    <br />
    <asp:Label ID="Label2" runat="server">Number 2: </asp:Label>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" ControlToValidate="TextBox2" runat="server" ErrorMessage="Only Numbers allowed" ValidationExpression="((\+|-)?([0-9]+)(\.[0-9]+)?)|((\+|-)?\.?[0-9]+)"></asp:RegularExpressionValidator>
    
    <br />
    <asp:Label ID="Label3" runat="server">Operation: </asp:Label>
    <asp:DropDownList ID="ddlOperations" runat="server" AutoPostBack="True" OnSelectedIndexChanged="itemSelected">
        <asp:ListItem Text="Select Operation" Value="0"></asp:ListItem>
        <asp:ListItem Text="add" Value="add"></asp:ListItem>
        <asp:ListItem Text="subtract" Value="subtract"></asp:ListItem>
        <asp:ListItem Text="multiply" Value="multiply"></asp:ListItem>
        <asp:ListItem Text="divide" Value="divide"></asp:ListItem>
        <asp:ListItem Text="exp" Value="exp"></asp:ListItem>
    </asp:DropDownList>

    <br />
    <br />
    <asp:Label ID="result" runat="server"></asp:Label>
</asp:Content>
