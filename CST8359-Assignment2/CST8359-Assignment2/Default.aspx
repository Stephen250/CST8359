<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/SiteMenu.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CST8359_Assignment2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Sky Buy</h1>
        <h3>Products from out of this world!</h3>

        <% if (Session["user"] == null)
           {%>

        <p>Please Login to access your cart continue: </p>
        <a runat="server" href="~/Login" class="btn btn-default">Log in</a>

        <%}
           else
           {%>

        <a runat="server" href="~/Admin/Default" class="btn btn-default" id="isAdmin">Admin Home</a>

        <%}%>
    </div>
    <ol class="breadcrumb">
        <li class="active">Home</li>
    </ol>
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
