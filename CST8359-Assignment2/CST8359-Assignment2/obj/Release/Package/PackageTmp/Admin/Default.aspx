<%@ Page Title="Admin" Language="C#" MasterPageFile="~/SiteAdminMenu.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CST8359_Assignment2.Admin.Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Admin Panel</h3>
    <hr />
    <div class="row">
        <div class="col-md-6">
            <h4>Select an option below</h4>
        </div>
        <div class="col-md-6">
            <ol class="breadcrumb">
                <li class="active">Admin</li>
            </ol>
        </div>
    </div>
    
    <hr />
    <div class="row">
        <div class="col-md-6">
            <div class="row">
                <div class="col-md-6">
                    <h3>Bad Words</h3>
                </div>
                <div class="col-md-6">
                    <div class="btn-group" role="group" aria-label="...">
                        <a runat="server" href="~/Admin/BadWords" class="btn btn-default">Add Bad Word</a>
                    </div>
                </div>
            </div>
            <hr />
            <asp:GridView ID="GridView1" runat="server" EmptyDataText="Currently, there are no Bad Words to display" CellPadding="4" OnRowDeleting="OnRowDeletingB" ForeColor="#333333" GridLines="Both">
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ButtonType="Button" />
                </Columns>
            </asp:GridView>
        </div>
        <div class="col-md-6">
            <div class="row">
                <div class="col-md-6">
                    <h3>Categories</h3>
                </div>
                <div class="col-md-6">
                    <div class="btn-group" role="group" aria-label="...">
                        <a runat="server" href="~/Admin/AddCategory" class="btn btn-default">Add Category</a>
                    </div>
                </div>
            </div>
            <hr />
            <asp:GridView ID="GridView2" runat="server" EmptyDataText="Currently, there are no Categories to display" CellPadding="4" ForeColor="#333333" GridLines="Both" OnRowDeleting="OnRowDeletingC" OnRowEditing="OnRowEditingC">
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ButtonType="Button" />
                    <asp:CommandField ShowEditButton="True" ButtonType="Button" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
    <hr />
    <div class="row">
        <div class="col-md-6">
            <h3>Products</h3>
        </div>
        <div class="col-md-6">
            <div class="btn-group" role="group" aria-label="...">
                <a runat="server" href="~/Admin/AddProduct" class="btn btn-default">Add Product</a>
            </div>
        </div>
    </div>
    <hr />
    <asp:GridView ID="GridView3" runat="server" EmptyDataText="Currently, there are no Products to display" CellPadding="4" ForeColor="#333333" GridLines="Both" OnSelectedIndexChanged="GridView3_SelectedIndexChanged" OnRowDeleting="OnRowDeletingP" OnRowEditing="OnRowEditingP">
        <Columns>
            <asp:CommandField ShowSelectButton="True" ButtonType="Button" />
            <asp:CommandField ShowDeleteButton="True" ButtonType="Button" />
            <asp:CommandField ShowEditButton="True" ButtonType="Button" />
        </Columns>
    </asp:GridView>
</asp:Content>
