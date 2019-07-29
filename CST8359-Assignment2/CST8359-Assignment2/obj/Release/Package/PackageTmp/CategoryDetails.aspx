<%@ Page Title="Categories" Language="C#" MasterPageFile="~/SiteMenu.Master" AutoEventWireup="true" CodeBehind="CategoryDetails.aspx.cs" Inherits="CST8359_Assignment2.CategoryDetails" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Categorized Products</h3>
    <hr />
    <div class="row">
        <div class="col-md-6">
            <h4>Create a new Category</h4>
        </div>
        <div class="col-md-6">
            <ol class="breadcrumb">
                <li class="active">Category Details</li>
            </ol>
        </div>
    </div>
    <hr />
    <div class="row">
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <div class="col-sm-6 col-md-4">
                    <div class="thumbnail">
                        <asp:Image ID="image" runat="server" ImageUrl='<%# "GetFileHandler.ashx?fileid=" + Eval("ID") %>' Width="300" />
                        <div class="caption">
                            <h3><%# Eval("Name") %></h3>
                            <p>Price: <%# Eval("Price") %> Sale Price:<%# Eval("SalePrice") %></p>
                            <p><%# Eval("ShortDescription") %></p>
                            <p>
                                <asp:HyperLink NavigateUrl='<%# Eval("ID", "~/ProductDetails?id={0}") %>' runat="server" role="button" class="btn btn-primary">See More</asp:HyperLink>
                            </p>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>

</asp:Content>
