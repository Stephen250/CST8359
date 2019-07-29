<%@ Page Title="Fancy Form" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FancyForm.aspx.cs" Inherits="CST8359_Lab8.FancyForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h3>Fancy Form</h3>
    <hr />
    <p>Phone Number:</p>
    <asp:TextBox
        ID="txtPnumber"
        runat="server" />
    <asp:RequiredFieldValidator ID="Req1" runat="server" Display="None" ControlToValidate="txtPnumber" ErrorMessage="Phone Number is required." ToolTip="Phone Number is required." Text="Required" />
    <ajaxToolKit:ValidatorCalloutExtender PopupPosition="BottomLeft" runat="server" TargetControlID="Req1" ID="Validator1" />
    <ajaxToolkit:FilteredTextBoxExtender ID="txtPnumber_FilteredTextBoxExtender" runat="server" FilterType="Numbers" TargetControlID="txtPnumber" />
    
                                
    <br />

    <p>Age</p>
    <asp:TextBox
        ID="txtAgeDisplay"
        runat="server" />

    <asp:TextBox
        ID="txtAge"
        runat="server" />

    <ajaxToolkit:SliderExtender ID="SliderExtender1" runat="server"
        TargetControlID="txtAge"
        Minimum="0"
        Maximum="100"
        BoundControlID="txtAgeDisplay"
        Steps="100" />

    <br />
    <p>Date Of Birth</p>
    <asp:TextBox
        ID="txtCalendar"
        runat="server" />

    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Display="None" ControlToValidate="txtCalendar" ErrorMessage="Date of Birth is required." ToolTip="Date of Birth is required." Text="Required" />
    <ajaxToolKit:ValidatorCalloutExtender PopupPosition="BottomLeft" runat="server" TargetControlID="RequiredFieldValidator1" ID="ValidatorCalloutExtender1" />
    <ajaxToolkit:CalendarExtender ID="txtCalendar_CalendarExtender" runat="server" BehaviorID="txtCalendar_CalendarExtender" TargetControlID="txtCalendar" />
    <br />
    <br />
    <asp:Button
        ID="btnSubmit"
        Text="Submit"
        runat="server"
        OnClick="btnSubmit_Click" />

    <ajaxToolkit:ConfirmButtonExtender ID="btnSubmit_ConfirmButtonExtender" runat="server" TargetControlID="btnSubmit" ConfirmText="Are You Sure?" />


    <hr />

    <asp:Label
        ID="lblPNumber"
        runat="server" />
    <br />
    <asp:Label
        ID="lblAge"
        runat="server" />
    <br />
    <asp:Label
        ID="lblDOB"
        runat="server" />
</asp:Content>
