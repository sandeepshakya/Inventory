<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CompanyRegistration.aspx.cs" Inherits="Inventory.FORMS.CompanyRegistration" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Inventory Management System</title>
    <link href="../CSS/style.css" type="text/css" rel="stylesheet" />

     <meta charset="utf-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  
  <!-- Tell the browser to be responsive to screen width -->
  <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport">
  <!-- Bootstrap 3.3.6 -->
  <link rel="stylesheet" href="<%= Page.ResolveClientUrl("~/bootstrap/css/bootstrap.min.css") %>" />
  <!-- Font Awesome -->
  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.5.0/css/font-awesome.min.css">
  <!-- Ionicons -->
  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/ionicons/2.0.1/css/ionicons.min.css">
  <!-- Theme style -->
  <link rel="stylesheet" href="<%= Page.ResolveClientUrl("~/dist/css/AdminLTE.min.css") %>" />
  <!-- AdminLTE Skins. Choose a skin from the css/skins
       folder instead of downloading all of them to reduce the load. -->
  <link rel="stylesheet" href="<%= Page.ResolveClientUrl("~/dist/css/skins/_all-skins.min.css") %>" />
  <!-- iCheck -->
  <link rel="stylesheet" href="<%= Page.ResolveClientUrl("~/plugins/iCheck/flat/blue.css") %>" />
  <!-- Morris chart -->
  <link rel="stylesheet" href="<%= Page.ResolveClientUrl("~/plugins/morris/morris.css") %>" />
  <!-- jvectormap -->
  <link rel="stylesheet" href="<%= Page.ResolveClientUrl("~/plugins/jvectormap/jquery-jvectormap-1.2.2.css") %>" />
  <!-- Date Picker -->
  <link rel="stylesheet" href="<%= Page.ResolveClientUrl("~/plugins/datepicker/datepicker3.css") %>" />
  <!-- Daterange picker -->
  <link rel="stylesheet" href="<%= Page.ResolveClientUrl("~/plugins/daterangepicker/daterangepicker-bs3.css") %>" />
  <!-- bootstrap wysihtml5 - text editor -->
  <link rel="stylesheet" href="<%= Page.ResolveClientUrl("~/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.min.css") %>" />

    <link rel="stylesheet" href="<%= Page.ResolveClientUrl("~/plugins/datatables/dataTables.bootstrap.css") %>" />
  <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
  <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
  <!--[if lt IE 9]>
  <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
  <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
  <![endif]-->

 
</head>
<body  class="hold-transition skin-blue sidebar-mini">
    <form id="form1" runat="server">
        <div class="content-wrapper">
            <!-- Content Header (Page header) -->
           <section class="content-header">
            <h1>Company Registration
        <small>Optional description</small>
            </h1>
            
        </section>

            <!-- Main content -->
            <section class="content">

                  <div class="row">
                <div class="box">
                    <div class="box-body">
                        <div class="box-body">
                            <div class="tab-content">

                                <div>  <asp:Label ID="lblMsg" runat="server" Font-Bold="true" ForeColor="Green"></asp:Label>
                           </div>
                                <div id="home" class="tab-pane fade in active">
                                    <div class="form-group">
                                        <asp:Label ID="Label3" runat="server" Text="Name *" CssClass="labelstyle"></asp:Label>
                                    </div>
                                    <div class="form-group">
                                        <input id="txtCompanyName" style="position: relative; width: 240px;" type="text" runat="server" />
                            <asp:RequiredFieldValidator ID="rqCompanyName" runat="server" ControlToValidate="txtCompanyName" ErrorMessage="*" ForeColor="Tomato"></asp:RequiredFieldValidator>
                                    </div>
                                    </div>
                                <div  class="tab-pane fade in active">
                                    <div class="form-group">
                                        <asp:Label ID="Label1" runat="server" Text="Size *" CssClass="labelstyle"></asp:Label>
                                    </div>
                                    <div class="form-group">
                                        <input id="txtSize" style="position: relative; width: 240px;" type="text" runat="server" />
                            <asp:RequiredFieldValidator ID="rqSize" runat="server" ControlToValidate="txtCompanyName" txtSize="*" ForeColor="Tomato"></asp:RequiredFieldValidator>
                                    </div>
                                    </div>
                                <div  class="tab-pane fade in active">
                                    <div class="form-group">
                                        <asp:Label ID="Label2" runat="server" Text="Primary Contact Person* *" CssClass="labelstyle"></asp:Label>
                                    </div>
                                    <div class="form-group">
                                        <input id="txtPerson" style="position: relative; width: 240px;" type="text" runat="server" />
                            <asp:RequiredFieldValidator ID="rqtxtPerson" runat="server" ControlToValidate="txtPerson" txtSize="*" ForeColor="Tomato"></asp:RequiredFieldValidator>
                                    </div>
                                    </div>
                                <div  class="tab-pane fade in active">
                                    <div class="form-group">
                                        <asp:Label ID="Label4" runat="server" Text="Description" CssClass="labelstyle"></asp:Label>
                                    </div>
                                    <div class="form-group">
                                        <textarea id="txtDesc" style="position: relative; width: 240px; height: 40px;" runat="server"></textarea>                                    </div>
                                    </div>
                                <div  class="tab-pane fade in active">
                                    <div class="form-group">
                                        <asp:Label ID="Label5" runat="server" Text="Address*" CssClass="labelstyle"></asp:Label>
                                    </div>
                                    <div class="form-group">
                                        <textarea id="txtAddress" style="position: relative; width: 240px; height: 40px;" runat="server"></textarea>
                                         <asp:RequiredFieldValidator ID="rqtxtAddress" runat="server" ControlToValidate="txtAddress" ErrorMessage="*" ForeColor="Tomato"></asp:RequiredFieldValidator>

                                    </div>
                                    </div>
                                <div  class="tab-pane fade in active">
                                    <div class="form-group">
                                        <asp:Label ID="Label6" runat="server" Text="City*" CssClass="labelstyle"></asp:Label>
                                    </div>
                                    <div class="form-group">
                                       <input id="txtCity" style="position: relative; width: 240px;" type="text" runat="server" />
                                         <asp:RequiredFieldValidator ID="rqtxtCity" runat="server" ControlToValidate="txtCity" ErrorMessage="*" ForeColor="Tomato"></asp:RequiredFieldValidator>

                                    </div>
                                    </div>
                                <div  class="tab-pane fade in active">
                                    <div class="form-group">
                                        <asp:Label ID="Label7" runat="server" Text="State*" CssClass="labelstyle"></asp:Label>
                                    </div>
                                    <div class="form-group">
                                       <input id="txtState" style="position: relative; width: 240px;" type="text" runat="server" />
                                         <asp:RequiredFieldValidator ID="rqtxtState" runat="server" ControlToValidate="txtState" ErrorMessage="*" ForeColor="Tomato"></asp:RequiredFieldValidator>

                                    </div>
                                    </div>
                                <div  class="tab-pane fade in active">
                                    <div class="form-group">
                                        <asp:Label ID="Label8" runat="server" Text="Country*" CssClass="labelstyle"></asp:Label>
                                    </div>
                                    <div class="form-group">
                                         <input id="txtCountry" style="position: relative; width: 240px;" type="text" runat="server" />
                            <asp:RequiredFieldValidator ID="rqtxtCountry" runat="server" ControlToValidate="txtCountry" ErrorMessage="*" ForeColor="Tomato"></asp:RequiredFieldValidator>

                                    </div>
                                    </div>

                                <div  class="tab-pane fade in active">
                                    <div class="form-group">
                                        <asp:Label ID="Label9" runat="server" Text="Contact No*" CssClass="labelstyle"></asp:Label>
                                    </div>
                                    <div class="form-group">
                                         <input id="txtContactNo" style="position: relative; width: 240px;" type="text" runat="server" />
                            <asp:RequiredFieldValidator ID="rqtxtContactNo" runat="server" ControlToValidate="txtContactNo" ErrorMessage="*" ForeColor="Tomato"></asp:RequiredFieldValidator>

                                    </div>
                                    </div>

                                <div  class="tab-pane fade in active">
                                    <div class="form-group">
                                        <asp:Label ID="Label10" runat="server" Text="Email*" CssClass="labelstyle"></asp:Label>
                                    </div>
                                    <div class="form-group">
                                         <input id="txtEmail" style="position: relative; width: 240px;" type="text" runat="server" />
                            <asp:RequiredFieldValidator ID="rqtxtEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="*" ForeColor="Tomato"></asp:RequiredFieldValidator>

                                    </div>
                                    </div>

                                <div  class="tab-pane fade in active">
                                    <div class="form-group">
                                        <asp:Label ID="Label11" runat="server" Text="Web Url*" CssClass="labelstyle"></asp:Label>
                                    </div>
                                    <div class="form-group">
                                        <input id="txtUrl" style="position: relative; width: 240px;" type="text" runat="server" />
                                    </div>
                                    </div>

                                <div  class="tab-pane fade in active">
                                    <div class="form-group">
                                         <asp:Label ID="lblUploadImage" runat="server" Style="position: relative" Text="Upload Image"
                                Font-Names="Verdana"></asp:Label>
                                    </div>
                                    <div class="form-group">
                                        <input id="File1" style="position: relative" type="file" runat="server" />
                                    </div>
                                    </div>

                                 <div class="form-group">
                                    <i class="fa fa-arrow-circle-right">
                                       <asp:Button ID="btnSave" OnClick="btnSave_Click" runat="server" Style="position: relative" Text="Submit" /><input id="btnReset" style="position: relative" type="button" value="Reset" /></td>
                                    </i>
                                </div>
          </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
    </div>
       <footer class="main-footer">
     <strong>Copyright &copy; 2014-2015.</strong> All rights
    reserved.
  </footer>


    </form>

    <!-- ./wrapper -->
<%-- href="<%= Page.ResolveClientUrl("~/plugins/daterangepicker/daterangepicker-bs3.css") %>">--%>
   
<!-- jQuery 2.2.0 -->
<script src="<%= Page.ResolveClientUrl("~/plugins/jQuery/jQuery-2.2.0.min.js") %>"></script>
<!-- jQuery UI 1.11.4 -->
<script src="https://code.jquery.com/ui/1.11.4/jquery-ui.min.js"></script>
<!-- Resolve conflict in jQuery UI tooltip with Bootstrap tooltip -->
<script>
    $.widget.bridge('uibutton', $.ui.button);
</script>
<!-- Bootstrap 3.3.6 -->
<script src="<%= Page.ResolveClientUrl("~/bootstrap/js/bootstrap.min.js") %>"></script>
<!-- Morris.js charts -->
<script src="https://cdnjs.cloudflare.com/ajax/libs/raphael/2.1.0/raphael-min.js"></script>
<script src="<%= Page.ResolveClientUrl("~/plugins/morris/morris.min.js") %>"></script>
<!-- Sparkline -->
<script src="<%= Page.ResolveClientUrl("~/plugins/sparkline/jquery.sparkline.min.js") %>"></script>
<!-- jvectormap -->
<script src="<%= Page.ResolveClientUrl("~/plugins/jvectormap/jquery-jvectormap-1.2.2.min.js") %>"></script>
<script src="<%= Page.ResolveClientUrl("~/plugins/jvectormap/jquery-jvectormap-world-mill-en.js") %>"></script>
<!-- jQuery Knob Chart -->
<script src="<%= Page.ResolveClientUrl("~/plugins/knob/jquery.knob.js") %>"></script>
<!-- daterangepicker -->
<script src="https://cdnjs.cloudflare.com/ajax/libs/moment.js/2.11.2/moment.min.js") %>"></script>
<script src="<%= Page.ResolveClientUrl("~/plugins/daterangepicker/daterangepicker.js") %>"></script>
<!-- datepicker -->
<script src="<%= Page.ResolveClientUrl("~/plugins/datepicker/bootstrap-datepicker.js") %>"></script>
<!-- Bootstrap WYSIHTML5 -->
<script src="<%= Page.ResolveClientUrl("~/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.all.min.js") %>"></script>
<!-- Slimscroll -->
<script src="<%= Page.ResolveClientUrl("~/plugins/slimScroll/jquery.slimscroll.min.js") %>"></script>
<!-- FastClick -->
<script src="<%= Page.ResolveClientUrl("~/plugins/fastclick/fastclick.js") %>"></script>
<!-- AdminLTE App -->
<script src="<%= Page.ResolveClientUrl("~/dist/js/app.min.js") %>"></script>
<!-- AdminLTE dashboard demo (This is only for demo purposes) -->
<script src="<%= Page.ResolveClientUrl("~/dist/js/pages/dashboard.js") %>"></script>
<!-- AdminLTE for demo purposes -->
<script src="<%= Page.ResolveClientUrl("~/dist/js/demo.js") %>"></script>
</body>
</html>

