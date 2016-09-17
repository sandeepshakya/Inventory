<%@ Page Language="C#" MasterPageFile="~/InventoryChild.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="Inventory.FORMS.Admin_Forms.Item.Category.Edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">

    <div class="content-wrapper">
        <!-- Content Header (Page header) -->
        <section class="content-header">
            <h1>Edit Category
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
                                    <div class="tab-pane active" id="Div1">
                                        <div class="form-body">
                                            <div class="form-group">
                                                <label class="col-md-2 control-label">
                                                    Category Name:
													<span class="required">*
                                                    </span>
                                                </label>
                                                <div >
                                                    <asp:DropDownList ID="ddlCategoryName" OnInit="ddlCategoryName_Init" AutoPostBack="true"
                                                        OnSelectedIndexChanged="ddlCategoryName_SelectedIndexChanged" runat="server" Width="176px">
                                                    </asp:DropDownList>
                                                </div>

                                               
                                            </div>
                                            <div class="form-group">
                                                <label class="col-md-2 control-label">
                                                    Category Name:
													<span class="required">*
                                                    </span>
                                                </label>
                                                <div >
                                                    <input type="text" id="txtCategoryName" runat="server" style="width: 176px; height: 48px;" />
                                                </div>

                                                <div class="actions btn-set">
                                                    <asp:Button ID="btnEdit" OnClick="btnEdit_Click" runat="server" Style="position: relative" Text="Edit" />
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
