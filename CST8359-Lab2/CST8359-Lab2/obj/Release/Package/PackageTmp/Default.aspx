<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CST8359_Lab2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
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
            Text="Strings"
            NavigateUrl="~/Strings.aspx"
            ></asp:HyperLink>
        </div>
        <hr />
        <div>
            <h1>Hello World!</h1>
            <h2>Stephen (Andy) Thacker</h2>
            <h2>040 768 337</h2>
            <p>I hope to expand my knowledge on C# and ASP.net in order to create more ehanced applications.</p>
        </div>
        
    </form>
</body>
</html>
