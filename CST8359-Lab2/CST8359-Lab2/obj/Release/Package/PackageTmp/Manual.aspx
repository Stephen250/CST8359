<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Manual.aspx.cs" Inherits="CST8359_Lab2.Manual" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <hr />
        <div>
            <asp:HyperLink
                ID="HyperLink1"
                runat="server"
                Text="Default"
                NavigateUrl="~/Default.aspx"></asp:HyperLink>
            <asp:HyperLink
                ID="HyperLink2"
                runat="server"
                Text="Strings"
                NavigateUrl="~/Strings.aspx"></asp:HyperLink>
        </div>
    </form>
</body>
</html>
