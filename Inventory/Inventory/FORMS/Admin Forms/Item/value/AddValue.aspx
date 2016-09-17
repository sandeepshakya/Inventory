<%@ Page Language="C#" MasterPageFile="~/InventoryChild.Master"
    AutoEventWireup="true" CodeFile="AddValue.aspx.cs" Inherits="FORMS_Admin_Forms_Item_value_AddValue"
    Title="Add Value" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
     <div class="content-wrapper">
        <!-- Content Header (Page header) -->
        <section class="content-header">
            <h1>Add Value
        <small>Optional description</small>
            </h1>
            <ol class="breadcrumb">
                <li><a href="#"><i class="fa fa-dashboard"></i>Level</a></li>
                <li class="active">Here</li>
            </ol>
        </section>

        <!-- Main content -->
        <section class="content">
    <table border="0" width="100%">
        <tr style="height: 50px;">
            <td bgcolor="#ccccff" style="background-color: gainsboro">
            </td>
        </tr>
    </table>
    <table width="100%" height="600" border="1">
        <tr>
            <td width="80%" style="vertical-align: top; text-align: center" valign="middle" >
                <div style="text-align: center">
                    <br />
                    <br />
                    <table border="0" bordercolor="#ccccff" width="25%" align="center">
                        <tr height="50">
                            <td width="25%" bgcolor="#ccccff" colspan="3" valign="middle" style="background-color: gainsboro" >
                            </td>
                            <tr>
                                <td style="width: 100px" valign="middle" >
                                    <asp:Label ID="Label1" runat="server" Font-Names="Verdana" Font-Size="Small" Text="Product Name">
                                    </asp:Label></td>
                                <td style="width: 100px" valign="middle" >
                                    <asp:DropDownList ID="DropDownList1" runat="server" Width="152px">
                                    </asp:DropDownList></td>
                                <td style="width: 100px" valign="middle" >
                                </td>
                            </tr>
                        <tr>
                            <td style="width: 100px; height: 12px;" valign="middle">
                                <asp:Label ID="Label2" runat="server" Font-Names="Verdana" Font-Size="Small" Text="Arrtibute Name"></asp:Label></td>
                            <td style="width: 100px; height: 12px;" valign="middle">
                                <asp:DropDownList ID="DropDownList2" runat="server" Width="154px">
                                </asp:DropDownList></td>
                            <td style="width: 100px; height: 12px;" valign="middle">
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 100px" valign="middle">
                                <asp:Label ID="Label3" runat="server" Font-Names="Verdana" Font-Size="Small" Text="AttriBute Value"
                                    Width="103px"></asp:Label></td>
                            <td style="width: 100px" valign="middle">
                                <input id="Text1" type="text" /></td>
                            <td style="width: 100px" valign="middle">
                                <input id="Submit1" type="submit" value="Add" style="width: 54px" /></td>
                        </tr>
                    </table>
                </div>
         <br />
                <br />
                                </td>
        </tr>
    </table>
            </section>
         </div>
</asp:Content>
