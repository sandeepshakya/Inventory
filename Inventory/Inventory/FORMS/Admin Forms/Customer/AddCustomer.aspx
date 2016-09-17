<%@ Page Language="C#" MasterPageFile="~/InventoryChild.Master" AutoEventWireup="true" CodeBehind="AddCustomer.aspx.cs" Inherits="Inventory.FORMS.Admin_Forms.Customer.AddCustomer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    
     <!-- Content Wrapper. Contains page content -->
  <!-- Content Wrapper. Contains page content -->
  <div class="content-wrapper">
    <!-- Content Header (Page header) -->
    <section class="content-header">
      <h1>
        Add Customer
        <small>Optional description</small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i> Level</a></li>
        <li class="active">Here</li>
      </ol>
        </section>

        <section class="content">

         <div class="row">
                <div class="col-md-12">
                    
                        <div class="portlet">
                            
                            <div class="portlet-body">
                                <div class="tabbable">

                                    <div class="tab-content no-space">
                                        <div class="tab-pane active" id="tab_general">
                                            <div class="form-body">
                                                <div class="form-group">
                                                    <label class="col-md-2 control-label">
                                                        Customer Name:
													<span class="required">*
                                                    </span>
                                                    </label>
                                                    <div class="col-md-10">
                                                       <input id="txtCustomerName" style="width: 232px; position: relative" type="text"  runat="server"/><br />
                            <asp:RequiredFieldValidator runat="server" ForeColor="Tomato" ID="rqfldName" ErrorMessage="*" ControlToValidate="txtCustomerName"></asp:RequiredFieldValidator>                                                    </div>
                                                </div>
                                                <div class="form-group">
                                                    <label class="col-md-2 control-label">
                                                        Customer Office No:
													<span class="required">*
                                                    </span>
                                                    </label>
                                                    <div class="col-md-10">
                                                       <input id="txtCustomerOfficeNo" style="width: 232px; position: relative" type="text"  runat="server"/><br />
                            <asp:RequiredFieldValidator runat="server" ForeColor="Tomato" ID="RequiredFieldValidator1" ErrorMessage="*" ControlToValidate="txtCustomerOfficeNo"></asp:RequiredFieldValidator>                                                    </div>
                                                </div>
                                                <div class="form-group">
                                                    <label class="col-md-2 control-label">
                                                        Customer Mobile No:
													<span class="required">*
                                                    </span>
                                                    </label>
                                                    <div class="col-md-10">
                                                       <input id="txtCustomerMobileNo" style="width: 232px; position: relative" type="text"  runat="server"/><br />
                            <asp:RequiredFieldValidator runat="server" ForeColor="Tomato" ID="RequiredFieldValidator2" ErrorMessage="*" ControlToValidate="txtCustomerMobileNo"></asp:RequiredFieldValidator>                                                    </div>
                                                </div>

                                                <div class="form-group">
                                                    <label class="col-md-2 control-label">
                                                        Customer Shipping Address:
													<span class="required">*
                                                    </span>
                                                    </label>
                                                    <div class="col-md-10">
                                                       <input id="txtShippingAddress" style="width: 232px; position: relative" type="text"  runat="server"/><br />
                            <asp:RequiredFieldValidator runat="server" ForeColor="Tomato" ID="RequiredFieldValidator3" ErrorMessage="*" ControlToValidate="txtShippingAddress"></asp:RequiredFieldValidator>                                                    </div>
                                                </div>
                                                <div class="form-group">
                                                    <label class="col-md-2 control-label">
                                                        Billing Address:
													<span class="required">*
                                                    </span>
                                                    </label>
                                                    <div class="col-md-10">
                                                       <input id="txtbillingAddress" style="width: 232px; position: relative" type="text"  runat="server"/><br />
                            <asp:RequiredFieldValidator runat="server" ForeColor="Tomato" ID="RequiredFieldValidator4" ErrorMessage="*" ControlToValidate="txtbillingAddress"></asp:RequiredFieldValidator>                                                    </div>
                                                </div>
                                                <div class="form-group">
                                                    <label class="col-md-2 control-label">
                                                        Customer City:
													<span class="required">*
                                                    </span>
                                                    </label>
                                                    <div class="col-md-10">
                                                       <input id="txtCustomerCity" style="width: 232px; position: relative" type="text"  runat="server"/><br />
                            <asp:RequiredFieldValidator runat="server" ForeColor="Tomato" ID="RequiredFieldValidator5" ErrorMessage="*" ControlToValidate="txtCustomerCity"></asp:RequiredFieldValidator>                                                    </div>
                                                </div>
                                                <div class="form-group">
                                                    <label class="col-md-2 control-label">
                                                        Customer Fax:
													<span class="required">*
                                                    </span>
                                                    </label>
                                                    <div class="col-md-10">
                                                       <input id="txtCustomerFax" style="width: 232px; position: relative" type="text"  runat="server"/><br />
                            <asp:RequiredFieldValidator runat="server" ForeColor="Tomato" ID="RequiredFieldValidator6" ErrorMessage="*" ControlToValidate="txtCustomerFax"></asp:RequiredFieldValidator>                                                    </div>
                                                </div>
                                                
                                                <div class="form-group">
                                                    <label class="col-md-2 control-label">
                                                        Customer Email:
													<span class="required">*
                                                    </span>
                                                    </label>
                                                    <div class="col-md-10">
                                                       <input id="txtCustomerEmail" style="width: 232px; position: relative" type="text"  runat="server"/><br />
                            <asp:RequiredFieldValidator runat="server" ForeColor="Tomato" ID="RequiredFieldValidator7" ErrorMessage="*" ControlToValidate="txtCustomerEmail"></asp:RequiredFieldValidator>                                                    </div>
                                                </div>
                                                <div class="form-group">
                                                    <label class="col-md-2 control-label">
                                                        Customer Website:
													<span class="required">*
                                                    </span>
                                                    </label>
                                                    <div class="col-md-10">
                                                       <input id="txtCustomerWebsite" style="width: 232px; position: relative" type="text"  runat="server"/><br />
                            <asp:RequiredFieldValidator runat="server" ForeColor="Tomato" ID="RequiredFieldValidator8" ErrorMessage="*" ControlToValidate="txtCustomerWebsite"></asp:RequiredFieldValidator>                                                    </div>
                                                </div>
                                                <div class="actions btn-set">
                                                     <asp:Button ID="btnSave" runat="server" Style="position: relative" Text="Submit" />
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
      <!-- Your Page Content Here -->

   
  <!-- /.content -->
  </div>
  <!-- /.content-wrapper -->

</asp:Content>

