<%@ Page Language="C#" MasterPageFile="~/InventoryChild.Master"
    AutoEventWireup="true" CodeFile="EditValue.aspx.cs" Inherits="FORMS_Admin_Forms_Item_value_EditValue"
    Title="Edit Value" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <div class="content-wrapper">
        <!-- Content Header (Page header) -->
        <section class="content-header">
            <h1>Edit Value
        <small>Optional description</small>
            </h1>
            <ol class="breadcrumb">
                <li><a href="#"><i class="fa fa-dashboard"></i>Level</a></li>
                <li class="active">Here</li>
            </ol>
        </section>

        <!-- Main content -->
        <section class="content">
    <table width="100%" height="600" border="1">
        <tr height="50">
            <td width="25%" align="right" bgcolor="#ccccff" colspan="3">
            </td>
            <tr>
                <td width="80%" style="vertical-align: top; text-align: center">
                    <div style="text-align: center">
                        <br />
                        <table>
                            <tr height="50">
                                <td width="25%" align="right" bgcolor="#ccccff" colspan="3">
                                </td>
                                <tr>
                                    <td align="center" style="width: 100px" valign="top">
                                        <asp:Label ID="Label1" runat="server" Font-Names="Verdana" Font-Size="Small" Text="Product Name"></asp:Label></td>
                                    <td align="center" style="width: 100px" valign="top">
                                        <asp:DropDownList ID="DropDownList1" runat="server" Width="154px">
                                        </asp:DropDownList></td>
                                    <td align="center" style="width: 100px" valign="top">
                                    </td>
                                </tr>
                            <tr>
                                <td align="center" style="width: 100px" valign="top">
                                    <asp:Label ID="Label2" runat="server" Font-Names="Verdana" Font-Size="Small" Text="Attribute Name"
                                        Width="105px"></asp:Label></td>
                                <td align="center" style="width: 100px" valign="top">
                                    <asp:DropDownList ID="DropDownList2" runat="server" Width="154px">
                                    </asp:DropDownList></td>
                                <td align="center" style="width: 100px" valign="top">
                                </td>
                            </tr>
                            <tr>
                                <td align="center" style="width: 100px" valign="top">
                                    <asp:Label ID="Label3" runat="server" Font-Names="Verdana" Font-Size="Small" Text="Edit Attribute"></asp:Label></td>
                                <td align="center" style="width: 100px" valign="top">
                                    <input id="Text1" type="text" /></td>
                                <td align="center" style="width: 100px" valign="top">
                                    <input id="Submit1" type="submit" value="Update" /></td>
                            </tr>
                        </table>
                    </div>
                </td>
            </tr>
    </table>
            </section>
        </div>
</asp:Content>
