<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CreateAccount.aspx.cs" Inherits="CST8359_Lab3.CreateAccount" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">

        function ValidateCheckBoxList(sender, args) {

            var checkBoxList = document.getElementById("<%=CheckBoxList1.ClientID %>");

            var checkboxes = checkBoxList.getElementsByTagName("input");

            var isValid = false;

            for (var i = 0; i < checkboxes.length; i++) {

                if (checkboxes[i].checked) {

                    isValid = true;

                    break;

                }

            }

            args.IsValid = isValid;

        }

    </script>
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <asp:Label ID="Label1" runat="server" Text="First Name: "></asp:Label>
    <asp:TextBox ID="txtFName" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFName" ForeColor="Red" ErrorMessage="First Name is a required field." />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Last Name: "></asp:Label>
    <asp:TextBox ID="txtLName" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLName" ForeColor="Red" ErrorMessage="Last Name is a required field." />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Student Number: "></asp:Label>
    <asp:TextBox ID="txtStuNum" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtStuNum" ForeColor="Red" ErrorMessage="Student Number is a required field." />
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="txtStuNum" runat="server"  ForeColor="Red" ErrorMessage="Must be in the format 000000000" ValidationExpression="\d{9}"></asp:RegularExpressionValidator>
    <br />
    <asp:Label ID="Label7" runat="server" Text="Email Address: "></asp:Label>
    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtEmail" ForeColor="Red" ErrorMessage="Email is a required field." />
    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" ControlToValidate="txtEmail" runat="server" ForeColor="Red" ErrorMessage="Must be in the format blah@blah.com" ValidationExpression="^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"></asp:RegularExpressionValidator>

    <br />
    <asp:Label ID="Label4" runat="server" Text="Date of Birth: "></asp:Label>
    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    <br />
    <asp:Label ID="Label5" runat="server" Text="Program of Study: "></asp:Label>
    <asp:TextBox ID="txtStudy" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ForeColor="Red" ControlToValidate="txtStudy" ErrorMessage="Program of Study is a required field." />
    <br />
    <asp:Label ID="Label6" runat="server" Text="Favourite Games: "></asp:Label>
    <asp:CheckBoxList ID="CheckBoxList1" runat="server">
        <asp:ListItem Text="NHL 15" />
        <asp:ListItem Text="Uncharted" />
        <asp:ListItem Text="Bioshock" />
    </asp:CheckBoxList>
    <asp:CustomValidator ID="CustomValidator1" ErrorMessage="Please select at least one item." ForeColor="Red" ClientValidationFunction="ValidateCheckBoxList" runat="server" />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Create Account" OnClick="button1_click" />
    <br />
    <br />

    <asp:Literal runat="server" ID="outputLiteral" />
</asp:Content>

