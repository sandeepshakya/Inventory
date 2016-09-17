<%@ Page Language="C#" MasterPageFile="~/InventoryChild.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="Inventory.FORMS.Admin_Forms.SalesOrder.Add" %>

<%@ MasterType VirtualPath="~/InventoryChild.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="Server">
    <div class="content-wrapper">
        <section class="content-header">
            <h1>Salesorder
            </h1>
            <ol class="breadcrumb">
                <li><a href="#"><i class="fa fa-dashboard"></i>Level</a></li>
                <li class="active">Here</li>
            </ol>
        </section>
        <section class="content">
            <section class="content">
                <div class="row">
                    <div class="col-sm-12">

                        <div class="box box-primary">
                            <div class="box-header box-header-background with-border">
                                <h3 class="box-title ">Issue Salesorder to Customer</h3>
                            </div>
                            <div class="box-body">
                                <div class="row">
                                    <div class="col-md-8 col-sm-12">

                                        <div class="box  box-warning">
                                            <div class="box-header box-header-background-light with-border">
                                                <h3 class="box-title ">Select PO# :
                                                                                <asp:DropDownList ID="ddlSalesOrder" AutoPostBack="true" runat="server" OnSelectedIndexChanged="ddlSalesOrder_SelectedIndexChanged"></asp:DropDownList>

                                                </h3>
                                            </div>


                                            <div class="box-body order-panel">

                                                <ul id="tabs" class="nav nav-tabs" data-tabs="tabs">
                                                    <li class="active"><a href="#search-product" data-toggle="tab">Selected Orders:

                                                    </a></li>
                                                </ul>

                                                <div id="my-tab-content" class="tab-content">

                                                    <!-- ***************  Cart Tab Start ****************** -->
                                                    <div class="tab-pane active" id="product-list">
                                                        <input type="hidden" runat="server" id="hdnFieldBuyer" />
                                                         <div id="cart_content">
                                                            <asp:GridView ID="grdProductList" HeaderStyle-CssClass="sorting_asc"
                                                                runat="server"
                                                                AutoGenerateColumns="false" DataKeyNames="Id" ShowHeaderWhenEmpty="true"
                                                                CssClass="table table-bordered table-hover purchase-products dataTable no-footer">
                                                                <Columns>
                                                                    <asp:BoundField DataField="Id" Visible="false" ShowHeader="true" HeaderStyle-CssClass="sorting_desc"></asp:BoundField>
                                                                    <asp:BoundField DataField="ProductCode" HeaderText="Product#" ShowHeader="true" HeaderStyle-CssClass="sorting_desc"></asp:BoundField>
                                                                    <asp:BoundField DataField="Buyer" HeaderText="Buyer" ShowHeader="true" HeaderStyle-CssClass="sorting_desc"></asp:BoundField>
                                                                    <asp:BoundField DataField="ProductName" HeaderText="Product" ShowHeader="true" HeaderStyle-CssClass="sorting_desc"></asp:BoundField>
                                                                    <asp:BoundField DataField="OrderDate" HeaderText="Order Date" ShowHeader="true" HeaderStyle-CssClass="sorting_desc"></asp:BoundField>
                                                                    <asp:BoundField DataField="Quantity" HeaderText="Ordered Qty" ShowHeader="true" HeaderStyle-CssClass="sorting_desc"></asp:BoundField>
                                                                    <asp:BoundField DataField="UnitPrice" HeaderText="UnitPrice" ShowHeader="true" HeaderStyle-CssClass="sorting_desc"></asp:BoundField>
                                                                    <asp:BoundField DataField="Total" HeaderText="Total" ShowHeader="true" HeaderStyle-CssClass="sorting_desc"></asp:BoundField>
                                                                    <%--<asp:ButtonField CommandName="Buy" ControlStyle-CssClass="btn btn-primary btn-xs fa fa-shopping-cart" Text="" HeaderText="Issue" />--%>
                                                                </Columns>
                                                                <EmptyDataTemplate>
                                                                    <strong>No Records To Display</strong>
                                                                </EmptyDataTemplate>
                                                            </asp:GridView>


                                                            
                                                            <!-- / Table -->
                                                            
                                                        </div>
                                                         <div class="row"><div class="col-sm-5"><div class="dataTables_info" id="example2_info" role="status" aria-live="polite">Showing 1 to 10 of 57 entries</div></div><div class="col-sm-7"><div class="dataTables_paginate paging_simple_numbers" id="example2_paginate"><ul class="pagination"><li class="paginate_button previous disabled" id="example2_previous"><a href="#" aria-controls="example2" data-dt-idx="0" tabindex="0">Previous</a></li><li class="paginate_button active"><a href="#" aria-controls="example2" data-dt-idx="1" tabindex="0">1</a></li><li class="paginate_button "><a href="#" aria-controls="example2" data-dt-idx="2" tabindex="0">2</a></li><li class="paginate_button "><a href="#" aria-controls="example2" data-dt-idx="3" tabindex="0">3</a></li><li class="paginate_button "><a href="#" aria-controls="example2" data-dt-idx="4" tabindex="0">4</a></li><li class="paginate_button "><a href="#" aria-controls="example2" data-dt-idx="5" tabindex="0">5</a></li><li class="paginate_button "><a href="#" aria-controls="example2" data-dt-idx="6" tabindex="0">6</a></li><li class="paginate_button next" id="example2_next"><a href="#" aria-controls="example2" data-dt-idx="7" tabindex="0">Next</a></li></ul></div></div></div>
          
                                                    </div>

                                                </div>


                                            </div>
                                            <!-- /.box-body -->
                                        </div>
                                        <!-- /.box -->
                                    </div>
                                    <!--/.col end -->

                                    <!-- *********************** Purchase ************************** -->
                                    <div class="col-md-4 col-sm-12">

                                        <div class="box">
                                            <div class="box-header with-border box-header-background">
                                                <h3 class="box-title ">Order Summary</h3>
                                            </div>

                                            <div id="cart_summary">
                                                <div class="box-background">
                                                    <div class="box-body">
                                                        <div class="row">
                                                            <div class="col-md-12">


                                                                <div class="form-group">
                                                                    <label class="col-sm-5 control-label">Order No.</label>

                                                                    <div class="col-sm-7">
                                                                        <input type="text" id="salesOrderNumber" runat="server"  disabled="" class="form-control " />
                                                                    </div>
                                                                </div>

                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class="box-background" id="order">
                                                    <div class="box-body">
                                                        <div class="row">

                                                            <div class="col-md-12">


                                                                <div class="form-group">
                                                                    <label class="col-sm-5 control-label">Sub Total</label>

                                                                    <div class="col-sm-7">
                                                                        <input type="text" runat="server" id="txtSubTotal" disabled="" class="form-control unite" />
                                                                    </div>
                                                                </div>


                                                                <div class="form-group">
                                                                    <label class="col-sm-5 control-label">Tax</label>

                                                                    <div class="col-sm-7">
                                                                        <input type="text" value="0.00" disabled="" class="form-control unite" />
                                                                    </div>
                                                                </div>

                                                                <div class="form-group">
                                                                    <label class="col-sm-5 control-label">Discount</label>

                                                                    <div class="col-sm-7">
                                                                        <input type="text" value="0 %" disabled="" class="form-control unite" />
                                                                    </div>
                                                                </div>

                                                            </div>


                                                        </div>

                                                    </div>
                                                    <!-- /.box-body -->
                                                </div>



                                                <div class="box-body">
                                                    <div class="row">
                                                        <div class="col-md-12">
                                                            <div class="form-group">
                                                                <label class="col-sm-5 control-label" style="padding-top: 25px">Grand Total :</label>
                                                                <div class="col-sm-7">
                                                                    <h1>$<label id="lblGrandTotal" runat="server"></label></h1>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>

                                                <div class="box-background">
                                                    <div class="box-body">
                                                        <div class="row">
                                                            <div class="col-md-12">

                                                                <div class="form-group">
                                                                    <label class="col-sm-5 control-label">Payment Method</label>

                                                                    <div class="col-sm-7">
                                                                        <select name="payment_method" runat="server" class="form-control" id="order_payment_type">
                                                                            <option value="cash">Cash Payment</option>
                                                                            <option value="cheque">Cheque Payment</option>
                                                                            <option value="card">Credit Card</option>
                                                                            <option value="pending">Pending Order</option>
                                                                        </select>
                                                                    </div>
                                                                </div>
                                                            </div>

                                                            <div class="col-md-12" style="display: none" id="payment">

                                                                <div class="form-group">
                                                                    <label class="col-sm-5 control-label">cheque/card Ref.</label>

                                                                    <div class="col-sm-7">
                                                                        <input class="form-control" name="payment_ref" />
                                                                    </div>
                                                                </div>
                                                            </div>

                                                            <div class="col-md-12 order-panel" id="shipping">
                                                                <ul id="Ul1" class="nav nav-tabs" data-tabs="tabs">
                                                                    <li class="active"><a href="#note" data-toggle="tab">Order Note</a>
                                                                    </li>
                                                                    <li><a href="#shipping_address" data-toggle="tab">Shipping</a></li>
                                                                </ul>
                                                                <div id="Div1" class="tab-content">

                                                                    <!-- ***************  Cart Tab Start ****************** -->
                                                                    <div class="tab-pane active" id="note">
                                                                        <div class="form-group">
                                                                            <label>Order Note</label>
                                                                            <textarea class="form-control" name="note" runat="server" rows="3" placeholder="Enter ..." id="ck_editor" style="visibility: hidden; display: none;"></textarea><div id="cke_ck_editor" class="cke_1 cke cke_reset cke_chrome cke_editor_ck_editor cke_ltr cke_browser_webkit" dir="ltr" lang="en" role="application" aria-labelledby="cke_ck_editor_arialbl" style="width: 100%;">
                                                                                <span id="cke_ck_editor_arialbl" class="cke_voice_label">Rich Text Editor, ck_editor</span><div class="cke_inner cke_reset" role="presentation">
                                                                                    <span id="cke_1_top" class="cke_top cke_reset_all" role="presentation" style="height: auto"><span id="cke_11" class="cke_voice_label">Editor toolbars</span><span id="cke_1_toolbox" class="cke_toolbox" role="group" aria-labelledby="cke_11" onmousedown="return false;"></span></span><div id="cke_1_contents" class="cke_contents cke_reset" role="presentation" style="height: 100px;">
                                                                                        <span id="cke_16" class="cke_voice_label">Press ALT 0 for help</span><iframe src="" frameborder="0" class="cke_wysiwyg_frame cke_reset" title="Rich Text Editor, ck_editor" aria-describedby="cke_16" tabindex="0" allowtransparency="true" style="width: 296px; height: 100%;"></iframe>
                                                                                    </div>
                                                                                    <span id="cke_1_bottom" class="cke_bottom cke_reset_all" role="presentation"><span id="cke_1_resizer" class="cke_resizer cke_resizer_vertical cke_resizer_ltr" title="Resize" onmousedown="CKEDITOR.tools.callFunction(0, event)">◢</span><span id="cke_1_path_label" class="cke_voice_label">Elements path</span><span id="cke_1_path" class="cke_path" role="group" aria-labelledby="cke_1_path_label"><span class="cke_path_empty">&nbsp;</span></span></span>
                                                                                </div>
                                                                            </div>
                                                                            <script type="text/javascript" src="http://easy-inventory.codeslab.net/asset/js/ckeditor/ckeditor.js"></script>
                                                                            <script type="text/javascript">CKEDITOR_BASEPATH = 'http://easy-inventory.codeslab.net/asset/js/ckeditor/';</script>
                                                                            <script type="text/javascript">
                                                                                CKEDITOR.replace('ck_editor', { toolbar: 'Full', width: '100%', height: '100px' });</script>
                                                                        </div>
                                                                    </div>

                                                                    <div class="tab-pane" id="shipping_address">
                                                                        <div class="form-group">
                                                                            <label>Shipping Address</label>
                                                                            <textarea class="form-control" rows="3" name="shipping_address" placeholder="Enter ..." id="ck_editor2" style="visibility: hidden; display: none;">
                                                                                
                                                                            </textarea>
                                                                            <div id="cke_ck_editor2" class="cke_2 cke cke_reset cke_chrome cke_editor_ck_editor2 cke_ltr cke_browser_webkit" dir="ltr" lang="en" role="application" aria-labelledby="cke_ck_editor2_arialbl" style="width: 100%;">
                                                                                <span id="cke_ck_editor2_arialbl" class="cke_voice_label">Rich Text Editor, ck_editor2</span>
                                                                                <div class="cke_inner cke_reset" role="presentation">
                                                                                    <span id="cke_2_top" class="cke_top cke_reset_all" role="presentation" style="height: auto"><span id="cke_24" class="cke_voice_label">Editor toolbars</span><span id="cke_2_toolbox" class="cke_toolbox" role="group" aria-labelledby="cke_24" onmousedown="return false;"></span></span>
                                                                                    <div id="cke_2_contents"  runat="server" class="cke_contents cke_reset" role="presentation" style="height: 100px;">
                                                                                        <span id="cke_28" class="cke_voice_label">Press ALT 0 for help</span>
                                                                                        <iframe src="" frameborder="0" class="cke_wysiwyg_frame cke_reset" title="Rich Text Editor, ck_editor2" aria-describedby="cke_28" 
                                                                                            tabindex="0" allowtransparency="true" style="width: 0px; height: 100%;">

                                                                                           </iframe>
                                                                                    </div>
                                                                                    <span id="cke_2_bottom" class="cke_bottom cke_reset_all" role="presentation"><span id="cke_2_resizer" class="cke_resizer cke_resizer_vertical cke_resizer_ltr" title="Resize" onmousedown="CKEDITOR.tools.callFunction(5, event)">◢</span><span id="cke_2_path_label" class="cke_voice_label">Elements path</span><span id="cke_2_path" class="cke_path" role="group" aria-labelledby="cke_2_path_label"><span class="cke_path_empty">&nbsp;</span></span></span>
                                                                                </div>
                                                                            </div>
                                                                            <script type="text/javascript">
                                                                                CKEDITOR.replace('ck_editor2', { toolbar: 'Full', width: '100%', height: '100px' });</script>
                                                                        </div>
                                                                    </div>
                                                                </div>


                                                            </div>
                                                        </div>
                                                    </div>


                                                    <div class="box-body">
                                                        <div class="row">
                                                            <div class="col-md-12">
                                                                <asp:Button ID="btn_order" Text="Submit Order" runat="server" CssClass ="btn bg-navy btn-block " OnClick="btn_order_Click" />
                                                                                                                                 
                                                            </div>
                                                        </div>
                                                    </div>

                                                    <!-- hidden field -->

                                                 
                                                </div>
                                                

                                            </div>
                                            <!-- /.box -->

                                        </div>
                                        <!--/.col end -->


                                    </div>
                                    <!-- /.row -->


                                </div>
                                <!-- /.box-body -->
                            </div>
                            <!-- /.box -->
                        </div>
                        <!--/.col end -->
                    </div>
                    <!-- /.row -->

                </div>
            </section>

        </section>
    </div>
</asp:Content>
