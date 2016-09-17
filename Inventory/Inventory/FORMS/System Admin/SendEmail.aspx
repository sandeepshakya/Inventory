<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SendEmail.aspx.cs" Inherits="Inventory.FORMS.System_Admin.SendEmail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Activate</title>
<script type="text/javascript">
    function ClosePopUp() {
        window.close();
        window.opener.location.href = "CompMgmt.aspx?txt=Registered ";

    }

</script>
</head>

<body>
    <form id="form1" runat="server">
        <table style="border-right: #cc3366 thin solid; border-top: #cc3366 thin solid; border-left: #cc3366 thin solid;
            border-bottom: #cc3366 thin solid; position: relative; left: 20px; top: 8px; text-align: right;" >
            <tr>
                <td align="left" valign="top">
                    <asp:Label ID="lblUserName" runat="server" Text="UserName" Font-Names="Verdana" Font-Size="10pt"></asp:Label>
                </td>
                <td align="left" valign="top">
                    <asp:TextBox ID="txtUserName" runat="server" Width="152px" Enabled="False" Font-Names="Verdana" Font-Size="10pt">Admin</asp:TextBox>
                </td>
                <td align="left" valign="top" width ="5%">
                </td>
            </tr>
            <tr>
                <td align="left" valign="top">
                    <asp:Label ID="lblPwd" runat="server" Text="Password" Font-Names="Verdana" Font-Size="10pt"></asp:Label>
                </td>
                <td align="left" valign="top">
                    <asp:TextBox ID="txtPassword" runat="server" Width="152px" Enabled="False" Font-Names="Verdana" Font-Size="10pt"></asp:TextBox>
                </td>
                <td align="left" valign="top">
                </td>
            </tr>
            <tr>
                <td align="left" valign="top" style="text-align:  left">
                    <asp:Label ID="lblLic" runat="server" Text="Licences" Font-Names="Verdana" Font-Size="10pt"></asp:Label>
                </td>
                <td align="left" valign="top">
                    <asp:TextBox ID="txtLic" runat="server" Width="152px" Font-Names="Verdana" Font-Size="10pt"></asp:TextBox>
                </td>
                <td align="left" valign="top">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtLic"
                        ErrorMessage="*" Style="position: relative"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td align="left" valign="top">
                </td>
                <td align="left" valign="top" style="text-align: left">
                    &nbsp;<asp:Button ID="btnSubmit" runat="server"
                        Text="Submit" OnClick="btnSubmit_Click" Font-Names="Verdana" Font-Size="10pt" style="position: relative" />
                    <input id="Button1"  style="font-size: 10pt; font-family: Verdana; position: relative;" type="button"
                        value="Close"  onclick="ClosePopUp()" /></td>
                <td align="left" valign="top">
                </td>
            </tr>
            <tr>
                <td align="left" valign="top" colspan="3">
                    &nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
