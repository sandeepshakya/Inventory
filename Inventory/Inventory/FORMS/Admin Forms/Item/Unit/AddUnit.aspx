<%@ Page Language="C#" MasterPageFile="~/InventoryChild.Master" AutoEventWireup="true" CodeFile="AddUnit.aspx.cs" Inherits="FORMS_Admin_Forms_Item_Unit_AddUnit" Title="Add Unit" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">

    <div class="content-wrapper">
        <!-- Content Header (Page header) -->
        <section class="content-header">
            <h1>Add Unit
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
                                                    Select Product:
													<span class="required">*
                                                    </span>
                                                </label>
                                                <div >
                                                    <asp:DropDownList ID="DropDownList1" runat="server" Font-Names="Verdana" Font-Size="Small"
                                                        Width="154px">
                                                    </asp:DropDownList><br />
                                                </div>
                                            </div>
                                            <div class="form-group">
                                                <label class="col-md-2 control-label">
                                                    Add Unit:
													<span class="required">*
                                                    </span>
                                                </label>
                                                <div class="col-md-10">
                                                    <input id="Text1" type="text" /><br />
                                                </div>
                                            </div>
                                            <div class="actions btn-set">
                                                <input id="Submit1" type="submit" value="Save" />
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

</asp:Content>
