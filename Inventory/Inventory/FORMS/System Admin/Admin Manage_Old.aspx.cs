using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Drawing;


public partial class FORMS_System_Admin_Admin_Manage : System.Web.UI.Page
{
  
    SystemAdmin objSuspend = new SystemAdmin();
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["username"] == null)
            {
                Response.Redirect("~/FORMS/System Admin/SystemAdminLogin.aspx");
            }
            else
            {
               // Master.AddText = "Manage User";
                if (!Page.IsPostBack)
                {
                    BindData();
                }
            }

        }
        catch (Exception ex)
        {
        }

        }
      
    protected void btnSuspendAdmin_Click(object sender, EventArgs e)
    {
       
            string CidList = null;
            for (int i = 0; i < gridAdminmanage.Rows.Count; i++)
            {
                CheckBox chk = (CheckBox)gridAdminmanage.Rows[i].Cells[0].Controls[1];
                if (chk.Checked)
                {
                    int key = Convert.ToInt32(gridAdminmanage.DataKeys[i].Value);
                    CidList = CidList + key + ",";
                    gridAdminmanage.Rows[i].Cells[5].ForeColor = Color.Tomato;
                    chk.Checked = false;
                }


            }
            try
            {
            objSuspend.CompanyIdLst = CidList;
            objSuspend.UserType = "Admin";
            objSuspend.OperateType = "Deactivate";
            objSuspend.Suspend();

            BindData();
        }
        catch (Exception ex)
        {
        }
           

    }

    protected void btnSuspendUser_Click(object sender, EventArgs e)
    {
       
            string CidList = null;
            for (int i = 0; i < gridAdminmanage.Rows.Count; i++)
            {
                CheckBox chk = (CheckBox)gridAdminmanage.Rows[i].Cells[0].Controls[1];
                if (chk.Checked)
                {
                    int key = Convert.ToInt32(gridAdminmanage.DataKeys[i].Value);
                    CidList = CidList + key + ",";
                    chk.Checked = false;
                }
            }
            try
            {
            objSuspend.CompanyIdLst = CidList;
            objSuspend.UserType = "User";
            objSuspend.OperateType = "Deactive";
            objSuspend.Suspend();

            BindData();
        }
        catch (Exception ex)
        {
        }


    }

    protected void btnAdmin_Click(object sender, EventArgs e)
    {

        try
        {
        string CidList = null;
        for (int i = 0; i < gridAdminmanage.Rows.Count; i++)
        {

            CheckBox chk = (CheckBox)gridAdminmanage.Rows[i].Cells[0].Controls[1];
           

                if (chk.Checked)
                {
                    int key = Convert.ToInt32(gridAdminmanage.DataKeys[i].Value);
                    CidList = CidList + key + ",";
                    //gridAdminmanage.Rows[i].Cells[5].BackColor = Color.White;
                    chk.Checked = false;
                }
            
        
            objSuspend.CompanyIdLst = CidList;
            objSuspend.UserType = "Admin";
            objSuspend.OperateType = "Active";
            objSuspend.Suspend();
            BindData();
        }
        }
catch(Exception ex)
        {
             }
            
        }

    protected void btnUser_Click(object sender, EventArgs e)
    {
        try
        {
            string CidList = null;
            for (int i = 0; i < gridAdminmanage.Rows.Count; i++)
            {
                CheckBox chk = (CheckBox)gridAdminmanage.Rows[i].Cells[0].Controls[1];
                if (chk.Checked)
                {
                    int key = Convert.ToInt32(gridAdminmanage.DataKeys[i].Value);
                    CidList = CidList + key + ",";
                    chk.Checked = false;
                }
            }
            
            objSuspend.CompanyIdLst = CidList;
            objSuspend.UserType = "User";
            objSuspend.OperateType = "Active";
            objSuspend.Suspend();

            BindData();
        }
        catch (Exception ex)
        {
        }
    }

    public void BindData()
    {

        try
        {
            ds = objSuspend.BlockStatus();
            gridAdminmanage.DataSource = ds;
            gridAdminmanage.DataBind();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                CheckBox chk = (CheckBox)gridAdminmanage.Rows[i].Cells[0].Controls[1];
                int clr = Convert.ToInt32(ds.Tables[0].Rows[i][3]);
                int j = Convert.ToInt32(ds.Tables[0].Rows[i][5]);
                int k = Convert.ToInt32(ds.Tables[0].Rows[i][6]);
                if (j == 0 || k == 0)
                {

                    if (j == 0)
                    {
                        gridAdminmanage.Rows[i].Cells[2].BackColor = Color.Tomato;
                    }
                    if (k == 0)
                    {
                        gridAdminmanage.Rows[i].Cells[3].BackColor = Color.Tomato;
                    }

                    int key = Convert.ToInt32(gridAdminmanage.DataKeys[i].Value);
                    //gridAdminmanage.Rows[i].Cells[2]. BackColor = Color.Red;

                }
            }
        }
        catch (Exception ex)
        {
        }
    }

    protected void btnFind_ServerClick(object sender, EventArgs e)
    {

    }

    private void SearchText()
    {
        try
        {
            DataTable dt = GetRecords();
            DataView dv = new DataView(dt);
            string SearchExpression = null;
            if (!String.IsNullOrEmpty(txtSearch.Text))
            {
                SearchExpression = string.Format("{0} '%{1}%'", gridAdminmanage.SortExpression, txtSearch.Text);

            }
            dv.RowFilter = "CompanyName like" + SearchExpression;
            gridAdminmanage.DataSource = dv;
            gridAdminmanage.DataBind();

        }
        catch (Exception ex)
        {
        }
    }
   

    private DataTable GetRecords()
    {
       
            ds = objSuspend.BlockStatus();
           
            gridAdminmanage.DataSource = ds;
            gridAdminmanage.DataBind();
            return ds.Tables[0];
        }
        
    
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        SearchText();
    }
    protected void btnRefresh_Click(object sender, EventArgs e)
    {
        BindData();
    }
    protected void gridAdminmanage_DataBound(object sender, EventArgs e)
    {

    }
    protected void gridAdminmanage_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            gridAdminmanage.PageIndex = e.NewPageIndex;
            BindData();
        }
        catch (Exception ex)
        {
        }
    }
    protected void txtSearch_TextChanged(object sender, EventArgs e)
    {
        SearchText();
    }
}
