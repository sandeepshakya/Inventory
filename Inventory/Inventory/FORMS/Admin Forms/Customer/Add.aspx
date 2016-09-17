<%@ Page Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true" CodeFile="Add.aspx.cs" Inherits="AddCustomer"
    Title="Add Customer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <table width="100%" height="600" border="0" cellpadding="0" cellspacing="0">
        <tr>
            <td width="90%" valign=baseline>
                <table width="100%" height="400px" cellpadding="0" cellspacing="20" border="0" style="border-right: #cccccc thin solid;
                    border-top: #cccccc thin solid; border-left: #cccccc thin solid; border-bottom: #cccccc thin solid">
                    <tr style="height: 50px;">
                        <td bgcolor="gainsboro" style="height: 12px" colspan="3" align="left">
                            Add Customer</td>
                    </tr>
                    <tr>
                        <td width="25%" align="right">
                            <asp:Label ID="lblCustomerName" runat="server" Style="position: relative" Text="Customer Name"
                                Font-Size="Small" Font-Names="Verdana"></asp:Label>
                        </td>
                        <td width="25%" align="left">
                            <input type="text" id="txtCustomerName" />
                        </td>
                        <td width="25%" align="right">
                        </td>
                    </tr>
                    <tr>
                        <td width="25%" align="right">
                            <asp:Label ID="lblCustomerOfficeNo" runat="server" Style="position: relative" Text="Customer Office No"
                                Font-Size="Small" Font-Names="Verdana"></asp:Label></td>
                        <td width="25%" align="left">
                            <input type="text" id="txtCustomerOfficeNo" />
                        </td>
                        <td width="25%" align="right">
                        </td>
                    </tr>
                    <tr>
                        <td width="25%" align="right">
                            <asp:Label ID="lblCustomermobileno" runat="server" Style="position: relative" Text="Customer Mobile No"
                                Font-Size="Small" Font-Names="Verdana"></asp:Label></td>
                        <td width="25%" align="left">
                            <input type="text" id="txtCustomerMobileNo" />
                        </td>
                        <td width="25%" align="right">
                        </td>
                    </tr>
                    <tr>
                        <td width="25%" align="right">
                            <asp:Label ID="lblShippingAdd" runat="server" Style="position: relative" Text="Shipping Address"
                                Font-Size="Small" Font-Names="Verdana"></asp:Label></td>
                        <td width="25%" align="left">
                            <input type="text" id="txtShippingAddress" style="width: 168px; height: 48px" />
                        </td>
                        <td width="25%">
                        </td>
                    </tr>
                    <tr>
                        <td width="25%" align="right">
                            <asp:Label ID="lblBillingAdd" runat="server" Style="position: relative" Text="Billing Address"
                                Font-Size="Small" Font-Names="Verdana"></asp:Label></td>
                        <td width="25%" align="left">
                            <input type="text" id="txtbillingAddress" style="width: 168px; height: 48px" />
                        </td>
                        <td width="25%">
                        </td>
                    </tr>
                    <tr>
                        <td width="25%" align="right">
                            <asp:Label ID="lblCustomerCity" runat="server" Style="position: relative" Text="Customer City"
                                Font-Size="Small" Font-Names="Verdana"></asp:Label></td>
                        <td width="25%" align="left">
                            <input type="text" id="txtCustomerCity" />
                        </td>
                        <td width="25%">
                        </td>
                    </tr>
                    <tr>
                        <td width="25%" align="right">
                            <asp:Label ID="lblCustomerFax" runat="server" Style="position: relative" Text="Customer Fax"
                                Font-Size="Small" Font-Names="Verdana"></asp:Label></td>
                        <td width="25%" align="left">
                            <input type="text" id="txtCustomerFax" />
                        </td>
                        <td width="25%">
                        </td>
                    </tr>
                    <tr>
                        <td width="25%" align="right">
                            <asp:Label ID="lblCustomerEmail" runat="server" Style="position: relative" Text="Customer Email"
                                Font-Size="Small" Font-Names="Verdana"></asp:Label></td>
                        <td width="25%" align="left">
                            <input type="text" id="txtCustomerEmail" />
                        </td>
                        <td width="25%">
                        </td>
                    </tr>
                    <tr>
                        <td width="25%" align="right">
                            <asp:Label ID="lblCustomerWebsite" runat="server" Style="position: relative" Text="Customer Website"
                                Font-Size="Small" Font-Names="Verdana"></asp:Label></td>
                        <td width="25%" align="left">
                            <input type="text" id="txtCustomerWebsite" />
                        </td>
                        <td width="25%">
                        </td>
                    </tr>
                    <tr>
                        <td width="25%" align="right">
                        </td>
                        <td width="25%" align="left">
                            &nbsp;<input type="button" id="btnSubmit" style="width: 88px" value="Add" onclick="return btnSubmit_onclick()" onserverclick="btnSubmit_ServerClick" runat="server" /></td>
                        <td width="25%">
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
