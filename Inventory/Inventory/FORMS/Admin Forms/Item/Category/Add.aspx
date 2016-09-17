<%@ Page Language="C#" MasterPageFile="~/InventoryChild.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="Inventory.FORMS.Admin_Forms.Item.Category.Add" %>

<%--<%@ MasterType VirtualPath="~/InventoryChild.Master" %>--%>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">

    <!-- Content Wrapper. Contains page content -->
    <!-- Content Wrapper. Contains page content -->
    <div class="content-wrapper">
        <!-- Content Header (Page header) -->
        <section class="content-header">
            <h1>Add Category
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

                        <div class="portlet-body">
                            <div class="tabbable">

                                <div class="tab-content no-space">
                                    <div class="tab-pane active" id="tab_general">
                                        <div class="form-body">
                                            <div class="form-group">
                                                <label class="col-md-2 control-label">
                                                    Category Name:
													<span class="required">*
                                                    </span>
                                                </label>
                                                <div class="col-md-10">
                                                    <input id="txtName" style="width: 232px; position: relative" type="text" runat="server" /><br />
                                                    <asp:RequiredFieldValidator runat="server" ForeColor="Tomato" ID="rqfldName" ErrorMessage="*" ControlToValidate="txtName"></asp:RequiredFieldValidator>
                                                </div>
                                            </div>

                                            <div class="actions btn-set">
                                                <asp:Button ID="btnSave" OnClick="btnSave_Click" runat="server" Style="position: relative" Text="Submit" />
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
