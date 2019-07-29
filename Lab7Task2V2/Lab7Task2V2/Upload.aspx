<%@ Page Title="Upload" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Upload.aspx.cs" Inherits="Lab7Task2V2.Upload" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Upload</h1>
    <hr />
    Fill out the details below and click 'Upload File Now'
    <br />
    <br />
    <br />
    <b>Select a file: </b><asp:FileUpload ID="fileUpload" runat="server" />
    <br />
    <asp:Button ID="uploadButton" runat="server" Text="Upload File Now" OnClick="uploadButton_Click" />

</asp:Content>
