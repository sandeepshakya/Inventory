<%@ Page Language="C#" MasterPageFile="~/InventoryChild.Master" AutoEventWireup="true" CodeFile="EditUnit.aspx.cs" Inherits="FORMS_Admin_Forms_Item_Unit_EditUnit" Title="Edit Unit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <div class="content-wrapper">
        <!-- Content Header (Page header) -->
        <section class="content-header">
            <h1>Edit Unit
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
                                                   Select Unit:
													<span class="required">*
                                                    </span>
                                                </label>
                                                <div >
                                                    <asp:DropDownList ID="DropDownList1" runat="server" Width="156px">
                                </asp:DropDownList><br />
                                                </div>
                                            </div>
                                            <div class="form-group">
                                                <label class="col-md-2 control-label">
                                                    Change Unit name:
													<span class="required">*
                                                    </span>
                                                </label>
                                                <div class="col-md-10">
                                                    <input id="Text1" type="text" /><br />
                                                </div>
                                            </div>
                                            <div class="actions btn-set">
                                               <input id="Submit1" type="submit" value="Update" />
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
