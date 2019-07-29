<%@ Page Title="Cart " Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CartPg.aspx.cs" Inherits="CST8359_Assignment2.Cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Cart</h3>
    <hr />
    <asp:HyperLink NavigateUrl='~/' runat="server" role="button" class="btn btn-primary">Continue Shopping</asp:HyperLink>
    <asp:Button ID="btnRemove" runat="server" Text="Remove All from Cart" OnClick="btnRemoveFromCart_Click" class="btn btn-danger"/>

    <hr />
    <div class="row">
        <asp:Repeater ID="Repeater2" runat="server">
            <ItemTemplate>
                <div class="col-sm-6 col-md-4">
                    <div class="thumbnail">
                        <asp:Image ID="image" runat="server" ImageUrl='<%# "GetFileHandler.ashx?fileid=" + Eval("ID") %>' Width="300" />
                        <div class="caption">
                            <h3>
                                <h3><%# Eval("Name") %></h3>
                            <p>Price: <%# Eval("Price") %> Sale Price:<%# Eval("SalePrice") %></p>
                            <p>Is On Sale: <%# Eval("IsOnSale") %></p>
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
    <hr />
    <p>
        Total:
        <asp:Literal runat="server" ID="TotalLiteral" />
    </p>
    <asp:HyperLink NavigateUrl='~/Checkout' runat="server" role="button" class="btn btn-success">Buy Now</asp:HyperLink>
</asp:Content>
