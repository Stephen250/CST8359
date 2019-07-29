<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CST8359_Lab4.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Output Files</h3><br />
    <br />

    <asp:GridView ID="GridView1" runat="server" AutoSizeColumnsMode="true" EmptyDataText="Currently, there are no files to display." OnRowDeleting="OnRowDeleting" CellPadding="4" ForeColor="#333333" GridLines="Both">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ButtonType="Button" />
        </Columns>
    </asp:GridView>
    <br />
    <h3>Options</h3><br />
    <br />
    <asp:Button ID="btnFirst" runat="server" OnClick="btnFirst_Click" Text="Get First" />
    <br />
    <br />
    <asp:Button ID="btnLast" runat="server" OnClick="btnLast_Click" Text="Get Last" />
    <br />
    <br />
    <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear Results" />
    <br />
    <br />
    <asp:Button ID="btnRescan" runat="server" OnClick="btnRescan_Click" Text="Rescan" />

</asp:Content>
