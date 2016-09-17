﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="Inventory.FORMS.Admin_Forms.AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <meta charset="utf-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <title>Admin Login-IMS</title>
  <!-- Tell the browser to be responsive to screen width -->
  <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport">
  <!-- Bootstrap 3.3.6 -->
  <link rel="stylesheet" href="../../bootstrap/css/bootstrap.min.css">
  <!-- Font Awesome -->
  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.5.0/css/font-awesome.min.css">
  <!-- Ionicons -->
  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/ionicons/2.0.1/css/ionicons.min.css">
  <!-- Theme style -->
  <link rel="stylesheet" href="../../dist/css/AdminLTE.min.css">
  <!-- iCheck -->
  <link rel="stylesheet" href="../../plugins/iCheck/square/blue.css">

  <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
  <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
  <!--[if lt IE 9]>
  <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
  <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
  <![endif]-->
</head>

    <body class="hold-transition login-page">
     <form id="form2" runat="server">
<div class="login-box">
  <div class="login-logo">
    <a href="#"><b>Welcome System Admin</b></a>
  </div>
  <!-- /.login-logo -->
  <div class="login-box-body">
    <p class="login-box-msg">Sign in to start your session</p>

   
    <div> <div class="form-group has-feedback">
           <asp:Label ID="lblUsername" runat="server" Text="User-Name"></asp:Label></div>
      <div>
                                <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
        <span class="glyphicon glyphicon-envelope form-control-feedback"></span>
      </div></div> 
      <div>
      <div class="form-group has-feedback">
        
                                <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label></div>
      <div>
                                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox> <span class="glyphicon glyphicon-lock form-control-feedback"></span>
                            </div>
          
          </div>
       

     <div> <div class="form-group has-feedback">
                                <asp:Label ID="Label2" runat="server" Text="CompanyId"></asp:Label></div>
      <div>
                                <asp:TextBox ID="txtCompanyId" runat="server"></asp:TextBox>
                           <span class="glyphicon glyphicon-envelope form-control-feedback"></span>
      </div></div> 
     
      <div class="row">
        <%--<div class="col-xs-8">
          <div class="checkbox icheck">
            <label>
              <input type="checkbox"> Remember Me
            </label>
          </div>
        </div>--%>
        <!-- /.col -->
        <div class="col-xs-4">
          <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />&nbsp;<br />
                                    <br />
        </div>
        <!-- /.col -->

          <div> 
                                    <asp:Label ID="lblError" runat="server" Style="position: relative"></asp:Label>
                           </div>
      </div>
    

  
  </div>
  <!-- /.login-box-body -->
</div>
<!-- /.login-box -->

<!-- jQuery 2.2.0 -->
<script src="../../plugins/jQuery/jQuery-2.2.0.min.js"></script>
<!-- Bootstrap 3.3.6 -->
<script src="../../bootstrap/js/bootstrap.min.js"></script>
<!-- iCheck -->
<script src="../../plugins/iCheck/icheck.min.js"></script>
<script>
    $(function () {
        $('input').iCheck({
            checkboxClass: 'icheckbox_square-blue',
            radioClass: 'iradio_square-blue',
            increaseArea: '20%' // optional
        });
    });
</script>
         </form>
</body>


</html>
