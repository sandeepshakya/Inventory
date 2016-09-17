<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="FORMS_Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Inventory Management System</title>
    <link href="../CSS/style.css" type="text/css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <table width="100%" border="0" height="400px" cellspacing="5">
            <tr bordercolorlight="blue">
                <td width="100%" colspan="2" style="height: 103px">
                    <asp:Image ID="Image2" runat="server" ImageAlign="Top" ImageUrl="~/Images/Name.JPG"
                        Height="101px" Width="100%" /></td>
            </tr>
            <tr bordercolorlight="blue" height="300px">
                <td width="35%" style="vertical-align: top; height: 300px;">
                    <table width="100%" align="center" border="1" height="300px" style="border-right: #3399ff thin solid;
                        border-top: #3399ff thin solid; border-left: #3399ff thin solid; border-bottom: #3399ff thin solid">
                        <tr height="25px">
                            <td colspan="2" style="text-align: center">
                                <asp:Label ID="Label1" runat="server" Font-Names="Verdana" Font-Size="Medium" ForeColor="Maroon"
                                    Text="We Provide Best Solution For Online Inventory Management" Font-Bold="True"></asp:Label></td>
                        </tr>
                        <tr height="75px">
                            <td align="center">
                                <marquee behavior="alternate" scrolldelay="100" style="font-size: 11pt; font-family: Verdana">
                                    Providing These Facilities To Our Users</marquee>
                            </td>
                        </tr>
                        <tr height="200px">
                            <td align="center" style="text-align: left">
                                <asp:Image ID="Image1" runat="server" Height="190px" ImageAlign="Top" ImageUrl="~/Images/Inventory Images/initialdiv.jpg"
                                    Width="100%" /></td>
                        </tr>
                    </table>
                </td>
                <td style="vertical-align: top; width: 35%; height: 300px;">
                    <table width="100%" align="center" border="1" height="310px" style="border-right: #3399ff thin solid;
                        border-top: #3399ff thin solid; border-left: #3399ff thin solid; border-bottom: #3399ff thin solid">
                        <tr><td>
                            <div style="text-align: center; vertical-align: top;">
                                <table style="border-right: #99ccff thin solid; border-top: #99ccff thin solid; font-size: 10pt; border-left: #99ccff thin solid; border-bottom: #99ccff thin solid; font-family: Verdana; vertical-align: top;">
                                    <tr>
                                        <td style="width: 100px">
                                            <asp:ImageButton ID="ImageButton1" PostBackUrl="~/FORMS/System Admin/SystemAdminLogin.aspx" runat="server" ImageUrl="~/CSS/SysAdminCss/SysAdminImg/Admin.PNG"
                                                Width="50px" /></td>
                                    </tr>
                                    <tr>
                                        <td style="width: 100px">
                                            <asp:LinkButton ID="lnkbtnSysAdm" PostBackUrl="~/FORMS/System Admin/SystemAdminLogin.aspx" runat="server" Font-Underline="False" ForeColor="#804000" Width="105px">System Admin</asp:LinkButton></td>
                                    </tr>
                                    <tr>    
                                        <td style="width: 100px">
                                            <asp:ImageButton ID="ImageButton2" PostBackUrl="~/FORMS/Admin Forms/AdminLogin.aspx" runat="server" ImageUrl="~/Images/admin-icon.jpg"
                                                Width="50px" /></td>
                                    </tr>
                                    <tr>
                                        <td style="width: 100px">
                                            <asp:LinkButton ID="lnkbtnComAdm" PostBackUrl="~/FORMS/Admin Forms/AdminLogin.aspx" runat="server" Font-Underline="False" ForeColor="#804000" Width="105px">Company Admin</asp:LinkButton></td>
                                    </tr>
                                    <tr>
                                        <td style="width: 100px">
                                            <asp:ImageButton ID="ImageButton3" PostBackUrl="~/FORMS/Admin Forms/AdminLogin.aspx" runat="server" ImageUrl="~/Images/user.JPG" Width="60px" /></td>
                                    </tr>
                                    <tr>
                                        <td style="width: 100px">
                                            <asp:LinkButton ID="lnkbtnUser" PostBackUrl="~/FORMS/Admin Forms/AdminLogin.aspx" runat="server" Font-Underline="False" ForeColor="#804000" Width="105px">User</asp:LinkButton></td>
                                    </tr>
                                </table>
                            </div>
                               <asp:Label ID="Label4" runat="server" Font-Bold="False" Font-Names="Verdana" Font-Size="Medium"
                                    Text="New Registration--"></asp:Label>
                            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/FORMS/CompanyRegistration.aspx"
                                        CausesValidation="False" Font-Names="Verdana" Font-Size="Medium" ForeColor="CornflowerBlue">Click Here</asp:LinkButton></td></tr>
                    
                    </table>
                </td>
               <%-- <td width="50%" style="vertical-align: top; height: 300px;">
                    <marquee direction="up" style="width: 80%; font-size: 12pt; color: #333366;" scrolldelay="200">
                        # Welcome To Invetory Maagement System......<br>
                        # Your Online Inventory Solution....</marquee>
                </td>--%>
            </tr>
        </table>
        <table style="border-right: #3399ff thin solid; border-top: #3399ff thin solid; border-left: #3399ff thin solid; border-bottom: #3399ff thin solid" width="100%"; cellspacing="15">
            <tr>
                <td style="border-right: #cc99cc thin solid; border-top: #cc99cc thin solid; border-left: #cc99cc thin solid; border-bottom: #cc99cc thin solid; width:500px; text-align: left;">
                    <asp:Label ID="Label5" runat="server" Text="About Inventory Management System" Font-Names="Verdana"
                        Font-Size="Medium" ForeColor="MidnightBlue" Font-Bold="True"></asp:Label></td>
                <td style="border-right: #cc99cc thin solid; border-top: #cc99cc thin solid; border-left: #cc99cc thin solid; border-bottom: #cc99cc thin solid; width:500px; text-align: left;">
                    <asp:Label ID="Label6" runat="server" Text="Main Features" Font-Names="Verdana" Font-Size="Medium"
                        ForeColor="MidnightBlue" Font-Bold="True"></asp:Label></td>
            </tr>
            <tr>
                <td style="text-align: left; font-size: 11pt; color: #003333; font-family: Verdana;
                    height: 219px;border-right: #cc66cc thin solid; border-top: #cc66cc thin solid; border-left: #cc66cc thin solid; border-bottom: #cc66cc thin solid; vertical-align: text-top; line-height: normal;">
                        Inventory Management System is a system that
                        performs the functions of Purchases, Sales and payments. This system will guide
                        through creation of vendors list, purchase orders, products list, receiving lists,
                        sales orders, invoices, and sale and payment receipts. Work orders for creation
                        inventory assemblies, customers and vendors balances and various types of reports
                        for monitoring your business.Inventory Management System works as single application
                        as client server system and as distribution database system.
                </td>
                <td style="text-align: left; font-size: 11pt; color: #003333; font-family: Verdana;
                    height: 219px;border-right: #cc66cc thin solid; border-top: #cc66cc thin solid; border-left: #cc66cc thin solid; border-bottom: #cc66cc thin solid; vertical-align: text-top; line-height: normal;">
                    • To identify and track all data processing assets in an Inventory System Repository<br />
                    • To define the process by which assets are identified and maintained in the Inventory
                    System.
                    <br />
                    • To provide Inventory System access to all necessary personal (Data entry, Update
                    and deletion).
                    <br />
                    • To provide a full range of reports that will satisfy informational requirements.
                    <br />
                    • To document the Inventory Management System within the Standards and Procedures
                    Manual.
                    <br />
                    • To provide training to personnel responsible for supporting the Inventory Management
                    System.
                </td>
            </tr>
        </table>
        <table width="100%">
            <tr>
                <td align="center" valign="baseline">
                    <img src="../Images/Inventory Images/Footer.JPG" style="width: 80%" height="110" /></td>
            </tr>
        </table>
    </form>
</body>
</html>
