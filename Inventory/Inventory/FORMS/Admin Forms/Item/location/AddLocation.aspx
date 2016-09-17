<%@ Page Language="C#" MasterPageFile="~/InventoryChild.Master"
    AutoEventWireup="true" CodeFile="AddLocation.aspx.cs" Inherits="FORMS_Admin_Forms_Item_location_AddLocation"
    Title="Ware House" %>
<%@ MasterType VirtualPath="~/InventoryChild.Master" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">

    <!-- Content Wrapper. Contains page content -->
    <!-- Content Wrapper. Contains page content -->
    <div class="content-wrapper">
        <!-- Content Header (Page header) -->
        <section class="content-header">
            <h1>Add Warehouse
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
                                                    Warehouse Name:
													<span class="required">*
                                                    </span>
                                                </label>
                                                <div>
                                                    <input id="txtName" style="width: 232px;" type="text" runat="server" />
                                                    <asp:RequiredFieldValidator ID="rqText1" runat="server" ControlToValidate="txtName" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                                                    <br />
                                                </div>
                                            </div>
                                            <div class="form-group">
                                                <label class="col-md-2 control-label">
                                                    Address :
													<span class="required">*
                                                    </span>
                                                </label>
                                                <div>
                                                    <input id="txtAddress" style="width: 232px;" type="text" runat="server" />
                                                    <asp:RequiredFieldValidator ID="rqAddress" runat="server" ErrorMessage="*" ForeColor="Tomato" ControlToValidate="txtAddress"></asp:RequiredFieldValidator>

                                                </div>
                                            </div>
                                            <div class="form-group">
                                                <i class="fa fa-arrow-circle-right">
                                                    <asp:Button ID="btnSave" class="pull-Left btn btn-default" runat="server" OnClick="btnSave_Click" />
                                                </i>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
                </div>
            <div class="box">
                        <div class="box-header">
                        </div>
                        <!-- /.box-header -->

                        <div class="box-body">
                            <asp:GridView ID="grdLocation" runat="server"
                                AutoGenerateColumns="False" DataKeyNames="Id" 
                                AllowPaging="True" HeaderStyle-CssClass="sorting_asc"
                                CssClass="table table-bordered table-hover dataTable" ShowHeaderWhenEmpty="true">
                                <Columns> 
                                     <asp:BoundField DataField="Id" HeaderText="" Visible="false" />                              
                                    <asp:TemplateField HeaderText="Ware House">
                                        <ItemTemplate>
                                            <%# Eval("Name")%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                
                                    <asp:TemplateField HeaderText="Address">
                                        <ItemTemplate>
                                            <%# Eval("Address")%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                             <EmptyDataTemplate>
                                    <asp:Label runat="server" ID="lblNoRecords" Text="No records to display"></asp:Label>
                                </EmptyDataTemplate>
                            </asp:GridView>
                            <!-- END EXAMPLE TABLE PORTLET-->
                        </div>

                    </div>
        </section>
        <!-- Your Page Content Here -->


        <!-- /.content -->
    </div>
    <!-- /.content-wrapper -->



</asp:Content>
