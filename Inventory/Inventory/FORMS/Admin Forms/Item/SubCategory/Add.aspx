<%@ Page Language="C#" MasterPageFile="~/FORMS/Master Page/AdminMaster/AdminMaster.master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="Inventory.FORMS.Admin_Forms.Item.SubCategory.SubCategory" %>

<%@ MasterType VirtualPath ="~/FORMS/Master Page/AdminMaster/AdminMaster.master" %> 
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table width="100%" height="600" style="font-size: medium" border="0">
        <tr>
            <td width="80%">
                <table align ="center" width="50%" height="200"  style="font-size: 10pt; border-right: gainsboro thin solid; border-top: gainsboro thin solid; border-left: gainsboro thin solid; border-bottom: gainsboro thin solid;" cellspacing="0">
                    <tr>
                        <td colspan="2" height ="25" style="text-align: right; border-right: #ccccff thin solid; border-top: #ccccff thin solid; border-left: #ccccff thin solid; border-bottom: #ccccff thin solid; background-color: gainsboro;">
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align: center" width="30%">
                            <asp:Label ID="lblCategoryName" runat="server" Style="position: relative" Text="Select Category"
                                Font-Names="Verdana" Font-Size="Small" Width="175px"></asp:Label></td>
                        <td width="30%">
                            <asp:DropDownList ID="ddlCategory" runat="server"></asp:DropDownList>
                            <asp:RequiredFieldValidator runat="server" ForeColor="Tomato" ID="rqfldName" ErrorMessage="*" InitialValue="0" ControlToValidate="ddlCategory"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align: center" width="30%">
                            <asp:Label ID="lblSubCat" runat="server" Style="position: relative" Text="Sub Category"
                                Font-Names="Verdana" Font-Size="Small" Width="175px"></asp:Label></td>
                        <td width="30%">
                            <input type="text" runat="server" id="txtSubCat" />
                            <asp:RequiredFieldValidator runat="server" ForeColor="Tomato" ID="rqSubCat" ErrorMessage="*" ControlToValidate="txtSubCat"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                        </td>
                        <td>
                             <asp:Button ID="btnSave" OnClick="btnSave_Click" runat="server" Style="position: relative" Text="Submit" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                        </td>
                        <td>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>