<%@ Page Language="C#" MasterPageFile="~/InventoryChild.Master"
    AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="Inventory.FORMS.Admin_Forms.Vendor.Add" Title="Add Vendor" %>

<%@ MasterType VirtualPath="~/InventoryChild.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="Server">
        <div class="content-wrapper">
            <section class="content-header">
            <h1><asp:Literal ID="ltrlTitle" runat="server"></asp:Literal>
        <small>Optional description</small>
            </h1>
            <ol class="breadcrumb">
                <li><a href="#"><i class="fa fa-dashboard"></i>Level</a></li>
                <li class="active">Here</li>
            </ol>
        </section>
    <section class="content">
        <div class="row">
            <div class="box">
                <div class="box-body">
                    <div class="box-body">
                        <div class="tab-content">
                            <div id="home" class="tab-pane fade in active">
                                <div class="form-group">
                                    <label>Name*</label>
                                </div>
                                <div class="form-group">
                                    <input type="text" width="4000px" id="txtVendorName" runat="server" />
                                    <asp:RequiredFieldValidator
                                        ID="rqFldValName" runat="server" ErrorMessage="*" ControlToValidate="txtVendorName"></asp:RequiredFieldValidator>
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="lblVendorAddress1" runat="server" Text="Address1" Font-Size="Small"
                                        Font-Names="Verdana"></asp:Label>
                                </div>
                                <div class="form-group">
                                    <input type="text" id="txtVendorAddress1" runat="server" style="width: 152px; height: 48px;" />
                                    <asp:RequiredFieldValidator
                                        ID="rqFldValAddress1" runat="server" ErrorMessage="*" ControlToValidate="txtVendorAddress1">

                                    </asp:RequiredFieldValidator>
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="lblVendorAddress2" Text="Address2" runat="server" Font-Size="Small"></asp:Label>
                                </div>
                                <div class="form-group">
                                    <input type="text" id="txtVendorAddress2" runat="server" style="width: 152px; height: 48px;" />

                                </div>
                                <div class="form-group">
                                    <asp:Label ID="lblVendorMobile" runat="server" Style="position: relative" Text="Mobile No"
                                        Font-Size="Small" Font-Names="Verdana"></asp:Label><
                                </div>
                                <div class="form-group">
                                    <input type="text" id="txtVendorMobile" runat="server" />
                                    <asp:RequiredFieldValidator
                                        ID="rqMobilw" runat="server" ForeColor="Red" ErrorMessage="*" ControlToValidate="txtVendorMobile"></asp:RequiredFieldValidator>
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="lblVendorOffice" runat="server" Style="position: relative" Text="Office"
                                        Font-Size="Small" Font-Names="Verdana"></asp:Label>
                                </div>
                                <div class="form-group">
                                    <input type="text" id="txtVendorOffice" runat="server" />
                                    <asp:RequiredFieldValidator
                                        ID="rqOffice" runat="server" ForeColor="Red" ErrorMessage="*" ControlToValidate="txtVendorOffice"></asp:RequiredFieldValidator>

                                </div>


                                <div class="form-group">
                                    <asp:Label ID="lblVendorFax" runat="server" Font-Size="Small" Style="position: relative"
                                        Text="Vendor Fax" Font-Names="Verdana"></asp:Label>
                                </div>
                                <div class="form-group">
                                    <input type="text" id="txtVendorFax" runat="server" />
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="lblVendorEmail" runat="server" ext="Email"></asp:Label>
                                </div>
                                <div class="form-group">
                                    <input type="text" id="txtVendorEmail" runat="server" style="width: 248px" />
                                    <asp:RequiredFieldValidator
                                        ID="rqEmail" runat="server" Display="Dynamic" ErrorMessage="*" ValidationGroup="Validate" ControlToValidate="txtVendorEmail"></asp:RequiredFieldValidator>
                                    <asp:RequiredFieldValidator
                                        ID="validEmail" runat="server" ForeColor="Red" ErrorMessage="*" ControlToValidate="txtVendorEmail"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtVendorMobile" SetFocusOnError="true"
                                        ErrorMessage="Invalid Email" ForeColor="Red" ValidationGroup="Validate" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="lblVendorCity" runat="server" Text="City"></asp:Label>
                                </div>
                                <div class="form-group">
                                    <input type="text" id="txtVendorCity" runat="server" />
                                    <asp:RequiredFieldValidator ID="rqtxtVendorCity" runat="server" ErrorMessage="*" CssClass="ui-state-error-text" ControlToValidate="txtVendorCity"></asp:RequiredFieldValidator>
                                </div>

                                <div class="form-group">
                                    <asp:Label ID="lblWeb" runat="server" Text="Website"></asp:Label>
                                </div>
                                <div class="form-group">
                                    <input type="text" id="txtVendorWebsite" runat="server" />
                                </div>
                            </div>
                            <div class="form-group">
                                <i class="fa fa-arrow-circle-right">
                                    <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click1" class="pull-Left btn btn-default" Text="Save" />
                                </i>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
            </div>
</asp:Content>
