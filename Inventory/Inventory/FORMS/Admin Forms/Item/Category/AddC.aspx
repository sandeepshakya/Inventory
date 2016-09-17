<%@ Page Language="C#" MasterPageFile="~/InventoryChild.Master" AutoEventWireup="true" CodeBehind="AddC.aspx.cs" Inherits="Inventory.FORMS.Admin_Forms.Item.Category.AddC" %>

<%@ MasterType VirtualPath="~/InventoryChild.Master" %>

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
                                                    <asp:RequiredFieldValidator runat="server" ForeColor="Tomato" ID="rqfldName" ErrorMessage="*" ControlToValidate="txtName" ValidationGroup="btnClick"></asp:RequiredFieldValidator>
                                                </div>
                                            </div>

                                            <div class="actions btn-set">
                                                <asp:Button ID="btnSave" OnClick="btnSave_Click" runat="server" Style="position: relative" Text="Submit"  ValidationGroup="btnClick"/>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>

            </div>
            <div class="row">
                <!-- Left col -->
                <section class="content">

                    <div class="box">
                        <div class="box-body">
                            <asp:GridView ID="grdCategory" runat="server"
                                AutoGenerateColumns="False" DataKeyNames="Id"
                                AllowPaging="True" CssClass="table table-bordered table-hover dataTable" Width="100%" ShowHeaderWhenEmpty="true" 
                                >
                               <AlternatingRowStyle CssClass="odd" />
                                <Columns>                              
                                    <asp:TemplateField HeaderText="Name" ShowHeader="true" HeaderStyle-CssClass="sorting_desc" ItemStyle-Width="40%">
                                        <ItemTemplate>
                                            <%# Eval("Name")%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                  
                                    <asp:TemplateField HeaderText="Added By" ShowHeader="true" HeaderStyle-CssClass="sorting_desc" ItemStyle-Width="40%">
                                        <ItemTemplate>
                                            <%# Eval("UserName")%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    
                                    <asp:TemplateField ItemStyle-Width="10%">
                                        <ItemTemplate>
                                          
                                                <asp:LinkButton ID="linkDelete" OnClientClick="return ConfirmOnDelete();" OnClick="LinkDeleteClick" CssClass="btn btn-danger btn-xs" runat="server">Delete</asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                               <EmptyDataTemplate>
                                   <asp:Literal ID="ltrlMsg" runat="server" Text="No Records to Display"></asp:Literal>
                               </EmptyDataTemplate>
                            </asp:GridView>
                            <!-- END EXAMPLE TABLE PORTLET-->
                        </div>
                         <div class="row"><div class="col-sm-5"><div class="dataTables_info" id="example2_info" role="status" aria-live="polite">Showing 1 to 10 of 57 entries</div></div><div class="col-sm-7"><div class="dataTables_paginate paging_simple_numbers" id="example2_paginate"><ul class="pagination"><li class="paginate_button previous disabled" id="example2_previous"><a href="#" aria-controls="example2" data-dt-idx="0" tabindex="0">Previous</a></li><li class="paginate_button active"><a href="#" aria-controls="example2" data-dt-idx="1" tabindex="0">1</a></li><li class="paginate_button "><a href="#" aria-controls="example2" data-dt-idx="2" tabindex="0">2</a></li><li class="paginate_button "><a href="#" aria-controls="example2" data-dt-idx="3" tabindex="0">3</a></li><li class="paginate_button "><a href="#" aria-controls="example2" data-dt-idx="4" tabindex="0">4</a></li><li class="paginate_button "><a href="#" aria-controls="example2" data-dt-idx="5" tabindex="0">5</a></li><li class="paginate_button "><a href="#" aria-controls="example2" data-dt-idx="6" tabindex="0">6</a></li><li class="paginate_button next" id="example2_next"><a href="#" aria-controls="example2" data-dt-idx="7" tabindex="0">Next</a></li></ul></div></div></div>
          
                    </div>

                </section>
            </div>
        </section>
        <!-- Your Page Content Here -->


        <!-- /.content -->
    </div>
    <!-- /.content-wrapper -->
     <script type="text/javascript">
         function ConfirmOnDelete() {
             if (confirm("Are you sure you want to delete this record?") == true) {
                                 return true;
             }
             else {
                
                 return false;
             }
         }
    </script>
</asp:Content>
