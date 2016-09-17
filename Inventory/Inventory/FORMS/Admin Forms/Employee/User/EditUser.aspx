<%@ Page Language="C#" MasterPageFile="~/InventoryChild.Master"
    AutoEventWireup="true" CodeFile="EditUser.aspx.cs" Inherits="Form_Admin_Employee_Management_User_Managemant_EditUser"
    Title="Edit User" %>
   <asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">

    <div class="content-wrapper">
    <!-- Content Header (Page header) -->
    <section class="content-header">
      <h1>
        Edit User
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
													<span class="required">*
                                                    </span>
                                                    </label>
                                                    <div class="col-md-10">
                                                       <input id="txtUserName" style="width: 232px; position: relative" type="text"  runat="server"/><br />
                                                                             </div>
                                                </div>
                                                <div class="form-group">
                                                    <label class="col-md-2 control-label">
                                                        User Type:
													<span class="required">*
                                                    </span>
                                                    </label>
                                                    <div >
                                                      <select id="selectUserType" style="position: relative;left:20px; width:232px" onclick="return selectUserType_onclick()">
                                <option selected="selected"></option>
                            </select>                                                 </div>
                                                </div>
                                                
                                                <div class="form-group">
                                                    <label class="col-md-2 control-label">
                                                        Old Password:
													<span class="required">*
                                                    </span>
                                                    </label>
                                                    <div >
                                                      <input id="txtOpwd" style="width: 232px; position: relative" type="text"  runat="server"/><br />                              </div>
                                                </div>

                                                  <div class="form-group">
                                                    <label class="col-md-2 control-label">
                                                        New Password:
													<span class="required">*
                                                    </span>
                                                    </label>
                                                    <div >
                                                      <input id="txtNpwd" style="width: 232px; position: relative" type="text"  runat="server"/><br />                              </div>
                                                </div>
                                                <div class="form-group">
                                                    <label class="col-md-2 control-label">
                                                        Retype Password:
													<span class="required">*
                                                    </span>
                                                    </label>
                                                    <div >
                                                      <input id="txtRpwd" style="width: 232px; position: relative" type="text"  runat="server"/><br />                              </div>
                                                </div>
                                                <div class="actions btn-set">
                                                     <input id="btnAddUser" style="position: relative; left: 8px; top: 0px;" type="button" value="Edit User" />
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

</asp:Content>
