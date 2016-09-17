<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Inventory.FORMS.System_Admin.Defau" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <asp:GridView ID="GridView1" runat="server" Style="position: relative" OnDataBound="GridView1_DataBound" >
        </asp:GridView>  
    </div>
    </form>
</body>
</html>
