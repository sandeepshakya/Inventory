<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SystemAdminLogin.aspx.cs"
    Inherits="FORMS_System_Admin_SystemAdminLogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>System Admin Login-IMS</title>
    <link href="../../CSS/style.css" type="text/css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <table width="100%" height="600" cellpadding="0" cellspacing="0">
            <tr>
                <td>
                    &nbsp;<table align="center" style="border-right: #cc0066 thin solid; border-top: #cc0066 thin solid;
                        border-left: #cc0066 thin solid; border-bottom: #cc0066 thin solid">
                        <tr>
                            <td colspan="2">
                            <asp:Label ID="Label1" runat="server" BorderStyle="None" Font-Bold="True" Font-Names="Lucida Fax"
                                Font-Size="Medium" Font-Underline="False" ForeColor="Black" Text="Welcome System Admin"
                                Width="230px"></asp:Label></td>
                        </tr>
                        <tr>
                            <td style="height: 29px">
                                <asp:Label ID="Label2" runat="server" Text="Username" BorderStyle="None" Font-Bold="True"
                                    Font-Names="Lucida Fax" Font-Size="Small" Font-Underline="False" ForeColor="Maroon"
                                    Width="100px"></asp:Label>
                            </td>
                            <td style="height: 29px">
                                <asp:TextBox ID="txtUserName" runat="server" Font-Bold="True" Font-Names="Georgia"
                                    Font-Size="Small" ForeColor="Black" Width="150px"></asp:TextBox>
                            </td>
                            <td style="height: 29px">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*"
                                    ControlToValidate="txtUserName" SetFocusOnError="True"></asp:RequiredFieldValidator></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label3" runat="server" Text="Password" BorderStyle="None" Font-Bold="True"
                                    Font-Names="Lucida Fax" Font-Size="Small" Font-Underline="False" ForeColor="Maroon"
                                    Width="100px"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtPassword" runat="server" Font-Size="Small" ForeColor="Blue"
                                    TextMode="Password" Width="150px" Font-Names="Georgia"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*"
                                    ControlToValidate="txtPassword"></asp:RequiredFieldValidator></td>
                        </tr>
                        <tr>
                            <td>
                            </td>
                            <td>
                                <br />
                                <asp:ImageButton ID="btnLogin" runat="server" ImageUrl="~/CSS/img/login_button_01.jpg"
                                    Width="80px" ImageAlign="Middle" OnClick="btnLogin_Click" />&nbsp;<br />
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="lblError" runat="server" ForeColor="Red" Font-Names="Times New Roman"
                                    Font-Size="Large"></asp:Label></td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
