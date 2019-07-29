<%@ Page Title="HTMLEditer" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HTMLEditer.aspx.cs" Inherits="CST8359_Lab8.HTMLEditer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 <h3>HTML Editor</h3>
    <hr />
    <asp:TextBox
        ID="txtComments"
        TextMode="MultiLine"
        Columns="1500"
        Rows="25"
        Runat="server" />
 
    <ajaxToolkit:HtmlEditorExtender
        ID="hee"
        TargetControlID="txtComments"
        Runat="server" />
 
    <br /><br />
 
    <asp:Button
        ID="btnSubmit"
        Text="Submit"
        Runat="server" onclick="btnSubmit_Click" />
 
 
    <hr />

    <asp:Label
        ID="lblComment"
        Runat="server" />
 

</asp:Content>

