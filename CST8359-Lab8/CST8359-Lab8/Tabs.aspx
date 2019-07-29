<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Tabs.aspx.cs" Inherits="CST8359_Lab8.Tabs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Tabs</h3>

    <ajaxToolkit:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="1">
        <ajaxToolkit:TabPanel runat="server" HeaderText="HTML Editor" ID="TabPanel1">
            <ContentTemplate>
                <asp:TextBox
                    ID="txtComments"
                    TextMode="MultiLine"
                    Columns="1500"
                    Rows="25"
                    runat="server" />

                <ajaxToolkit:HtmlEditorExtender
                    ID="hee"
                    TargetControlID="txtComments"
                    runat="server" />


                <asp:Button
                    ID="btnHSubmit"
                    Text="Submit"
                    runat="server" OnClick="btnHSubmit_Click" />


                <hr />

                <asp:Label
                    ID="lblComment"
                    runat="server" />
            </ContentTemplate>
        </ajaxToolkit:TabPanel>
        <ajaxToolkit:TabPanel ID="TabPanel2" runat="server" HeaderText="Fancy Form">
            <ContentTemplate>
                <h3>Fancy Form</h3>
                <hr />
                <p>Phone Number:</p>
                <asp:TextBox
                    ID="txtPnumber"
                    runat="server" />
                <asp:RequiredFieldValidator ID="Req1" runat="server" Display="None" ControlToValidate="txtPnumber" ErrorMessage="Phone Number is required." ToolTip="Phone Number is required." Text="Required" />
                <ajaxToolkit:ValidatorCalloutExtender PopupPosition="BottomLeft" runat="server" TargetControlID="Req1" ID="Validator1" />
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
                <ajaxToolkit:ValidatorCalloutExtender PopupPosition="BottomLeft" runat="server" TargetControlID="RequiredFieldValidator1" ID="ValidatorCalloutExtender1" />
                <ajaxToolkit:CalendarExtender ID="txtCalendar_CalendarExtender" runat="server" BehaviorID="txtCalendar_CalendarExtender" TargetControlID="txtCalendar" />
                <br />
                <br />
                <asp:Button
                    ID="btnFSubmit"
                    Text="Submit"
                    runat="server"
                    OnClick="btnFSubmit_Click" />

                <ajaxToolkit:ConfirmButtonExtender ID="btnSubmit_ConfirmButtonExtender" runat="server" TargetControlID="btnFSubmit" ConfirmText="Are You Sure?" />


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
            </ContentTemplate>
        </ajaxToolkit:TabPanel>
    </ajaxToolkit:TabContainer>
</asp:Content>
