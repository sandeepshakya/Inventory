<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/InventoryChild.Master" CodeBehind="View.aspx.cs" Inherits="Inventory.FORMS.Admin_Forms.Purchase.View" %>

<%@ MasterType VirtualPath="~/InventoryChild.Master" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <div class="content-wrapper">
        <!-- Content Header (Page header) -->
        <section class="content-header">
            <h1>Purchase History
        <small>Optional description</small>
            </h1>
            <ol class="breadcrumb">
                <li><a href="#"><i class="fa fa-dashboard"></i>Level</a></li>
                <li class="active">Here</li>
            </ol>
        </section>

        <!-- Main content -->
        <section class="content">
    <div class="col-md-12">

        <div class="box box-primary">
            <div class="box-header box-header-background with-border">
              <%--  <h3 class="box-title ">Purchase History</h3>--%>
            </div>


            <div class="box-body">

                <!-- Table -->
                <div id="dataTables-example_wrapper" class="dataTables_wrapper form-inline" role="grid">
                    <div class="row ">
                        <div class="col-sm-5">
                            <div class="dataTables_length" id="dataTables-example_length">
                                <label>
                                    <select name="dataTables-example_length" aria-controls="dataTables-example" class="form-control input-sm">
                                        <option value="10">10</option>
                                        <option value="25">25</option>
                                        <option value="50">50</option>
                                        <option value="100">100</option>
                                    </select>
                                    <b>Records</b></label></div>
                        </div>
                        <div class="col-sm-5">
                            <div id="dataTables-example_filter" class="dataTables_filter">
                                <label>Search:<input type="search" style="margin: 0px 10px;" class="form-control input-sm" aria-controls="dataTables-example"></label></div>
                        </div>
                    </div>

                <asp:GridView ID="gridPo" DataKeyField="Id"  AutoGenerateColumns="false" ShowHeaderWhenEmpty="true"
                    CssClass="table table-bordered table-striped dataTable no-footer" runat="server">
                  <AlternatingRowStyle CssClass="odd" />
                                <Columns>
                    <asp:BoundField DataField="Id" Visible ="false" />
                    <asp:BoundField DataField="PoNumber" HeaderText="PO#" ShowHeader="true" HeaderStyle-CssClass="sorting_desc"/>
                    <asp:BoundField DataField="OrderDate" HeaderText="Order Date" ShowHeader="true" HeaderStyle-CssClass="sorting_desc"/>
                    <asp:BoundField DataField="OrderQty" HeaderText="Ordered Qty" ShowHeader="true" HeaderStyle-CssClass="sorting_desc"/>
                    <asp:BoundField DataField="GrandTotal" HeaderText="Grand Total" ShowHeader="true" HeaderStyle-CssClass="sorting_desc"/>
                     <asp:BoundField DataField="Vendor" HeaderText="Supplier" ShowHeader="true" HeaderStyle-CssClass="sorting_desc"/>
                    <asp:BoundField DataField="PurchasedBy" HeaderText="Purchased By" ShowHeader="true" HeaderStyle-CssClass="sorting_desc"/>
                    <asp:TemplateField HeaderText="Action" ControlStyle-CssClass="vertical-td">
                        <ItemTemplate>                                 
                           <a href="PoInvoice.aspx?poNumber=<%#Eval("PoNumber")%>" class="btn bg-olive btn-xs" data-toggle="tooltip" data-placement="top" title="" data-original-title="View"><span class="glyphicon glyphicon-search"></span> </a>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                    <EmptyDataTemplate>
                        <asp:Label ID="lblEmptyMessage" runat="server" Text="No Records to Display"></asp:Label>
                    </EmptyDataTemplate>
                </asp:GridView>
                    
                </div>
                 <div class="row"><div class="col-sm-5"><div class="dataTables_info" id="example2_info" role="status" aria-live="polite">Showing 1 to 10 of 57 entries</div></div><div class="col-sm-7"><div class="dataTables_paginate paging_simple_numbers" id="example2_paginate"><ul class="pagination"><li class="paginate_button previous disabled" id="example2_previous"><a href="#" aria-controls="example2" data-dt-idx="0" tabindex="0">Previous</a></li><li class="paginate_button active"><a href="#" aria-controls="example2" data-dt-idx="1" tabindex="0">1</a></li><li class="paginate_button "><a href="#" aria-controls="example2" data-dt-idx="2" tabindex="0">2</a></li><li class="paginate_button "><a href="#" aria-controls="example2" data-dt-idx="3" tabindex="0">3</a></li><li class="paginate_button "><a href="#" aria-controls="example2" data-dt-idx="4" tabindex="0">4</a></li><li class="paginate_button "><a href="#" aria-controls="example2" data-dt-idx="5" tabindex="0">5</a></li><li class="paginate_button "><a href="#" aria-controls="example2" data-dt-idx="6" tabindex="0">6</a></li><li class="paginate_button next" id="example2_next"><a href="#" aria-controls="example2" data-dt-idx="7" tabindex="0">Next</a></li></ul></div></div></div>
          
                <!-- / Table -->

            </div>
            <!-- /.box-body -->
        </div>
        <!-- /.box -->
    </div>
            </section>
        </div>
</asp:Content>
