<%@ Page Language="C#" MasterPageFile="~/InventoryChild.Master" AutoEventWireup="true" CodeBehind="AdminManage.aspx.cs" Inherits="Inventory.FORMS.System_Admin.Admin_Manage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
    <%-- <link href="../../../CSS/SysAdminCss/GridViewStyle.css" type="text/css" rel="stylesheet" />--%>

    <script type="text/javascript">

        function check_uncheck(Val) {
            var ValChecked = Val.checked;
            var ValId = Val.id;
            var frm = document.forms[0];
            // Loop through all elements
            for (i = 0; i < frm.length; i++) {
                // Look for Header Template's Checkbox
                //As we have not other control other than checkbox we just check following statement
                if (this != null) {
                    if (ValId.indexOf('CheckAll') != -1) {
                        // Check if main checkbox is checked,
                        // then select or deselect datagrid checkboxes
                        if (ValChecked)
                            frm.elements[i].checked = true;
                        else
                            frm.elements[i].checked = false;
                    }
                    else if (ValId.indexOf('deleteRec') != -1) {
                        // Check if any of the checkboxes are not checked, and then uncheck top select all checkbox
                        if (frm.elements[i].checked == false)
                            frm.elements[1].checked = false;
                    }
                }
            }
        }

    </script>
    </asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <div class="content-wrapper">
        <!-- Content Header (Page header) -->
        <section class="content-header">
            <h1>Admin Manager
        <small>Optional description</small>
            </h1>
            <ol class="breadcrumb">
                <li><a href="#"><i class="fa fa-dashboard"></i>Level</a></li>
                <li class="active">Here</li>
            </ol>
        </section>

        <!-- Main content -->
        <section class="content">
    <table width="60%" height="600" cellspacing="0" align="left">
        <tr>
            <td align="left" height="100px" style="width: 100%; text-align: left" valign="baseline"
                colspan="2">
            </td>
        </tr>
        <tr height="20px">
            <td align="left" style="width: 30%; text-align: left; vertical-align: middle;" id="">
                <span style="color: #ffffff"></span>
                <asp:Label ID="lblmsg" runat="server" Font-Names="Verdana" ForeColor="White" Style="position: relative"
                    Text="Company Name" Font-Size="10pt"></asp:Label>
                <asp:TextBox ID="txtSearch" runat="server" Style="position: relative" Font-Names="Verdana"
                    Font-Size="10pt" OnTextChanged="txtSearch_TextChanged"></asp:TextBox><asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="txtSearch"></asp:RequiredFieldValidator><asp:Button
                        ID="btnSearch" runat="server" OnClick="btnSearch_Click" Style="position: relative; left: 0px;"
                        Text="Filter" Width="80px" Font-Names="Verdana" Font-Size="10pt" />
                </td>
            <td width="30%" style="text-align: left">
                <asp:Button ID="btnRefresh" runat="server" OnClick="btnRefresh_Click" Style="position: relative"
                    Text="Refresh" Width="80px" Font-Names="Verdana" Font-Size="10pt" CausesValidation="False" /></td>
        </tr>
        <tr>
            <td align="left" height="300px" style="width: 100%; text-align: left; background-color: #ffffff;
                vertical-align: top;" colspan="2">
                <asp:GridView ID="gridAdminmanage" runat="server" Width="100%" Font-Names="Verdana"
                    Font-Size="Small" Style="position: relative" CaptionAlign="Top" HorizontalAlign="Left"
                    AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" DataKeyNames="CompanyID"
                    AllowPaging="True" OnDataBound="gridAdminmanage_DataBound" OnPageIndexChanging="gridAdminmanage_PageIndexChanging"
                    CssClass="../../../CSS/SysAdminCss/GridViewStyle.css" GridLines="Vertical">
                    <FooterStyle CssClass="FooterStyle" />
                    <Columns>
                        <asp:TemplateField>
                            <HeaderTemplate>
                                <asp:CheckBox ID="CheckAll" onclick="return check_uncheck (this );" runat="server" />
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:CheckBox ID="chkSelect" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Company Name">
                            <ItemTemplate>
                                <%# Eval("CompanyName")%>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="User Name">
                            <ItemTemplate>
                                <%# Eval("ADMIN")%>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="License">
                            <ItemTemplate>
                                <%# Eval("NoOfUser")%>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="No Of License" Visible="False">
                            <ItemTemplate>
                                <%# Eval("Status")%>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="No Of License" Visible="False">
                            <ItemTemplate>
                                <%# Eval("CompanyID")%>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="No Of License" Visible="False">
                            <ItemTemplate>
                                <%# Eval("adminStatus")%>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="No Of License" Visible="False">
                            <ItemTemplate>
                                <%# Eval("userStatus")%>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <RowStyle CssClass="RowStyle" />
                    <EditRowStyle BackColor="#999999" />
                    <SelectedRowStyle CssClass="SelectedRowStyle" />
                    <PagerStyle CssClass="PagerStyle" />
                    <HeaderStyle CssClass="HeaderStyle" />
                    <AlternatingRowStyle CssClass="AltRowStyle" />
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td height="10px" style="width: 50%; text-align: left; vertical-align: top;" colspan="2">
                <asp:Button ID="btnSuspendAdmin" runat="server" Text="Block Admin" Font-Size="10pt"
                    Font-Names="Verdana" OnClick="btnSuspendAdmin_Click" CausesValidation="False" />
                <asp:Button ID="btnSuspendUser" runat="server" Font-Names="Verdana" Font-Size="10pt"
                    Style="position: relative" Text="Block User" OnClick="btnSuspendUser_Click" CausesValidation="False" />&nbsp;
                <asp:Button ID="btnAdmin" runat="server" OnClick="btnAdmin_Click" Style="position: relative"
                    Text="Unblock Admin" Font-Names="Verdana" Font-Size="10pt" CausesValidation="False" />
                <asp:Button ID="btnUser" runat="server" OnClick="btnUser_Click" Style="position: relative"
                    Text="Unbock User" Font-Names="Verdana" Font-Size="10pt" CausesValidation="False" />
                <asp:Label ID="Label1" runat="server" Style="position: relative" Width="48px" Font-Names="Verdana"
                    Font-Size="10pt"></asp:Label></td>
        </tr>
        <tr>
            <td height="350px" colspan="2">
            </td>
        </tr>
    </table>
            </section>
        </div>
</asp:Content>
