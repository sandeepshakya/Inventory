<%@ Page Language="C#" MasterPageFile="~/InventoryChild.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Inventory.FORMS.System_Admin.Registration" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <div class="content-wrapper">
        <!-- Content Header (Page header) -->
        <section class="content-header">
            <h1>Registration
            </h1>
            <ol class="breadcrumb">
                <li><a href="#"><i class="fa fa-dashboard"></i>Level</a></li>
                <li class="active">Here</li>
            </ol>
        </section>

        <!-- Main content -->
        <section class="content">
    <table width="100%" height="400">
        <tr>
            <td width="60%">
                <table width="100%" cellspacing="5">
                    <tr>
                        <td style="vertical-align: middle; text-align: left">
                            <table width="100%" cellspacing="5" style="font-size: 10pt; vertical-align: middle;
                                text-align: center; border-top-width: thin; border-left-width: thin; border-left-color: #cc6633;
                                border-bottom-width: thin; border-bottom-color: #cc6633; border-top-color: #cc6633;
                                border-right-width: thin; border-right-color: #cc6633;" border="0">
                                <tr>
                                    <td colspan="3" style="height: 25px; background-color: transparent; text-align: left">
                                        <strong style="color: azure">Registration Form &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                                            <asp:Label ID="lblErrMsg" runat="server" Font-Names="Verdana" Font-Size="10pt" ForeColor="#C00000"
                                                Style="position: relative" Width="432px"></asp:Label></strong></td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="border-bottom: #9999ff thin solid; height: 25px; background-color: #6f1e0d;
                                        text-align: left">
                                        <span style="color: #ffffff">Company Profile......</span></td>
                                </tr>
                                <tr>
                                    <td style="height: 25px; text-align: right; width: 258px;">
                                        <asp:Label ID="lblCompanyName" runat="server" Style="position: relative" Text="Company Name"
                                            Font-Names="Verdana" ForeColor="Snow"></asp:Label></td>
                                    <td style="height: 25px; text-align: left; width: 249px;">
                                        <input id="txtCompanyName" style="position: relative; width: 240px;" type="text"
                                            runat="server" /></td>
                                    <td style="width: 249px; height: 25px; text-align: left">
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtCompanyName"
                                            ErrorMessage="Require Company Name" Display="Dynamic" Text="*"></asp:RequiredFieldValidator></td>
                                </tr>
                                <tr>
                                    <td style="height: 25px; text-align: right; width: 258px;">
                                        <asp:Label ID="lblCompanySize" runat="server" Style="position: relative;" Text="Company Size"
                                            Font-Names="Verdana" ForeColor="Snow"></asp:Label></td>
                                    <td style="text-align: left; width: 249px;">
                                        <input id="txtSize" style="position: relative" type="text" runat="server" />
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtSize"
                                            ErrorMessage="Require Company Size" Style="position: relative" Display="Dynamic" Text="*"></asp:RequiredFieldValidator></td>
                                    <td style="width: 249px; text-align: left">
                                    </td>
                                </tr>
                                <tr>
                                    <td style="height: 25px; text-align: right; width: 258px;">
                                        <asp:Label ID="lblContactPerson" runat="server" Style="position: relative" Text="Contact Person"
                                            Font-Names="Verdana" ForeColor="Snow"></asp:Label></td>
                                    <td style="text-align: left; width: 249px;">
                                        <input id="txtPerson" style="position: relative; width: 240px;" type="text" runat="server" /></td>
                                    <td style="width: 249px; text-align: left">
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtPerson"
                                            ErrorMessage="Require Person Name" Display="Dynamic" Text="*"></asp:RequiredFieldValidator></td>
                                </tr>
                                <tr>
                                    <td style="height: 50px; text-align: right; width: 258px;">
                                        <asp:Label ID="lblCompanyDescription" runat="server" Style="position: relative" Text="Company Description"
                                            Font-Names="Verdana" ForeColor="Snow"></asp:Label></td>
                                    <td style="height: 50px; text-align: left; width: 249px;">
                                        <textarea id="txtDesc" style="position: relative; width: 240px; height: 40px; font-size: 10pt;
                                            font-family: Verdana;" runat="server"></textarea></td>
                                    <td style="width: 249px; height: 50px; text-align: left">
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtDesc"
                                            ErrorMessage="Require Company Description" Display="Dynamic" Text="*"></asp:RequiredFieldValidator></td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="border-bottom: #9999ff thin solid; height: 25px; text-align: left;
                                        background-color: #6f1e0d">
                                        <span style="color: #ffffff">Contact Details......</span></td>
                                </tr>
                                <tr>
                                    <td style="height: 50px; text-align: right; width: 258px;">
                                        <asp:Label ID="lblAddress" runat="server" Style="position: relative" Text="Address"
                                            Font-Names="Verdana" ForeColor="Snow"></asp:Label></td>
                                    <td style="text-align: left; width: 249px;">
                                        <textarea id="txtAddress" style="position: relative; width: 240px; height: 40px;
                                            font-size: 10pt; font-family: Verdana;" runat="server"></textarea></td>
                                    <td style="width: 249px; text-align: left">
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtAddress"
                                            ErrorMessage="Require Address" Display="Dynamic" Text="*"></asp:RequiredFieldValidator></td>
                                </tr>
                                <tr>
                                    <td style="height: 25px; text-align: right; width: 258px;">
                                        <asp:Label ID="lblCty" runat="server" Style="position: relative" Text="City" Font-Names="Verdana"
                                            ForeColor="Snow"></asp:Label></td>
                                    <td style="text-align: left; width: 249px;">
                                        <input id="txtCity" style="position: relative" type="text" runat="server" />
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtCity"
                                            ErrorMessage="Require City Name" Display="Dynamic" Text="*" Style="position: relative"></asp:RequiredFieldValidator></td>
                                    <td style="width: 249px; text-align: left">
                                    </td>
                                </tr>
                                <tr>
                                    <td style="height: 25px; text-align: right; width: 258px;">
                                        <asp:Label ID="lblState" runat="server" Style="position: relative" Text="State" Font-Names="Verdana"
                                            ForeColor="Snow"></asp:Label></td>
                                    <td style="height: 25px; text-align: left; width: 249px;">
                                        <input id="txtState" style="position: relative" type="text" runat="server" />
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtState"
                                            ErrorMessage="Require State Name" Display="Dynamic" Text="*" Style="position: relative"></asp:RequiredFieldValidator></td>
                                    <td style="width: 249px; height: 25px; text-align: left">
                                    </td>
                                </tr>
                                <tr>
                                    <td style="height: 25px; text-align: right; width: 258px;">
                                        <asp:Label ID="lblCountry" runat="server" Style="position: relative" Text="Country"
                                            Font-Names="Verdana" ForeColor="Snow"></asp:Label></td>
                                    <td style="text-align: left; width: 249px;">
                                        <input id="txtCountry" style="position: relative" type="text" runat="server" />
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtCountry"
                                            ErrorMessage="Require Country Name" Display="Dynamic" Text="*" Style="position: relative"></asp:RequiredFieldValidator></td>
                                    <td style="width: 249px; text-align: left">
                                    </td>
                                </tr>
                                <tr>
                                    <td style="height: 25px; text-align: right; width: 258px;">
                                        <asp:Label ID="lblContactNumber" runat="server" Style="position: relative" Text="Contact Number"
                                            Font-Names="Verdana" ForeColor="Snow"></asp:Label></td>
                                    <td style="text-align: left; width: 249px;">
                                        <input id="txtContactNo" style="position: relative; width: 168px;" type="text" runat="server" />
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtContactNo"
                                            ErrorMessage="Require Contact Number" Display="Dynamic" Text="*" Style="position: relative" ValidationExpression="[0-9]*"></asp:RegularExpressionValidator></td>
                                    <td style="width: 249px; text-align: left">
                                    </td>
                                </tr>
                                <tr>
                                    <td style="height: 25px; text-align: right; width: 258px;">
                                        <asp:Label ID="lblEmailId" runat="server" Style="position: relative" Text="Email Id"
                                            Font-Names="Verdana" ForeColor="Snow"></asp:Label></td>
                                    <td style="text-align: left; width: 249px;">
                                        <input id="txtEmail" style="position: relative; width: 240px;" type="text" runat="server" /></td>
                                    <td style="width: 249px; text-align: left">
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txtEmail"
                                            ErrorMessage="Require Email Id" Display="Dynamic" Text="*"></asp:RequiredFieldValidator></td>
                                </tr>
                                <tr>
                                    <td style="height: 25px; text-align: right; width: 258px;">
                                        <asp:Label ID="lblWebUrl" runat="server" Style="position: relative" Text="Web Url"
                                            Font-Names="Verdana" ForeColor="Snow"></asp:Label></td>
                                    <td style="text-align: left; width: 249px;">
                                        <input id="txtUrl" style="position: relative; width: 240px;" type="text" runat="server" /></td>
                                    <td style="width: 249px; text-align: left">
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtUrl"
                                            ErrorMessage="Require WebUrl" Font-Names="Verdana" Font-Size="Small" ValidationExpression="http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?"
                                            Width="15px">*</asp:RegularExpressionValidator>
                                        </td>
                                </tr>
                                <tr>
                                    <td style="height: 25px; text-align: right; width: 258px;">
                                        <asp:Label ID="lblUploadImage" runat="server" Style="position: relative" Text="No. Of License"
                                            Font-Names="Verdana" ForeColor="Snow"></asp:Label></td>
                                    <td colspan="2" style="text-align: left">
                                        <asp:TextBox ID="txtLicence" runat="server" Style="position: relative"></asp:TextBox>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtLicence"
                                            ErrorMessage="Require No Of License" Display="Dynamic" Text="*" Style="position: relative" ValidationExpression="[0-9]*"></asp:RegularExpressionValidator></td>
                                </tr>
                                <tr>
                                    <td style="width: 258px; height: 25px; text-align: right">
                                        <asp:Label ID="lblLogo" runat="server" Font-Names="Verdana" ForeColor="Snow" Style="position: relative"
                                            Text="Company Logo"></asp:Label></td>
                                    <td colspan="2" style="text-align: left">
                                        <asp:FileUpload ID="fuLogo" runat="server" Style="position: relative" /></td>
                                </tr>
                                <tr>
                                    <td style="width: 258px; height: 25px; text-align: right">
                                        <asp:Image ID="Image1" runat="server" ImageUrl="image.aspx" Style="position: relative" /></td>
                                    <td colspan="2" style="text-align: left">
                                        <asp:TextBox ID="txtImageValid" runat="server" Style="position: relative"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtImageValid"
                                            ErrorMessage="Require Image" Font-Names="Verdana" Font-Size="Small">*</asp:RequiredFieldValidator></td>
                                </tr>
                                <tr>
                                    <td  valign=top style="height: 57px;  text-align: right; width: 258px;">
                                        <asp:Label ID="Label1" runat="server" Font-Names="Verdana" Font-Size="Small" ForeColor="Red"
                                            Text="Image is case sensitive"></asp:Label></td>
                                    <td style="height: 57px; text-align: left; width: 249px;">
                                        <table width="100%">
                                            <tr>
                                                <td width="50%" style="text-align: left; height: 26px;">
                                                    <asp:Button ID="btnSubmit" runat="server" Style="position: relative" Text="Submit"
                                                        Width="64px" OnClick="btnSubmit_Click" /></td>
                                                <td style="text-align: left; height: 26px;">
                                                    <asp:Button ID="btnReset" runat="server" CausesValidation="False" OnClick="btnReset_Click"
                                                        Style="position: relative" Text="Reset" Width="64px" /></td>
                                            </tr>
                                        </table>
                                        <asp:Label ID="lblError" runat="server" ForeColor="Red" Font-Names="Verdana" Font-Size="Small"></asp:Label></td>
                                    <td style="width: 249px; height: 57px; text-align: left">
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="height: 25px; background-color: #6f1e0d; text-align: center">
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
            <td style="vertical-align: top">
                <table width="100%" height="632">
                    <tr height="50">
                        <td style="vertical-align: top; text-align: left; height: 50px;">
                            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowSummary="true"
                                DisplayMode="BulletList" Style="position: relative" Width="70%" />
                        </td>
                    </tr>
                    <tr height="200">
                        <td style="vertical-align: top; text-align: left">
                            <asp:Panel ID="Panel1" runat="server" Height="150px" Width="396px" BorderColor="#CC6633"
                                BorderWidth="1px">
                                <span style="font-size: 10pt; color: window">Incorporating your business is a great
                                    way to protect your personal assets from company liabilities such as creditors or
                                    lawsuits. In fact, many people incorporate for this reason alone. But that's not
                                    the only advantage.
                                    <br />
                                    <br />
                                    The corporate business structure also saves you money in taxes, provides greater
                                    business flexibility and makes it easier to seek outside investment. LegalZoom can
                                    help you incorporate your business in 3 simple steps.</span></asp:Panel>
                        </td>
                    </tr>
                    <tr height="232">
                        <td>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
            </section>
        </div>
</asp:Content>
