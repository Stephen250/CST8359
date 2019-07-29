<%@ Page Title="Bad Words" Language="C#" MasterPageFile="~/SiteAdminMenu.Master" AutoEventWireup="true" CodeBehind="BadWords.aspx.cs" Inherits="CST8359_Assignment2.Admin.BadWords" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h3>Add Bad Word</h3>
    <hr />
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>
    <div class="form-horizontal">
        <div class="row">
            <div class="col-md-6">
                <h4>Create a new Bad Word</h4>
            </div>
            <div class="col-md-6">
                <ol class="breadcrumb">
                    <li><a href="Default.aspx">Admin</a></li>
                    <li class="active">Bad Words</li>
                </ol>
            </div>
        </div>
        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="BadWord" CssClass="col-md-2 control-label">Bad Word:</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="BadWord" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="BadWord"
                    CssClass="text-danger" ErrorMessage="The Bad Word field is required." />
            </div>
        </div>
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" OnClick="CreateBad_Click" Text="Create" CssClass="btn btn-default" />
                <a runat="server" href="~/Admin/Default" class="btn btn-default">Back to Admin</a>
            </div>
        </div>
    </div>

</asp:Content>
