<%@ Page Language="C#" MasterPageFile="~/FORMS/Master Page/SystemAdminMaster/MasterPage.master"
    AutoEventWireup="true" CodeBehind="CompMgmt_Old.aspx.cs" Inherits="Inventory.FORMS.System_Admin.Home"
    Title="Company Management" %>

<%@ MasterType VirtualPath="~/FORMS/Master Page/SystemAdminMaster/MasterPage.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <script type="text/javascript">
function OpenPopUp(id,mail,name,cname)
{
    open("SendEmail.aspx?id="+ id + "&mail="+mail +"&name="+ name + "&cname=" + cname,"",'toolbar=no,resizable=no,menubar=no,height=200px,width=300px,left = 500,top = 400,directories=no');

}

function check_uncheck(Val)
{
  var ValChecked = Val.checked;
  var ValId = Val.id;
  var frm = document.forms[0];
  // Loop through all elements
  for (i = 0; i < frm.length; i++)
  {
    // Look for Header Template's Checkbox
    //As we have not other control other than checkbox we just check following statement
    if (this != null)
    {
      if (ValId.indexOf('CheckAll') !=  - 1)
      {
        // Check if main checkbox is checked,
        // then select or deselect datagrid checkboxes
        if (ValChecked)
          frm.elements[i].checked = true;
        else
          frm.elements[i].checked = false;
      }
      else if (ValId.indexOf('deleteRec') !=  - 1)
      {
        // Check if any of the checkboxes are not checked, and then uncheck top select all checkbox
        if (frm.elements[i].checked == false)
          frm.elements[1].checked = false;
      }
    } 
  } 
} 

    </script>

    <table width="100%" height="632">
        <tr valign="baseline">
            <td  align="left">
                <br />
                <br />
                <br />
                <asp:Label ID="Label1" runat="server" Font-Names="Verdana" Font-Size="Small" ForeColor="Red"
                    Text="* Shows Type company to be searched name"></asp:Label><br />
                <table height="20px" width="80%" style="" cellspacing="2">
                    <tr>
                        <td style="text-align: right" width="12%">
                            <asp:Label ID="lblName" runat="server" Font-Names="Verdana" Font-Size="10pt" ForeColor="White"
                                Style="position: relative" Text="Company Name"></asp:Label></td>
                        <td style="" width="18%">
                            <asp:TextBox ID="txtSearch" runat="server" Style="position: relative" Font-Names="Verdana"
                                Font-Size="10pt" Width="150px" OnTextChanged="txtSearch_TextChanged"></asp:TextBox><asp:RequiredFieldValidator
                                    ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="txtSearch"></asp:RequiredFieldValidator></td>
                        <td width="18%">
                            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Style="position: relative"
                                Text="Search" Width="56px" /></td>
                        <td style="text-align: right" width="6%">
                            <asp:Label ID="lblStatus" runat="server" ForeColor="White" Style="position: relative"
                                Text="Status" Font-Names="Verdana" Font-Size="10pt"></asp:Label></td>
                        <td style="" width="20%">
                            <asp:DropDownList ID="ddlStatus" runat="server" Visible="False" Width="157px" OnSelectedIndexChanged="ddlStatus_SelectedIndexChanged"
                                Style="position: relative" Font-Names="Verdana" Font-Size="10pt">
                                <asp:ListItem Selected="True">Activate</asp:ListItem>
                                <asp:ListItem>Deactivate</asp:ListItem>
                                <asp:ListItem>Registered</asp:ListItem>
                                <asp:ListItem>Trial</asp:ListItem>
                                <asp:ListItem>Block</asp:ListItem>
                            </asp:DropDownList></td>
                        <td style="" width="25%">
                            <asp:Button ID="btnSearch" runat="server" Text="Find" OnClick="btnSearch_Click" Width="56px"
                                Font-Names="Verdana" Font-Size="10pt" CausesValidation="False" Style="position: relative" /></td>
                    </tr>
                </table>
                <table width="80%" border="0" cellpadding="0" cellspacing="0">
                    <tr>
                        <td style="text-align: left; width: 100%; background-color: #ffffff; vertical-align: top;"
                            height="310px">
                            <asp:GridView ID="gridCompanies" runat="server" Style="position: relative" AllowPaging="True"
                                Width="100%" Font-Size="Medium" OnPageIndexChanging="gridCompanies_PageIndexChanging"
                                CellPadding="4" ForeColor="#333333" AutoGenerateColumns="False" DataKeyNames="CompanyID"
                                BackColor="White" CssClass="../../../CSS/SysAdminCss/GridViewStyle.css" GridLines="Vertical">
                                <PagerSettings PreviousPageText="&amp;gt;" />
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
                                    <asp:TemplateField HeaderText="Company Id" Visible="False">
                                        <ItemTemplate>
                                            <%# Eval("CompanyID") %>
                                        </ItemTemplate>
                                        <ItemStyle Width="10%" />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Company Name">
                                        <ItemTemplate>
                                            <%# Eval("Name") %>
                                        </ItemTemplate>
                                        <ItemStyle Width="200px" />
                                        <HeaderStyle Width="20%" />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Contact Person">
                                        <ItemTemplate>
                                            <%# Eval("ContactPersonName")%>
                                        </ItemTemplate>
                                        <ItemStyle Width="200px" />
                                        <HeaderStyle Width="20%" />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Contact No">
                                        <ItemTemplate>
                                            <%# Eval("ContactNumber")%>
                                        </ItemTemplate>
                                        <ItemStyle Width="200px" />
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
                                        <HeaderStyle Width="13%" />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Activation Date">
                                        <ItemTemplate>
                                            <%# Eval("ApprovalDate","{0:d}")  %>
                                        </ItemTemplate>
                                        <ItemStyle Width="200px" />
                                        <HeaderStyle Width="20%" />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="License Period">
                                        <ItemTemplate>
                                            <%# Eval("LicenceDuration")%>
                                        </ItemTemplate>
                                        <ItemStyle Width="200px" />
                                        <HeaderStyle Width="18%" />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="License">
                                        <ItemTemplate>
                                            <%# Eval("NoOfLicence")%>
                                        </ItemTemplate>
                                        <ItemStyle Width="200px" />
                                        <HeaderStyle Width="3%" />
                                    </asp:TemplateField>
                                </Columns>
                              <RowStyle CssClass="RowStyle" BackColor="#EFF3FB" Font-Names="Verdana" Font-Size="Small" />
                    <EditRowStyle BackColor="#999999" />
                    <SelectedRowStyle CssClass="SelectedRowStyle" />
                    <PagerStyle CssClass="PagerStyle" />
                    <HeaderStyle CssClass="HeaderStyle" />
                    <AlternatingRowStyle BackColor="#FFCC99" />
                            </asp:GridView>
                           
                            <asp:GridView ID="gridRegistered" runat="server" Style="position: relative" ForeColor="#333333"
                                Width="100%" Font-Size="Medium" AllowPaging="True" AutoGenerateColumns="False"
                                OnSelectedIndexChanged="gridRegistered_SelectedIndexChanged" DataKeyNames="CompanyID"
                                OnPageIndexChanging="gridRegistered_PageIndexChanging" GridLines="Vertical">
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
                                    <asp:TemplateField HeaderText="Company Id" Visible="False">
                                        <ItemTemplate>
                                            <%# Eval("CompanyID") %>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Company Name">
                                        <ItemTemplate>
                                            <%# Eval("Name") %>
                                        </ItemTemplate>
                                        <EditItemTemplate>
                                            <asp:TextBox ID="txtCompName" runat="server" Text='<%# Bind("Name")  %>' />
                                        </EditItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Contact Person">
                                        <ItemTemplate>
                                            <%# Eval("ContactPersonName")%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Contact Number">
                                        <ItemTemplate>
                                            <%# Eval("ContactNumber")%>
                                        </ItemTemplate>
                                        <EditItemTemplate>
                                            <asp:TextBox ID="txtConNo" runat="server" Text='<%# Bind("ContactNumber")  %>' />
                                        </EditItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Email Id">
                                        <ItemTemplate>
                                            <%# Eval("Email")%>
                                        </ItemTemplate>
                                        <EditItemTemplate>
                                            <asp:TextBox ID="txtEmail" runat="server" Text='<%# Bind("Email")  %>' />
                                        </EditItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="City">
                                        <ItemTemplate>
                                            <%# Eval("City")%>
                                        </ItemTemplate>
                                        <HeaderStyle Width="6%" />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Registration Date">
                                        <ItemTemplate>
                                            <%# Eval("RegistrationDate", "{0:d}")%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <a href="javascript:void(0)" onclick="OpenPopUp('<%# Eval("CompanyID") %>','<%# Eval("Email") %>','<%# Eval("ContactPersonname") %>','<%# Eval("Name") %>')">
                                                Active</a>
                                            <%--<asp:Button ID="btnSelect" Text="Activate" runat="server" OnClientClick="OpenPopUp('<%# Eval("CompanyID") %>')" BorderStyle="Double" />--%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                         <RowStyle CssClass="RowStyle" BackColor="#EFF3FB" Font-Names="Verdana" Font-Size="Small" />
                    <EditRowStyle BackColor="#999999" />
                    <SelectedRowStyle CssClass="SelectedRowStyle" />
                    <PagerStyle CssClass="PagerStyle" />
                    <HeaderStyle CssClass="HeaderStyle" />
                    <AlternatingRowStyle BackColor="#FFCC99" />
                            </asp:GridView>
                            <asp:GridView ID="gridTrial" runat="server" Style="position: relative" ForeColor="#333333"
                                Width="100%" Font-Size="Medium" AllowPaging="True" AutoGenerateColumns="False"
                                DataKeyNames="CompanyID" OnPageIndexChanging="gridTrial_PageIndexChanging" GridLines="Vertical">
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
                                    <asp:TemplateField HeaderText="Company Id" Visible="False">
                                        <ItemTemplate>
                                            <%# Eval("CompanyID") %>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Company Name">
                                        <ItemTemplate>
                                            <%# Eval("Name") %>
                                        </ItemTemplate>
                                        <EditItemTemplate>
                                            <asp:TextBox ID="txtCompName" runat="server" Text='<%# Bind("Name")  %>' />
                                        </EditItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Contact Person">
                                        <ItemTemplate>
                                            <%# Eval("ContactPersonName")%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Contact Number">
                                        <ItemTemplate>
                                            <%# Eval("ContactNumber")%>
                                        </ItemTemplate>
                                        <EditItemTemplate>
                                            <asp:TextBox ID="txtConNo" runat="server" Text='<%# Bind("ContactNumber")  %>' />
                                        </EditItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Email Id">
                                        <ItemTemplate>
                                            <%# Eval("Email")%>
                                        </ItemTemplate>
                                        <EditItemTemplate>
                                            <asp:TextBox ID="txtEmail" runat="server" Text='<%# Bind("Email")  %>' />
                                        </EditItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="City">
                                        <ItemTemplate>
                                            <%# Eval("City")%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Start Date">
                                        <ItemTemplate>
                                            <%# Eval("TrialStartDate", "{0:d}")%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="End Date">
                                        <ItemTemplate>
                                            <%# Eval("TrialEndDate", "{0:d}")%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                              <RowStyle CssClass="RowStyle" BackColor="#EFF3FB" Font-Names="Verdana" Font-Size="Small" />
                    <EditRowStyle BackColor="#999999" />
                    <SelectedRowStyle CssClass="SelectedRowStyle" />
                    <PagerStyle CssClass="PagerStyle" />
                    <HeaderStyle CssClass="HeaderStyle" />
                    <AlternatingRowStyle BackColor="#FFCC99" />
                            </asp:GridView>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align: left;">
                            <asp:Button ID="btnActivate" runat="server" Style="position: relative" Text="Deactivate"
                                OnClick="btnActivate_Click" Font-Names="Verdana" Font-Size="10pt" CausesValidation="False" />&nbsp;
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
