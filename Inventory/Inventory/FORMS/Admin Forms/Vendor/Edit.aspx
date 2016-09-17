<%@ Page Language="C#" MasterPageFile="~/InventoryChild.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs"
    Inherits="Inventory.FORMS.Admin_Forms.Vendor.Edit" Title="Edit Vendor" %>

<%@ MasterType VirtualPath="~/InventoryChild.Master" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <div class="content-wrapper">
        <!-- Content Header (Page header) -->
        <section class="content-header">
            <h1>Edit Vendor
        <small>Optional description</small>
            </h1>
            <ol class="breadcrumb">
                <li><a href="#"><i class="fa fa-dashboard"></i>Level</a></li>
                <li class="active">Here</li>
            </ol>
        </section>

        <!-- Main content -->
        <section class="content">
            <div class="row">
                <div class="col-md-12">

                    <div class="portlet">
                        <div class="portlet-title">
                            <div class="caption">
                                <i class="fa fa-shopping-cart"></i>Edit Vendor
                            </div>

                        </div>
                        <div class="portlet-body">
                            <div class="tabbable">

                                <div class="tab-content no-space">
                                    <div class="tab-pane active" id="tab_general">
                                        <div class="form-body">
                                            <div class="form-group">
                                                <label class="col-md-2 control-label">
                                                    Vendor Name:
													<span class="required">*
                                                    </span>
                                                </label>
                                                <div>
                                                    &nbsp;<asp:DropDownList ID="ddlVendorName" OnInit="ddlVendorName_Init" AutoPostBack="true"
                                                        OnSelectedIndexChanged="ddlVendorName_SelectedIndexChanged" runat="server" Width="248px">
                                                    </asp:DropDownList>
                                                </div>
                                            </div>
                                            <div class="form-group">
                                                <label class="col-md-2 control-label">
                                                    Vendor Address1:
													<span class="required">*
                                                    </span>
                                                </label>
                                                <div>
                                                    <input type="text" id="txtVendorAddress1" runat="server" style="width: 248px; height: 48px;" />
                                                </div>
                                            </div>

                                            <div class="form-group">
                                                <label class="col-md-2 control-label">
                                                    Vendor Address2:
													<span class="required">*
                                                    </span>
                                                </label>
                                                <div>
                                                    <input type="text" id="txtVendorAddress2" runat="server" style="width: 248px; height: 48px;" />
                                                </div>
                                            </div>

                                            <div class="form-group">
                                                <label class="col-md-2 control-label">
                                                    Vendor Mobile:
													<span class="required">*
                                                    </span>
                                                </label>
                                                <div>
                                                    <input type="text" id="txtVendorMobile" runat="server" style="width: 248px; height: 48px;" />
                                                </div>
                                            </div>
                                            <div class="form-group">
                                                <label class="col-md-2 control-label">
                                                    Vendor Office:
													<span class="required">*
                                                    </span>
                                                </label>
                                                <div>
                                                    <input type="text" id="txtVendorOffice" runat="server" style="width: 248px; height: 48px;" />
                                                </div>
                                            </div>

                                            <div class="form-group">
                                                <label class="col-md-2 control-label">
                                                    Vendor Email:
													<span class="required">*
                                                    </span>
                                                </label>
                                                <div>
                                                    <input type="text" id="txtVendorEmail" runat="server" style="width: 248px; height: 48px;" />
                                                </div>
                                            </div>
                                            <div class="form-group">
                                                <label class="col-md-2 control-label">
                                                    Vendor Website:
													<span class="required">*
                                                    </span>
                                                </label>
                                                <div>
                                                    <input type="text" id="txtVendorWebsite" runat="server" style="width: 248px; height: 48px;" />
                                                </div>
                                            </div>
                                            <div class="form-group">
                                                <label class="col-md-2 control-label">
                                                    Vendor City:
													<span class="required">*
                                                    </span>
                                                </label>
                                                <div>
                                                    <input type="text" id="txtVendorCity" runat="server" style="width: 248px; height: 48px;" />
                                                </div>
                                            </div>

                                            <div class="actions btn-set">
                                                <asp:Button ID="btnEdit" ValidationGroup="btnClick" runat="server" Text="Edit" OnClick="btnEdit_Click" CssClass="btn green"></asp:Button>
                                            </div>





                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </section>
    </div>
</asp:Content>
