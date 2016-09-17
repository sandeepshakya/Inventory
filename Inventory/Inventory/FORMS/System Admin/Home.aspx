<%@ Page Language="C#" MasterPageFile="~/InventoryChild.Master" AutoEventWireup="true"
    CodeFile="Home.aspx.cs" Inherits="Default2" Title="System Admin Home" %>
    <%@ MasterType VirtualPath="~/InventoryChild.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <div class="content-wrapper">
        <!-- Content Header (Page header) -->
        <section class="content-header">
            <h1>Home
        <small>Optional description</small>
            </h1>
            <ol class="breadcrumb">
                <li><a href="#"><i class="fa fa-dashboard"></i>Level</a></li>
                <li class="active">Here</li>
            </ol>
        </section>

        <!-- Main content -->
        <section class="content">
    <table width="100%" height="632" cellspacing="5">
      
        <tr>
            <td style="vertical-align: top; text-align: left; color: #ffffff;" colspan="2">
               <table>
                    <tr>
                        <td colspan="2">
                <asp:Label ID="Label1" runat="server" Text="Company" Font-Size="Medium" ForeColor="IndianRed"></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="width: 100px; text-align: center">
                <asp:ImageButton ID="imgbtnRegComp" runat="server" ImageUrl="~/CSS/SysAdminCss/SysAdminImg/1368206652.png"
                    Height="48px" Width="48px" ImageAlign="AbsMiddle" OnClick="imgbtnRegComp_Click" /></td>
                        <td style="width: 100px; text-align: center">
                <asp:ImageButton ID="imgbtnMngComp" runat="server" Height="50px" ImageAlign="AbsMiddle"
                    ImageUrl="~/CSS/SysAdminCss/SysAdminImg/csi.jpg" Width="50px" OnClick="imgbtnMngComp_Click" /></td>
                    </tr>
                    <tr>
                        <td style="width: 100px">
                <asp:LinkButton ID="lnkbtnRegComp" runat="server" Font-Size="Small" ForeColor="WhiteSmoke" OnClick="lnkbtnRegComp_Click" Font-Underline="False" Width="120px" >Create Company</asp:LinkButton></td>
                        <td style="width: 100px">
                <asp:LinkButton ID="lnkbtnMngComp" runat="server" Font-Size="Small" ForeColor="WhiteSmoke" OnClick="lnkbtnMngComp_Click" Font-Underline="False" Width="120px">Manage Company</asp:LinkButton></td>
                    </tr>
                    <tr>
                        <td style="width: 100px">
                        </td>
                        <td style="width: 100px">
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                <asp:Label ID="Label2" runat="server" Font-Size="Medium" ForeColor="IndianRed" Text="User"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="1" style="text-align: center">
                <asp:ImageButton ID="imgbtnMngUser" runat="server" ImageUrl="~/CSS/SysAdminCss/SysAdminImg/Admin.PNG"
                    Height="48px" Width="48px" ImageAlign="AbsMiddle" OnClick="imgbtnMngUser_Click" /></td>
                        <td colspan="2" style="text-align: left">
                        </td>
                    </tr>
                    <tr>
                        <td colspan="1" rowspan="2" style="text-align: center">
                <asp:LinkButton ID="lnkbtnMngUser" runat="server" Font-Size="Small" ForeColor="WhiteSmoke" OnClick="lnkbtnMngUser_Click" Font-Underline="False">Manage User</asp:LinkButton></td>
                        <td colspan="2" rowspan="2" style="text-align: left">
                        </td>
                    </tr>
                    
                </table>
                <asp:Panel ID="Panel1" runat="server" style="position:relative; left: 564px; top: -210px; font-size: 10pt; font-family: Verdana;" Width="500px" BorderColor="#CC6633" BorderWidth="1px">
                    Inventory Management System is a system that performs the functions of Purchases,
                    Sales and payments. This system will guide through creation of vendors list, purchase
                    orders, products list, receiving lists, sales orders, invoices, and sale and payment
                    receipts. Work orders for creation inventory assemblies, customers and vendors balances
                    and various types of reports for monitoring your business.Inventory Management System
                    works as single application as client server system and as distribution database
                    system.</asp:Panel>
           
               </td>
        </tr>
    </table>
            </section>
            </div>
</asp:Content>
