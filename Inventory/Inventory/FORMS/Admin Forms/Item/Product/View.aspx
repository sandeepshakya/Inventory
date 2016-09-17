<%@ Page Language="C#" MasterPageFile="~/InventoryChild.Master" AutoEventWireup="true" CodeBehind="View.aspx.cs" Inherits="Inventory.FORMS.Admin_Forms.Item.Product.View" %>

<%@ MasterType VirtualPath="~/InventoryChild.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="Server">

    <div class="content-wrapper">
        <!-- Content Header (Page header) -->
        <section class="content-header">
            <h1>Product View
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
                       
                        <div class="box-body">
                            <asp:GridView ID="grdViewProduct"  CssClass="table table-bordered table-striped dataTable" runat="server" 
                               OnPageIndexChanging="grdViewProduct_PageIndexChanging" 
                                OnRowCommand="grdViewProduct_RowCommand" 
                                AutoGenerateColumns="False" ShowHeaderWhenEmpty ="true" DataKeyNames="Id" Width="100%"  >

                               <AlternatingRowStyle CssClass="odd" />
                                <Columns>
                                    <asp:BoundField DataField="Id" HeaderText="" Visible="false"  ShowHeader="true" HeaderStyle-CssClass="sorting_desc"/>
                                    <asp:BoundField DataField="Number" HeaderText="Code" ShowHeader="true" HeaderStyle-CssClass="sorting_desc"/>                                       
                                    <asp:BoundField DataField="ProductName" HeaderText="Name" ShowHeader="true" HeaderStyle-CssClass="sorting_desc"/>
                                    <asp:BoundField DataField="Category" HeaderText="Category" ShowHeader="true" HeaderStyle-CssClass="sorting_desc"/>
                                    <asp:BoundField DataField="SubCategory" HeaderText="Sub Category" ShowHeader="true" HeaderStyle-CssClass="sorting_desc"/>
                                    <asp:BoundField DataField="Quantity" HeaderText="Stock" ShowHeader="true" HeaderStyle-CssClass="sorting_desc"/>
                                    <asp:BoundField DataField="Location" HeaderText="Ware House Location" ShowHeader="true" HeaderStyle-CssClass="sorting_desc"/>
                                    <asp:BoundField DataField="ProductCost" HeaderText="Price" ShowHeader="true" HeaderStyle-CssClass="sorting_desc"/>
                                    <asp:BoundField DataField="NotifyLowQuantity" HeaderText="Status" ShowHeader="true" HeaderStyle-CssClass="sorting_desc">
                                        <ItemStyle Font-Bold="True" ForeColor="Blue" />
                                    </asp:BoundField>
                                    <asp:TemplateField HeaderText="Image" ShowHeader="true" HeaderStyle-CssClass="sorting_desc">
                                        <ItemTemplate>
                                            <asp:Image ID="CompanyLogo" ImageUrl='<%#Eval("ImageUrl")%>' runat="server" Height="50px" Width="50px" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:ButtonField ButtonType="Button" ControlStyle-CssClass="glyphicon glyphicon-search btn bg-olive btn-xs" CommandName="EditButton" Text="Edit" />
                                <asp:TemplateField>
                                        <ItemTemplate>
                                          
                                                <asp:LinkButton ID="linkDelete" OnClientClick="return ConfirmOnDelete();" OnClick="LinkDeleteClick" CssClass="btn btn-danger btn-xs" runat="server">Delete</asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>

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

</asp:Content>
