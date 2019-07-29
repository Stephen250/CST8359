<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lab7Task3._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h1>TweetService</h1>

    <hr />
    <div class="row">
        <div class="col-md-12">
            <asp:TextBox ID="TextBox1" runat="server" Height="50px" Width="100%"></asp:TextBox>
        </div>
    </div>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Tweet" OnClick="btnTweet_Click" />

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Label ID="Label1" runat="server" Text="Panel not refreshed yet"></asp:Label>
            <asp:Timer ID="Timer1" runat="server" Interval="5000" OnTick="Timer1_Tick">
            </asp:Timer>
        </ContentTemplate>
    </asp:UpdatePanel>

    <hr />

    <asp:GridView ID="GridView1" runat="server" AutoSizeColumnsMode="true" EmptyDataText="Currently, there are no Tweets to display." CellPadding="4" ForeColor="#333333" GridLines="Both">
    </asp:GridView>

</asp:Content>
