<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lab7Task2V2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Upload File</h2>
    <br />
    <asp:Button ID="uploadFileButton" runat="server" Text="Upload File" PostBackUrl="~/Upload.aspx" />
    <br />
    <br />
    <h2>Current Files</h2>
    <br />
    <asp:GridView id="imagesGridView" runat="server">
        <EmptyDataTemplate>
            <br />
            Currently, there are no files in storage.
            <br />
            <br />
        </EmptyDataTemplate>

        <Columns>
            <asp:TemplateField ItemStyle-Width="10%" HeaderText="Options">
                <ItemTemplate>
                    <asp:Button ID="deleteButton" runat="server" Text="Delete" OnClick="deleteButton_Click" CommandArgument='<%# Eval("FileId") %>' />
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Image" ItemStyle-HorizontalAlign="Center">
                <ItemTemplate>
                    <asp:Image ID="image" runat="server" ImageUrl='<%# "GetFileHandler.ashx?fileid=" + Eval("FileId") %>' Width="300" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>

</asp:Content>
