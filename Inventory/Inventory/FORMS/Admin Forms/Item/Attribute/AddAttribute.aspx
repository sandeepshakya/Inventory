<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/InventoryChild.Master" CodeBehind="AddAttribute.aspx.cs" Inherits="Inventory.FORMS.Admin_Forms.Item.Attribute.AddAttribute" %>

<%@ MasterType VirtualPath="~/InventoryChild.Master" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <div class="content-wrapper">
        <!-- Content Header (Page header) -->
        <section class="content-header">
            <h1>Add Attribute
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
                                                <label class="col-md-2 control-label">
                                                    Select Product:
													<span class="required">*
                                                    </span>
                                                </label>
                                                <div>
                                                    <asp:DropDownList ID="ddlProduct" runat="server"></asp:DropDownList>
                                                    <asp:RequiredFieldValidator ID="rqFldDDl" runat="server" ControlToValidate="ddlProduct" InitialValue="0" ForeColor="Tomato" ErrorMessage="*">

                                                    </asp:RequiredFieldValidator>
                                                </div>
                                                <div class="form-group">
                                                    <label class="col-md-2 control-label">
                                                        Attribute Name:
													<span class="required">*
                                                    </span>
                                                    </label>
                                                    <div class="col-md-10">
                                                        <input type="text" id="txtAttributeName" runat="server" style="width: 184px" />
                                                        <asp:RequiredFieldValidator ID="rqFAttName" runat="server" ControlToValidate="txtAttributeName" ForeColor="Tomato" ErrorMessage="*">

                                                        </asp:RequiredFieldValidator>
                                                    </div>

                                                    <div class="actions btn-set">
                                                        <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Save" />
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
