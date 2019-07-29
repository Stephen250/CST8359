<%@ Page Title="Product Details" Language="C#" MasterPageFile="~/SiteMenu.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="CST8359_Assignment2.ProductDetails" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h3>
        <asp:Label ID="lblName" runat="server" /></h3>
    <hr />
    <div class="row">
        <div class="col-md-6">
            <%if (Session["user"] != null)
              {%>
            <asp:Button ID="btnAddToCart" runat="server" Text="Add To Cart" class="btn btn-success" OnClick="btnAddToCart_Click" />
            <%}
              else
              {%>
            <p>Login to add to cart</p>
            <%}%>
        </div>
        <div class="col-md-6">
            <ol class="breadcrumb">
                <li class="active">Product Details</li>
            </ol>
        </div>
    </div>
    <hr />

    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            <asp:Image ID="image1" runat="server" ImageUrl='<%# "GetFileHandler.ashx?fileid=" + Eval("ID") %>' Width="300" />

            <p>Price: <%# Eval("Price") %> Sale Price:<%# Eval("SalePrice") %></p>
            <p>Is On Sale: <%# Eval("IsOnSale") %></p>
            <p>
                <%# Eval("ShortDescription") %>
            </p>
        </ItemTemplate>
    </asp:Repeater>

    <ajaxToolkit:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0">
        <ajaxToolkit:TabPanel runat="server" HeaderText="Overview" ID="TabPanel1">
            <ContentTemplate>
                <asp:Label ID="lblLongDescription" runat="server" />

            </ContentTemplate>
        </ajaxToolkit:TabPanel>
        <ajaxToolkit:TabPanel ID="TabPanel2" runat="server" HeaderText="Reviews">
            <ContentTemplate>
                <asp:Literal runat="server" ID="commentLiteral" />
                <%if (Session["user"] != null)
                  {%>
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="txtComment" CssClass="col-md-2 control-label">Comment</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox runat="server" TextMode="MultiLine" Columns="50" Rows="5" ID="txtComment" CssClass="form-control" />

                    </div>
                </div>
                <div class="form-group">
                    <div class="col-md-offset-2 col-md-10">
                        <asp:Button runat="server" OnClick="CreateComment" Text="Post" CssClass="btn btn-default" />
                    </div>
                </div>
                <%}%>
            </ContentTemplate>
        </ajaxToolkit:TabPanel>
    </ajaxToolkit:TabContainer>


</asp:Content>
