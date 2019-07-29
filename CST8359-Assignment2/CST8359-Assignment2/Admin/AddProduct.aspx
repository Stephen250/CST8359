<%@ Page Title="Add Product" Language="C#" MasterPageFile="~/SiteAdminMenu.Master" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="CST8359_Assignment2.Admin.AddProduct" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Add Product</h3>
    <hr />
    <div class="row">
            <div class="col-md-6">
                <h4>Create a new Product</h4>
            </div>
            <div class="col-md-6">
                <ol class="breadcrumb">
                    <li><a href="Default.aspx">Admin</a></li>
                    <li class="active">Product</li>
                </ol>
            </div>
        </div>
    <hr />

    <div class="form-group">
        <asp:Label ID="Label1" runat="server" Text="Product Name: " />
        <asp:TextBox ID="txtPName" runat="server" CssClass='form-control' />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtPName" ForeColor="Red" ErrorMessage="Product Name is a required field." />
    </div>

    <div class="form-group">
        <asp:Label runat="server" AssociatedControlID="CategoryListDropDown" Text="Category" />
        <asp:DropDownList ID='CategoryListDropDown' AppendDataBoundItems='true' runat='server' CssClass='form-control'>
        </asp:DropDownList>
    </div>

    <div class="form-group">
        <asp:Label ID="Label2" runat="server" Text="Short Description: " />
        <asp:TextBox ID="txtShrtDescription" runat="server" CssClass='form-control' />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPName" ForeColor="Red" ErrorMessage="Short Description is a required field." />
    </div>

    <div class="form-group">
        <asp:Label ID="Label6" runat="server" Text="Long Description: " />
        <asp:TextBox ID="txtLongDescription" TextMode="MultiLine" Columns="2500" Rows="10" runat="server" />
        <ajaxToolkit:HtmlEditorExtender ID="hee" TargetControlID="txtLongDescription" runat="server" />
    </div>

    <div class="form-group">
        <asp:Label ID="Label3" runat="server" Text="Price: " />
        <asp:TextBox ID="txtPrice" runat="server" CssClass='form-control' />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtPrice" ForeColor="Red" ErrorMessage="Price is a required field." />
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="txtPrice" runat="server" ForeColor="Red" ErrorMessage="Must be in the format 0.00" ValidationExpression="^[$]?([0-9]{1,2})?,?([0-9]{3})?,?([0-9]{3})?(\.[0-9]{2})?[$]?$"></asp:RegularExpressionValidator>
    </div>

    <div class="form-group">
        <asp:Label ID="Label5" runat="server" Text="On Sale: " />
        <asp:CheckBox ID="chkSale" runat="server" />
    </div>

    <div class="form-group">
        <asp:Label ID="Label4" runat="server" Text="Sale Price: " />
        <asp:TextBox ID="txtSPrice" runat="server" CssClass='form-control' />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtSPrice" ForeColor="Red" ErrorMessage="Sale Price is a required field." />
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" ControlToValidate="txtSPrice" runat="server" ForeColor="Red" ErrorMessage="Must be in the format 0.00" ValidationExpression="^[$]?([0-9]{1,2})?,?([0-9]{3})?,?([0-9]{3})?(\.[0-9]{2})?[$]?$"></asp:RegularExpressionValidator>
    </div>

    <div class="form-group">
        <asp:Label ID="Label7" runat="server" Text="Product Image: " />
        <asp:FileUpload ID="fileUpload" runat="server" />
    </div>

    <div class="form-group">
        <asp:Button runat="server" OnClick="CreateProduct_Click" Text="Create" CssClass="btn btn-default" />
        <a runat="server" href="~/Admin/Default" class="btn btn-default">Back to Admin</a>
    </div>

</asp:Content>
