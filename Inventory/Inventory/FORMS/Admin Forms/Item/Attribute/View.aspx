<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/InventoryChild.Master" CodeBehind="View.aspx.cs" Inherits="Inventory.FORMS.Admin_Forms.Item.Attribute.View" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">

    <div class="content-wrapper">
        <!-- Content Header (Page header) -->
        <section class="content-header">
            <h1>View Attribute
        <small>Optional description</small>
            </h1>
            <ol class="breadcrumb">
                <li><a href="#"><i class="fa fa-dashboard"></i>Level</a></li>
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
                                                <label>
                                                    Choose attribute Name:
													<span class="required">*
                                                    </span>
                                                </label>
                                                <div>
                                                    <select id="SelectAttributeName" style="position: relative; width: 168px;">
                                                        <option selected="selected"></option>
                                                    </select>
                                                </div>
                                                <div class="form-group">
                                                    <label>
                                                        Attribute Name:
													<span class="required">*
                                                    </span>
                                                    </label>
                                                    <div>
                                                        <input type="text" id="txtAttributeName" style="width: 168px" />
                                                    </div>

                                                    <div class="actions btn-set">
                                                        <input type="button" id="btnSave" value="Save" style="width: 56px">
                                                    </div>
                                                </div>
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
