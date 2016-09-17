
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SystemAdminLogin.aspx.cs" Inherits="Inventory.FORMS.System_Admin.SystemAdminLogin1" %>

<!DOCTYPE html>
<html>
<head>
  <meta charset="utf-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <title>System Admin Login-IMS</title>
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
     <form id="form1" runat="server">
<div class="login-box">
  <div class="login-logo">
    <a href="#"><b>Welcome System Admin</b></a>
  </div>
  <!-- /.login-logo -->
  <div class="login-box-body">
    <p class="login-box-msg">Sign in to start your session</p>

    
      <div class="form-group has-feedback">
         <asp:TextBox ID="txtUserName" runat="server" Font-Bold="True" Font-Names="Georgia"
                                        Font-Size="Small" ForeColor="Black" Width="150px"></asp:TextBox><br />
           <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*"
                                        ControlToValidate="txtUserName" SetFocusOnError="True"></asp:RequiredFieldValidator>
        <span class="glyphicon glyphicon-envelope form-control-feedback"></span>
      </div>
      <div class="form-group has-feedback">
         <asp:TextBox ID="txtPassword" runat="server" Font-Size="Small" ForeColor="Blue"
                                        TextMode="Password" Width="150px" Font-Names="Georgia"></asp:TextBox><br />
           <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*"
                                        ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
        <span class="glyphicon glyphicon-lock form-control-feedback"></span>
      </div>
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
             <asp:Button ID="btnLogin" runat="server" Style="position: relative" Text="Login" OnClick="btnLogin_Click1"  />
          <%-- <asp:ImageButton ID="btnLogin" runat="server" ImageUrl="~/CSS/img/login_button_01.jpg"
                                        Width="80px" ImageAlign="Middle" OnClick="btnLogin_Click" />--%>
            &nbsp;<br />
                                    <br />
        </div>
        <!-- /.col -->

          <div> 
                                    <asp:Label ID="lblError" runat="server" ForeColor="Red" Font-Names="Times New Roman"
                                        Font-Size="Large"></asp:Label>
                           </div>
      </div>
    

    <%--<div class="social-auth-links text-center">
      <p>- OR -</p>
      <a href="#" class="btn btn-block btn-social btn-facebook btn-flat"><i class="fa fa-facebook"></i> Sign in using
        Facebook</a>
      <a href="#" class="btn btn-block btn-social btn-google btn-flat"><i class="fa fa-google-plus"></i> Sign in using
        Google+</a>
    </div>--%>
    <!-- /.social-auth-links -->

    <a href="ResetPassword.aspx">I forgot my password</a><br>
    <a href="../CompanyRegistration.aspx" class="text-center">Register a new membership</a>

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







