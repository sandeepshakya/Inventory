<%@ Page Language="C#" MasterPageFile="~/InventoryChild.Master" AutoEventWireup="true" CodeBehind="SoInvoice.aspx.cs" Inherits="Inventory.FORMS.Admin_Forms.SalesOrder.Invoice" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <div class="content-wrapper">
        <!-- Content Header (Page header) -->
        <section class="content-header">
            <h1>SalesOrder Invoice
            </h1>
            <ol class="breadcrumb">
                <li><a href="#"><i class="fa fa-dashboard"></i>Level</a></li>
                <li class="active">Here</li>
            </ol>
        </section>

        <!-- Main content -->
        <section class="content">
            <div class="container-fluid">

                <div class="box">
                    <div class="box-header box-header-background with-border">
                        <%--<h3 class="box-title">Purchase Invoice</h3>--%>
                        <div class="box-tools pull-right">
                            <!-- Buttons, labels, and many other things can be placed here! -->
                            <!-- Here is a label for example -->
                            <div class="box-tools">
                                <div class="btn-group" role="group">
                                    <a onclick="print_invoice('printableArea')" class="btn btn-default ">Print</a>
                                    <a href="http://easy-inventory.codeslab.net/admin/purchase/pdf_invoice/53" class="btn btn-default ">PDF</a>
                                </div>
                            </div>

                        </div>
                        <!-- /.box-tools -->
                    </div>
                    <!-- /.box-header -->
                    <div class="box-body">
                        <div id="printableArea">
                            <link href="http://easy-inventory.codeslab.net/asset/css/invoice.css" rel="stylesheet" type="text/css">
                            <div class="row ">
                                <div class="col-md-8 col-md-offset-2">
                                    <main>
                                        <div id="details" class="clearfix">
                                            <div id="client">
                                                <div class="to">BUYER:</div>
                                                <h2 class="name" runat="server" id="divSupplierName"></h2>
                                                <div class="address" id="divSupplierAddress1" runat="server"></div>
                                                <div class="address" id="divSupplierAddress2" runat="server"></div>
                                                <div class="address" id="divSupplierPhone" runat="server"></div>
                                                <div class="email" id="divsupplierEmail" runat="server"></div>
                                            </div>
                                            <div id="invoice">
                                                <h1 id="soNumber" runat="server"></h1>
                                                <div class="date" id="divInvDate" runat="server"></div>
                                                <div class="date" id="divPurchasedBy" runat="server"></div>

                                            </div>
                                        </div>
                                        <div>
                                        <h1 id="poNumber" runat="server">PO# fbdx21259391FB </h1>
                                        </div>
                                        <table border="0" cellspacing="0" cellpadding="0">
                                            <thead>
                                                <tr>
                                                    <th class="no">INV. DATE</th>
                                                    <th class="no">MODE</th>
                                                    <th class="no">ORD. QTY</th>
                                                    <th class="no">APPR. QTY</th>
                                                    <th class="no">UN.PRICE</th>
                                                    <th class="no">TOTAL</th>
                                                </tr>
                                            </thead>
                                            <tbody id="tbody" runat="server">
                                            </tbody>
                                            <tfoot>
                                                <tr id="trFooter" runat="server">
                                                    <td colspan="2"></td>
                                                    <td colspan="2">SUBTOTAL</td>
                                                    <td id="tdSubTotal" runat="server"></td>
                                                </tr>
                                                <tr>
                                                </tr>
                                                <tr>
                                                    <td colspan="2"></td>
                                                    <td colspan="2">GRAND TOTAL</td>
                                                    <td id="tdGrandTotal" runat="server"></td>
                                                </tr>
                                            </tfoot>
                                        </table>

                                    </main>


                                </div>
                            </div>
                        </div>


                    </div>
                    <!-- /.box-body -->
                </div>
                <!-- /.box -->

            </div>
        </section>
    </div>
</asp:Content>
