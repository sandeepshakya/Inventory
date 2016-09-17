<%@ Page Title="" Language="C#" MasterPageFile="~/InventoryChild.Master" AutoEventWireup="true" CodeBehind="ViewSub.aspx.cs" Inherits="Inventory.FORMS.Admin_Forms.Item.SubCategory.ViewSub" %>
<%@ MasterType VirtualPath="~/InventoryChild.Master" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
       <div class="content-wrapper">
        <!-- Content Header (Page header) -->
        <section class="content-header">
            <h1>Category View Page
        <small>Optional description</small>
            </h1>
            <ol class="breadcrumb">
                <li><a href="#"><i class="fa fa-dashboard"></i>Level</a></li>
                <li class="active">Here</li>
            </ol>
        </section>

        <section class="content">
            <div class="row">
                <!-- Left col -->
                <section class="content">

                    <div class="box">
                        <div class="box-header">
                        </div>
                        <!-- /.box-header -->

                        <div class="box-body">
                            <asp:GridView ID="grdSub" runat="server" OnRowCommand="grdSub_RowCommand"
                                AutoGenerateColumns="False" DataKeyNames="Id" 
                                AllowPaging="True" 
                                CssClass="table table-bordered table-hover dataTable"  ShowHeaderWhenEmpty="true">
                                <AlternatingRowStyle CssClass="odd" />
                                <Columns>
                                     <asp:BoundField DataField="Id" HeaderText="" Visible="false" />                              
                                    <asp:TemplateField HeaderText="Category" ShowHeader="true" HeaderStyle-CssClass="sorting_desc" ItemStyle-Width="40%">
                                        <ItemTemplate>
                                            <%# Eval("CatName")%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                
                                    <asp:TemplateField HeaderText="SubCategory" ShowHeader="true" HeaderStyle-CssClass="sorting_desc" ItemStyle-Width="40%">
                                        <ItemTemplate>
                                            <%# Eval("Name")%>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                      <asp:TemplateField ItemStyle-Width="10%">
                                        <ItemTemplate>
                                          
                                                <asp:LinkButton ID="linkDelete" OnClientClick="return ConfirmOnDelete();" OnClick="LinkDeleteClick" CssClass="btn btn-danger btn-xs" runat="server">Delete</asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                 <asp:ButtonField ButtonType="Button" ControlStyle-CssClass="glyphicon glyphicon-search btn bg-olive btn-xs" CommandName="EditButton" Text="Edit" />

                                </Columns>
                             <EmptyDataTemplate>
                                    <asp:Label runat="server" ID="lblNoRecords" Text="No records to display"></asp:Label>
                                </EmptyDataTemplate>
                            </asp:GridView>
                            <!-- END EXAMPLE TABLE PORTLET-->
                        </div>
                         <div class="row"><div class="col-sm-5"><div class="dataTables_info" id="example2_info" role="status" aria-live="polite">Showing 1 to 10 of 57 entries</div></div><div class="col-sm-7"><div class="dataTables_paginate paging_simple_numbers" id="example2_paginate"><ul class="pagination"><li class="paginate_button previous disabled" id="example2_previous"><a href="#" aria-controls="example2" data-dt-idx="0" tabindex="0">Previous</a></li><li class="paginate_button active"><a href="#" aria-controls="example2" data-dt-idx="1" tabindex="0">1</a></li><li class="paginate_button "><a href="#" aria-controls="example2" data-dt-idx="2" tabindex="0">2</a></li><li class="paginate_button "><a href="#" aria-controls="example2" data-dt-idx="3" tabindex="0">3</a></li><li class="paginate_button "><a href="#" aria-controls="example2" data-dt-idx="4" tabindex="0">4</a></li><li class="paginate_button "><a href="#" aria-controls="example2" data-dt-idx="5" tabindex="0">5</a></li><li class="paginate_button "><a href="#" aria-controls="example2" data-dt-idx="6" tabindex="0">6</a></li><li class="paginate_button next" id="example2_next"><a href="#" aria-controls="example2" data-dt-idx="7" tabindex="0">Next</a></li></ul></div></div></div>
          
                    </div>

                </section>
            </div>
        </section>
    </div>
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
