<%@ Page Language="C#" MasterPageFile="~/InventoryChild.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="Inventory.FORMS.Admin_Forms.Item.Product.Add" %>

<%@ MasterType VirtualPath="~/InventoryChild.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="Server">
    <script type="text/javascript">
        function ShowImagePreview(input) {

            if (input.files && input.files[0]) {
                var reader = new FileReader();
                reader.onload = function (e) {
                    $('#<%=flImageUploader.ClientID%>').prop('src', e.target.result);
                };
                reader.readAsDataURL(input.files[0]);
                }
            }
    </script>

    <div class="content-wrapper">
        <section class="content-header">
            <h1><asp:Literal ID="ltrlTitle" runat="server"></asp:Literal>
        <small>Optional description</small>
            </h1>
            <ol class="breadcrumb">
                <li><a href="#"><i class="fa fa-dashboard"></i>Level</a></li>
                <li class="active">Here</li>
            </ol>
        </section>
        <section class="content">
            <div class="row">
                <div class="box">
                    <div class="box-body">
                        <div class="box-body">
                            <div class="tab-content">
                                <div id="home" class="tab-pane fade in active">
                                    <div class="form-group">
                                        <asp:Label ID="Label3" runat="server" Text="Catagory *" CssClass="labelstyle"></asp:Label>
                                    </div>
                                    <div class="form-group">
                                        <asp:DropDownList ID="ddlCat" Width="120px" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlCat_SelectedIndexChanged">
                                        </asp:DropDownList>
                                        <asp:RequiredFieldValidator ID="rqCat" runat="server" ErrorMessage="*" CssClass="ui-state-error-text" InitialValue="0" ControlToValidate="ddlCat"></asp:RequiredFieldValidator>
                                    </div>
                                    <div class="form-group">
                                        <asp:Label ID="Label4" runat="server" Text="Sub Catagory *" CssClass="labelstyle"></asp:Label>
                                    </div>
                                    <div class="form-group">
                                        <asp:DropDownList ID="ddlSubCat" Width="120px" runat="server"></asp:DropDownList>
                                        <asp:RequiredFieldValidator ID="rqSubCat" runat="server" ErrorMessage="*" CssClass="ui-state-error-text" InitialValue="0" ControlToValidate="ddlSubCat"></asp:RequiredFieldValidator>
                                    </div>
                                    <div class="form-group">
                                        <asp:Label ID="lblLocationId" runat="server" Text="Warehouse Location*" CssClass="labelstyle"></asp:Label>
                                    </div>
                                    <div class="form-group">
                                        <asp:DropDownList ID="ddlLocation" Width="120px" runat="server"></asp:DropDownList>
                                        <asp:RequiredFieldValidator ID="ddlLoc" runat="server" ErrorMessage="*" CssClass="ui-state-error-text" InitialValue="0" ControlToValidate="ddlLocation"></asp:RequiredFieldValidator>
                                    </div>
                                    <div class="form-group">
                                        <asp:Label ID="Label6" runat="server" Text="Product Name *" CssClass="labelstyle"></asp:Label>
                                    </div>
                                    <div class="form-group">
                                        <asp:TextBox ID="txtName" Width="520px" runat="server" placeholder="Product Name"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="rqName" runat="server" ErrorMessage="*" CssClass="ui-state-error-text" ControlToValidate="txtName"></asp:RequiredFieldValidator>
                                    </div>
                                    <div class="form-group">
                                        <asp:Label ID="Label2" runat="server" Text="Desc *" CssClass="labelstyle"></asp:Label>
                                    </div>
                                    <div class="form-group">
                                        <asp:TextBox ID="txtDesc" Width="500px" runat="server" placeholder="Desc"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="rqDesc" runat="server" ErrorMessage="*" CssClass="ui-state-error-text" ControlToValidate="txtDesc"></asp:RequiredFieldValidator>

                                    </div>

                                    <%--<div class="form-group">
                                            <asp:Label ID="Label5" runat="server" Text="Tax*" CssClass="labelstyle"></asp:Label>
                                        </div>
                                        <div class="form-group">
                                            <asp:TextBox ID="txtTax" runat="server" class="form-control" placeholder="Tax"></asp:TextBox>
                                        </div>--%>
                                    <div class="form-group">
                                        <asp:FileUpload ID="flImageUploader" Width="520px" runat="server" onchange="ShowImagePreview(this);" />
                                    </div>
                                    <div class="form-group">
                                        <asp:Image ID="imgProduct" runat="server" Width="50" Height="50" BorderColor="#367fa9" BorderStyle="Groove" />
                                    </div>
                                    <div class="form-group">
                                        <asp:Label ID="Label1" runat="server" Text="Price *" CssClass="labelstyle"></asp:Label>
                                    </div>
                                    <div class="form-group">
                                        <input type="number" id="txtPrice" width="120px" runat="server" placeholder="Price" />
                                        <asp:RequiredFieldValidator ID="rqtxtPrice" runat="server" ErrorMessage="*" CssClass="ui-state-error-text" ControlToValidate="txtPrice"></asp:RequiredFieldValidator>

                                    </div>
                                    <div class="form-group">
                                        <asp:Label ID="lbl" runat="server" Text="Quantity *" CssClass="labelstyle"></asp:Label>
                                    </div>
                                    <div class="form-group">
                                        <input type="number" id="txtQntity" width="120px" runat="server" placeholder="Quantity" />
                                        <asp:RequiredFieldValidator ID="rqtxtQntity" runat="server" ErrorMessage="*" CssClass="ui-state-error-text" ControlToValidate="txtQntity"></asp:RequiredFieldValidator>
                                    </div>
                                    <div class="form-group">
                                        <asp:Label ID="Label12" runat="server" Text="Notify Below Quantity *" CssClass="labelstyle"></asp:Label>
                                    </div>
                                    <div class="form-group">
                                        <input type="number" id="txtNotifyBelowQntity" runat="server" width="120px" />
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" CssClass="ui-state-error-text" ControlToValidate="txtNotifyBelowQntity"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <i class="fa fa-arrow-circle-right">
                                        <asp:Button ID="Btn_AddProduct" runat="server" OnClick="Btn_AddProduct_Click" class="pull-Left btn btn-default" Text="Save" />
                                    </i>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
    </div>


</asp:Content>
