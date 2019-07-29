<%@ Page Title="Cookie" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cookie.aspx.cs" Inherits="CST8359_Lab6.Cookie" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Cookie Display</h2>
    <hr />
    <div class="form-group">
        <asp:Label ID="Label1" runat="server" class="control-label col-md-2" Text="First Name: " />
        <div class="col-md-10">
            <asp:TextBox ID="txtFName" runat="server" class="form-control" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" class="text-danger" ControlToValidate="txtFName" ForeColor="Red" ErrorMessage="First Name is a required field." />
        </div>
    </div>

    <div class="form-group">
        <asp:Label ID="Label2" runat="server" class="control-label col-md-2" Text="Last Name: "></asp:Label>
        <div class="col-md-10">
            <asp:TextBox ID="txtLName" runat="server" class="form-control" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" class="text-danger" ControlToValidate="txtLName" ForeColor="Red" ErrorMessage="Last Name is a required field." />
        </div>
    </div>
    <div class="form-group">
        <asp:Label ID="Label4" runat="server" class="control-label col-md-2" Text="Day of Week: "></asp:Label>
        <div class="col-md-10">
            <asp:Calendar ID="Calendar1" runat="server" />
        </div>
    </div>
    <div class="form-group">
        <asp:Label ID="Label7" runat="server" class="control-label col-md-2" Text="Email Address: "></asp:Label>
        <div class="col-md-10">
            <asp:TextBox ID="txtEmail" runat="server" class="form-control" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" class="text-danger" ControlToValidate="txtEmail" ForeColor="Red" ErrorMessage="Email is a required field." />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" class="text-danger" ControlToValidate="txtEmail" runat="server" ForeColor="Red" ErrorMessage="Must be in the format blah@blah.com" ValidationExpression="^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"></asp:RegularExpressionValidator>
        </div>
    </div>

    <div class="form-group">
        <div class="col-md-offset-2 col-md-10">
            <asp:Button ID="Button1" runat="server" class="btn btn-default" Text="Pass to CookieDisplay" OnClick="button1_click" />
        </div>
    </div>
    <hr />
</asp:Content>
