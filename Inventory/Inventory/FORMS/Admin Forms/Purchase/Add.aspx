<%@ Page Language="C#" MasterPageFile="~/InventoryChild.Master"
    AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="Inventory.FORMS.Admin_Forms.Purchase.Add" %>

<%@ MasterType VirtualPath="~/InventoryChild.Master" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
       <div class="content-wrapper">
        <!-- Content Header (Page header) -->
        <section class="content-header">
            <h1>Add Purchase
        <small>Optional description</small>
            </h1>
            <ol class="breadcrumb">
                <li><a href="#"><i class="fa fa-dashboard"></i>Level</a></li>
                <li class="active">Here</li>
            </ol>
        </section>

        <!-- Main content -->
        <section class="content">
    <div>
        <div class="box-body">
            <div class="row">
                <div class="col-md-6 col-sm-12">

                    <div class="box box-warning">
                        <div class="box-header box-header-background-light with-border">
                            <h3 class="box-title ">Select Product</h3>
                        </div>


                        <div class="box-body">

                            <ul id="tabs" class="nav nav-tabs" data-tabs="tabs">
                                <li class="active"><a href="#product-list" data-toggle="tab">Product List</a>
                                </li>
                            </ul>


                            <div id="my-tab-content" class="tab-content">

                                <!-- ***************  General Tab Start ****************** -->
                                <div class="tab-pane active" id="product-list">

                                    <!-- Table -->
                                    <div id="dataTables-example_wrapper" class="dataTables_wrapper form-inline" role="grid">
                                        <div class="row ">
                                            <div class="col-sm-5">
                                                <div class="dataTables_length" id="dataTables-example_length">
                                                </div>
                                            </div>
                                        </div>
                                        <asp:GridView ID="grdProductList" OnRowCommand="grdProductList_RowCommand"
                                            HeaderStyle-Font-Bold="true" Style="width: 45%" runat="server"
                                            AutoGenerateColumns="false" DataKeyNames="Id"
                                            CssClass="table table-bordered table-hover purchase-products dataTable no-footer"  HeaderStyle-CssClass="sorting_asc">
                                            <AlternatingRowStyle CssClass="odd" />
                                <Columns>
                                                <asp:BoundField DataField="Id" Visible="false" ShowHeader="true" HeaderStyle-CssClass="sorting_desc"></asp:BoundField>
                                                <asp:BoundField DataField="Number" HeaderText="Product Code" ShowHeader="true" HeaderStyle-CssClass="sorting_desc"></asp:BoundField>
                                                <asp:BoundField DataField="ProductName" HeaderText="Product Name" ShowHeader="true" HeaderStyle-CssClass="sorting_desc"></asp:BoundField>
                                                <asp:BoundField DataField="Location" HeaderText="Warehouse Location" ShowHeader="true" HeaderStyle-CssClass="sorting_desc"></asp:BoundField>
                                                <asp:BoundField DataField="Quantity" HeaderText="Inventory" ShowHeader="true" HeaderStyle-CssClass="sorting_desc"></asp:BoundField>
                                                <asp:ButtonField CommandName="Buy" ControlStyle-CssClass="btn btn-primary btn-xs fa fa-shopping-cart" Text="" HeaderText="Purchase" />
                                            </Columns>
                                        </asp:GridView>
                                    </div>
                                     <div class="row"><div class="col-sm-5"><div class="dataTables_info" id="example2_info" role="status" aria-live="polite">Showing 1 to 10 of 57 entries</div></div><div class="col-sm-7"><div class="dataTables_paginate paging_simple_numbers" id="example2_paginate"><ul class="pagination"><li class="paginate_button previous disabled" id="example2_previous"><a href="#" aria-controls="example2" data-dt-idx="0" tabindex="0">Previous</a></li><li class="paginate_button active"><a href="#" aria-controls="example2" data-dt-idx="1" tabindex="0">1</a></li><li class="paginate_button "><a href="#" aria-controls="example2" data-dt-idx="2" tabindex="0">2</a></li><li class="paginate_button "><a href="#" aria-controls="example2" data-dt-idx="3" tabindex="0">3</a></li><li class="paginate_button "><a href="#" aria-controls="example2" data-dt-idx="4" tabindex="0">4</a></li><li class="paginate_button "><a href="#" aria-controls="example2" data-dt-idx="5" tabindex="0">5</a></li><li class="paginate_button "><a href="#" aria-controls="example2" data-dt-idx="6" tabindex="0">6</a></li><li class="paginate_button next" id="example2_next"><a href="#" aria-controls="example2" data-dt-idx="7" tabindex="0">Next</a></li></ul></div></div></div>
          
                                    <!-- / Table -->

                                </div>
                            </div>


                        </div>
                        <!-- /.box-body -->
                    </div>
                    <!-- /.box -->
                </div>
                <!--/.col end -->

                <!-- *********************** Purchase ************************** -->
                <div class="col-md-6 col-sm-12">

                    <div class="box box-info">
                        <div class="box-header box-header-background-light with-border">
                            <h3 class="box-title  ">Purchase Order</h3>
                        </div>

                        <div class="box-background">
                            <div class="box-body">
                                <div class="row">

                                    <div class="col-md-6">
                                        <label>Supplier</label>
                                        <asp:DropDownList ID="ddlSupplier" runat="server" class="form-control"></asp:DropDownList>
                                    </div>

                                </div>

                            </div>
                            <!-- /.box-body -->
                        </div>


                        <div class="box-footer">
                        </div>

                        <!-- Table -->
                        <div id="Div1">
                            <asp:GridView ShowHeaderWhenEmpty="true" ID="Table2" OnRowDataBound="Table2_RowDataBound" runat="server" DataKeyNames="Id" AutoGenerateColumns="false"
                                 ShowFooter="true" FooterStyle-BorderStyle="None" FooterStyle-BorderWidth="0"
                                CssClass="table table-bordered table-hover dataTable" HeaderStyle-CssClass="sorting_asc"
                                HeaderStyle-Font-Bold="true">
                               <AlternatingRowStyle CssClass="odd" />
                                <Columns>
                                    <asp:BoundField DataField="Id" Visible="false" />
                                    <asp:BoundField DataField="Name" HeaderText="Product" ShowHeader="true" HeaderStyle-CssClass="sorting_desc" />    
                                    <asp:TemplateField HeaderText="Qty" ShowHeader="true" HeaderStyle-CssClass="sorting_desc">
                                        <ItemTemplate>
                                            <input type="number" class="qty" onfocusout="calculatePo();" id="txtQty" value='<%#Eval("Quantity")%>' style="width: 80px" runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Unit Price" ShowHeader="true" HeaderStyle-CssClass="sorting_desc">
                                        <ItemTemplate>
                                            <input type="number" class="unitPrice" value='<%#Eval("UnitPrice")%>' style="width: 80px" id="txtUnitPrice" runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Total" ShowHeader="true" HeaderStyle-CssClass="sorting_desc">
                                        <ItemTemplate>
                                            <asp:Label ID="lblTotal" CssClass="total" Text='<%#Eval("Total")%>' runat="server"></asp:Label>
                                        </ItemTemplate>
                                        <FooterTemplate>
                                         <strong>Grand Total:</strong>
                                            <asp:Label ID="lblGrandTotal" CssClass="grandTotal" Text='<%#Eval("GrgandTotal")%>' runat="server"></asp:Label>
                                        </FooterTemplate>
                                    </asp:TemplateField>                                    
                                    <asp:TemplateField HeaderText="Action">
                                        <ItemTemplate>
                                            <a href="#" id='<%#Eval("Id")%>'  class="btn btn-danger btn-xs" title="Delete" data-toggle="tooltip" data-placement="top" 
                                                onclick="deletePo(this.id)">
                                                <i class="fa fa-trash-o"></i></a>
                                        </ItemTemplate>
                                        <FooterTemplate>
                                        <asp:Button ID="btnPurchase" OnClick="btnPurchase_Click" ControlStyle-CssClass="btn btn-primary btn-xs fa fa-shopping-cart"  runat="server" Text="Purchase" />
                                        </FooterTemplate>
                                    </asp:TemplateField>

                                </Columns>
                                <EmptyDataTemplate>
                                    <asp:Literal ID="ltrlNoRecord" Text="No Records to Display" runat="server"></asp:Literal>
                                </EmptyDataTemplate>
                            </asp:GridView>
                            <!-- / Table -->
                        </div>


                    </div>
                    <!-- /.box -->

                </div>
                <!--/.col end -->


            </div>
            <!-- /.row -->

        </div>

    </div>
            </section>
           </div>

    <script type="text/javascript">
        $(function () {
            calculatePo();
            deletePo(id);
        });

        function calculatePo() {
            var grandTotal = $('#MainContent_Table2_lblGrandTotal'); //$(this).find('.grandTotal');
            var calgrandTotal = 0;

            $('#MainContent_Table2 tbody tr').not('.active').each(function () {
                var qty =  $(this).find('.qty').val();
                var unitPrice = $(this).find('.unitPrice').val();
                var total = $(this).find('.total');

                var calculateTotal = (qty * unitPrice);
                if (!isNaN(calculateTotal)) {
                    total.text('');
                    total.text(calculateTotal);

                    calgrandTotal += calculateTotal;
                    grandTotal.text('');
                    grandTotal.text(calgrandTotal);
                }
            });
        }

        function deletePo(id) {
            var isConfirmed = confirm('Are you sure want to delete this record ?');
            if (isConfirmed) {
                $.ajax({
                    type: "POST",
                    dataType: "json",
                    contentType: "application/json; charset=utf-8",
                    url: "../Purchase/Add.aspx/DeletePo",
                    data: JSON.stringify({ 'id': id }),
                    success: function (data) {
                        alert(data.d);
                        document.location = "Add.aspx";
                    },
                    error: function (data) {
                        alert(data.error);
                    }
                });
            }
        }

    </script>
</asp:Content>
