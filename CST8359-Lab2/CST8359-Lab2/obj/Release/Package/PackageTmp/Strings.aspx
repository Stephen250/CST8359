<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Strings.aspx.cs" Inherits="CST8359_Lab2.Strings" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            <asp:HyperLink 
            ID="HyperLink1" 
            runat="server"
            Text="Manual"
            NavigateUrl="~/Manual.aspx"
            ></asp:HyperLink>
            <asp:HyperLink 
            ID="HyperLink2" 
            runat="server"
            Text="Default"
            NavigateUrl="~/Default.aspx"
            ></asp:HyperLink>
        </div>
        <hr />
        <h1>Strings</h1>
        <h3>Input</h3>
        <br /><br />
    <asp:TextBox id="inputTextBox" TextMode="multiline" width="450px" height="75px" runat="server" />
        <br /><br />
    <asp:Button id="inputButton" Text="Transform User Text" runat="server" OnClick="inputButton_Click"/>
        <br /><br />
        <h3>Output</h3>
        <br /><br />
    <asp:Literal runat="server" ID="outputLiteral"/>
    </div>
    </form>
</body>
</html>
