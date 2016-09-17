<%@ Page Language="C#" MasterPageFile="~/InventoryChild.Master"
    AutoEventWireup="true" CodeFile="ViewLocation.aspx.cs" Inherits="FORMS_Admin_Forms_Item_location_ViewLocation"
    Title="View Loctaion" %>
<%@ MasterType VirtualPath="~/InventoryChild.Master" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">

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
                            <asp:GridView ID="grd" runat="server"></asp:GridView>
                            <asp:GridView ID="grdViewLoc" runat="server" OnRowCommand="grdViewLoc_RowCommand"
                                AutoGenerateColumns="False" DataKeyNames="Id" 
                                AllowPaging="True" HeaderStyle-CssClass="sorting_asc"
                                CssClass="table table-bordered table-hover dataTable"  ShowHeaderWhenEmpty="true">
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
                                                                     <asp:ButtonField ButtonType="Button" ControlStyle-CssClass="glyphicon glyphicon-search btn bg-olive btn-xs" CommandName="EditButton" Text="Edit" />

                                </Columns>
                             <EmptyDataTemplate>
                                    <asp:Label runat="server" ID="lblNoRecords" Text="No records to display"></asp:Label>
                                </EmptyDataTemplate>
                            </asp:GridView>
                            <!-- END EXAMPLE TABLE PORTLET-->
                        </div>

                    </div>

                </section>
            </div>
        </section>
    </div>

</asp:Content>
