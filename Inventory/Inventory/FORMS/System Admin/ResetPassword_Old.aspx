<%@ Page Language="C#" MasterPageFile="~/FORMS/Master Page/SystemAdminMaster/MasterPage.master"
    AutoEventWireup="true" CodeFile="ResetPassword.aspx.cs" Inherits="FORMS_System_Admin_ResetPassword"
    Title="My Account" %>

<%@ MasterType VirtualPath="~/FORMS/Master Page/SystemAdminMaster/MasterPage.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table width="100%" height="632" cellspacing="5">
        <tr valign="baseline">
            <td align="center" style="text-align: left" width="50%">
                <br />
                <br />
                <table height="300" width="50%" style="border-right: #cc9966 thin solid; border-top: #cc9966 thin solid;
                    border-left: #cc9966 thin solid; border-bottom: #cc9966 thin solid" cellspacing="10">
                    <tr valign="bottom">
                        <td align="center" colspan="2" bgcolor="#6f1e0d">
                            <asp:Label ID="Label1" runat="server" Text="Reset Password" Font-Names="Verdana"
                                Font-Size="Small" ForeColor="WhiteSmoke" Font-Underline="True"></asp:Label>
                        </td>
                    </tr>
                    <tr width=100%>
                        <td align="center" style="width: 100%">
                            <asp:Label ID="Label5" runat="server" Font-Names="Verdana" Font-Size="Small" ForeColor="Red"
                                Text="* Required Field" Width="122px"></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="text-align: right; width: 100%;">
                            <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="Verdana" Font-Size="Small"
                                ForeColor="Red" Text="*"></asp:Label>
                            <asp:Label ID="lblUserName" runat="server" Font-Names="Verdana" Font-Size="Small"
                                Text="User Name" ForeColor="WhiteSmoke"></asp:Label></td>
                        <td style="text-align: left; width: 25%;">
                            <asp:TextBox ID="txtUserName" runat="server" Width="130px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserName"
                                ErrorMessage="Require User Name" Display="Dynamic" Text="*" Font-Names="Verdana" Font-Size="Small"></asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td style="text-align: right; width: 100%; height: 33px;">
                            <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Names="Verdana" Font-Size="Small"
                                ForeColor="Red" Text="*"></asp:Label>
                            <asp:Label ID="lblNewPassword" runat="server" Font-Names="Verdana" Font-Size="Small"
                                Text="New Password" ForeColor="WhiteSmoke"></asp:Label></td>
                        <td style="text-align: left; width: 25%; height: 33px;">
                            <asp:TextBox ID="txtNewPassword" runat="server" TextMode="Password" Width="130px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtNewPassword"
                                ErrorMessage="Require Password" Display="Dynamic" Text="*" Font-Names="Verdana" Font-Size="Small"></asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td style="text-align: right; width: 100%;">
                            <asp:Label ID="Label6" runat="server" ForeColor="Red" Style="left: -104px; position: static;
                                top: 22px" Text="*"></asp:Label>&nbsp;
                            <asp:Label ID="Label2" runat="server" Font-Names="Verdana" Font-Size="Small" Text="Confirm Password"
                                Width="102px" ForeColor="WhiteSmoke"></asp:Label></td>
                        <td style="text-align: left; width: 25%;" align="left">
                            <asp:TextBox ID="txtConfirmNewPassword" runat="server" TextMode="Password" Width="130px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtConfirmNewPassword"
                                ErrorMessage="Require Confirm Password" Display="Dynamic" Text="*" Font-Names="Verdana" Font-Size="Small" Style="position: relative"></asp:RequiredFieldValidator>
                            <asp:CompareValidator ID="CompareValidator2" runat="server" ErrorMessage="New and Confirm Passwords Are Not Same" Display="Dynamic" Text="*" Style="position: relative" ControlToCompare="txtNewPassword" ControlToValidate="txtConfirmNewPassword"></asp:CompareValidator></td>
                    </tr>
                    <tr>
                        <td style="text-align: left; width: 100%;" align="center">
                            <asp:Label ID="lblMessage" runat="server" Font-Names="Verdana" Font-Size="Small"
                                ForeColor="Red"></asp:Label>
                        </td>
                        <td width="25%">
                            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtNewPassword"
                                ControlToValidate="txtConfirmNewPassword" EnableViewState="False" ErrorMessage="Password Mismached!!"
                                Font-Names="Verdana" Font-Size="Small" Width="184px"></asp:CompareValidator></td>
                    </tr>
                    <tr>
                        <td style="text-align: center" colspan="2">
                            <asp:Button ID="btnResetPassword" runat="server" Text="Reset Password" OnClick="btnResetPassword_Click" /></td>
                    </tr>
                </table>
            </td>
            <td width="50%" style="text-align: left">
             <br />
                <br />
                <table width="60%" height ="300" style="border-right: #cc9966 thin solid; border-top: #cc9966 thin solid;
                    border-left: #cc9966 thin solid; border-bottom: #cc9966 thin solid" align=left>
                    <tr>
                        <td style="text-align: left; vertical-align: top;" > 
                            <asp:ValidationSummary ID="ValidationSummary1" runat="server" Style="position: relative" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
