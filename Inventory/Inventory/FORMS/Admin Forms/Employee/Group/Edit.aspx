<%@ Page Language="C#" MasterPageFile="~/InventoryChild.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="Inventory.FORMS.Admin_Forms.Employee.Group.Edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">

      <!-- Content Wrapper. Contains page content -->
  <!-- Content Wrapper. Contains page content -->
  <div class="content-wrapper">
    <!-- Content Header (Page header) -->
    <section class="content-header">
      <h1>
        Edit Group
        <small>Optional description</small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i> Level</a></li>
        <li class="active">Here</li>
      </ol>
        </section>

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
                                                        User Name:
													
                                                    </label>
                                                    <div >
                                                       <select id="Select3"  style="width: 232px;" >
                                <option selected="selected"></option>
                            </select><br />
                                                                             </div>
                                                </div>
                                                <div class="form-group">
                                                    <label class="col-md-2 control-label">
                                                        Group Name:
													
                                                    </label>
                                                    <div >
                                                       <input id="txtGroupName" style="width: 232px; position: relative" type="text"  runat="server"/><br />
                                                                             </div>
                                                </div>
                                                <div class="form-group">
                                                    <label class="col-md-2 control-label">
                                                        Group Authority:
													<span class="required">*
                                                    </span>
                                                    </label>
                                                    <div >
                                                      <select id="selectAuthority" style="position: relative;left:20px; width:232px" onclick="return selectAuthority_onclick()">
                                <option selected="selected"></option>
                            </select>                                                 </div>
                                                </div>
                                                
                                                <div class="actions btn-set">
                                                     <input id="btnEditGroup" style="position: relative; left: 8px; top: 0px;" type="button" value="Edit Group" />
                                                     <input id="btnReset" style="position: relative; left: 8px; top: 0px;" type="button" value="Reset" />
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    
                </div>
            </div>
            </section>
      <!-- Your Page Content Here -->

   
  <!-- /.content -->
  </div>
  <!-- /.content-wrapper -->


</asp:Content>

