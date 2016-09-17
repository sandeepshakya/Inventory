<%@ Page Language="C#" MasterPageFile="~/InventoryChild.Master" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="Inventory.FORMS.System_Admin.Test" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
                <table height="8%" width="35%" style="border-right: #cc9966 thin solid; border-top: #cc9966 thin solid;
                    border-left: #cc9966 thin solid; border-bottom: #cc9966 thin solid" cellspacing="15">
                    <tr>
                        <td>
                            <asp:DropDownList ID="ddlSrcType" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlSrcType_SelectedIndexChanged">
                                <asp:ListItem Selected="True">Company ID</asp:ListItem>
                                <asp:ListItem>Company Name</asp:ListItem>
                                <asp:ListItem>Status</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            &nbsp;<asp:DropDownList ID="ddlStatus" runat="server" Width="166px" OnSelectedIndexChanged="ddlStatus_SelectedIndexChanged"
                                Style="position: relative">
                                <asp:ListItem >Approved</asp:ListItem>
                                <asp:ListItem>Disapproved</asp:ListItem>
                                <asp:ListItem>Registered</asp:ListItem>
                                <asp:ListItem>Trial</asp:ListItem>
                                <asp:ListItem>Block</asp:ListItem>
                            </asp:DropDownList>&nbsp;
                        </td>
                        <td style="width: 64px">
                            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                        </td>
                        <td>
                        </td>
                        <td style="width: 64px">
                        </td>
                    </tr>
                </table>
                
                <table style="border-right: #cc9966 thin solid; border-top: #cc9966 thin solid; border-left: #cc9966 thin solid;
                    border-bottom: #cc9966 thin solid; width: 80%;">
                    <tr>
                        <td style="text-align: right">
                            &nbsp;<asp:Button ID="btnRefresh" runat="server" Style="position: relative" Text="Refresh"
                                OnClick="btnRefresh_Click" /></td>
                    </tr>
                    <tr>
                        <td style="text-align: left">
                            <asp:GridView ID="gridCompanies" runat="server" Style="position: relative" AllowPaging="True"
                                Width="100%" Font-Size="Medium"                                 
                                CellPadding="4" ForeColor="#333333"
                                GridLines="None" AutoGenerateColumns="False" DataKeyNames="CompanyID">
                                <RowStyle Font-Size="Medium" BackColor="#EFF3FB" />
                                <Columns>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:CheckBox ID="chkSelect" runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Company Id" Visible="False">
                                        <ItemTemplate>
                                            <%# Eval("CompanyID") %>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Company Name">
                                        <ItemTemplate>
                                            <%# Eval("Name") %>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Contact Person Name">
                                        <ItemTemplate>
                                            <%# Eval("ContactPersonName")%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Contact Number">
                                        <ItemTemplate>
                                            <%# Eval("ContactNumber")%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Email Id">
                                        <ItemTemplate>
                                            <%# Eval("Email")%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="City">
                                        <ItemTemplate>
                                            <%# Eval("City")%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Activation Date">
                                        <ItemTemplate>
                                            <%# Eval("ApprovalDate")%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="License Period">
                                        <ItemTemplate>
                                            <%# Eval("LicenceDuration")%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Nunber Of Licese">
                                        <ItemTemplate>
                                            <%# Eval("NoOfLicence")%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                   
                                </Columns>
                                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <EditRowStyle BackColor="#2461BF" />
                                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <AlternatingRowStyle BackColor="White" />
                            </asp:GridView>
                            &nbsp;&nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align: left">
                            <asp:Button ID="btnActivate" runat="server" Style="position: relative" Text="Deactivate"
                                OnClick="btnActivate_Click" />&nbsp;
                        </td>
                    </tr>
                </table>
</asp:Content>
