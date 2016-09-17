<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="Inventory.FORMS.Admin_Forms.Item.Attribute.Add" 
     MasterPageFile="~/Site.Master"%>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <table width="100%" height="600" style="font-size: medium" border="0">
        <tr>
            <td width="80%" style="vertical-align: ceter; height: 594px;">
                <table width="50%" height="200" cellspacing="0" style="font-size: 10pt; border-right: gainsboro thin solid; border-top: gainsboro thin solid; border-left: gainsboro thin solid; border-bottom: gainsboro thin solid;" align ="center">
                    <tr>
                        <td colspan="2" style="background-color: gainsboro" height="25">
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 35px; width: 30%; text-align: right;">
                            <asp:Label ID="Label2" runat="server" Style="position: relative" Text="Select Product"
                                Width="296px"></asp:Label></td>
                        <td style="height: 25px" width="25%">

                            <asp:DropDownList ID="ddlProduct" runat="server"></asp:DropDownList>
                             <asp:RequiredFieldValidator ID="rqFldDDl" runat="server" ControlToValidate="ddlProduct" InitialValue="0" ForeColor="Tomato" ErrorMessage="*">

                            </asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 35px; width: 30%; text-align: right;">
                            <asp:Label ID="Label1" runat="server" Style="position: relative" Text="Attribute Name"
                                Width="296px"></asp:Label></td>
                        <td style="height: 25px" width="25%">
                            <input type="text" id="txtAttributeName" runat="server" style="width: 184px" />
                            <asp:RequiredFieldValidator ID="rqFAttName" runat="server" ControlToValidate="txtAttributeName" ForeColor="Tomato" ErrorMessage="*">

                            </asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 25px; width: 25%;">
                        </td>
                        <td style="height: 25px" width="25%">
                            <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Save" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" style="background-color: white" height="25">
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
