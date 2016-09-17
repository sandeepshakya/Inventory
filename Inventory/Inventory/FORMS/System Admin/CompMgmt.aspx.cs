using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Service;

namespace Inventory.FORMS.System_Admin
{
    public partial class cmp : System.Web.UI.Page
    {        
        string str;
        string check;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("~/FORMS/System Admin/SystemAdminLogin.aspx");
            }

            ddlStatus.Visible = true;
            str = Request.QueryString["txt"];
            check = Request.QueryString["no"];
            var companyService = new CompanyService();

            if (!Page.IsPostBack)
            {

                if (str != null)
                {
                    //ddlStatus.Text = "Registered";
                    gridRegistered.Visible = true;
                    gridCompanies.Visible = false;
                    gridTrial.Visible = false;

                    var result = companyService.Search("Registered", str);

                    try
                    {
                        gridRegistered.DataSource = result;
                        gridRegistered.DataBind();
                        Request.QueryString.Remove("txt");

                    }
                    catch (Exception ex)
                    {
                    }



                }

                if (check == "Activate")
                {

                    gridRegistered.Visible = false;
                    gridCompanies.Visible = true;
                    gridTrial.Visible = false;

                    btnActivate.Text = "Deactivate";

                    var result = companyService.Search(check, str);

                    try
                    {
                        gridCompanies.DataSource = result;
                        gridCompanies.DataBind();
                        Request.QueryString.Remove("no");
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }
        }

        protected void ddlSrcType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void ddlStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            var companyService = new CompanyService();

            if (ddlStatus.SelectedValue == "Activate") //done
            {
                gridRegistered.Visible = false;
                gridCompanies.Visible = true;
                gridTrial.Visible = false;
                btnActivate.Text = "Deactivate";
                
                try
                {
                    gridCompanies.DataSource = companyService.Search(ddlStatus.SelectedValue, txtSearch.Text);
                    gridCompanies.DataBind();
                }
                catch (Exception ex)
                {
                }
            }


            if (ddlStatus.SelectedValue == "Deactivate")
            {
                gridCompanies.Visible = true;
                gridRegistered.Visible = false;
                gridTrial.Visible = false;
                btnActivate.Text = "Activate";
                try
                {
                    gridCompanies.DataSource = companyService.Search(ddlStatus.SelectedValue, txtSearch.Text);
                    gridCompanies.DataBind();
                }
                catch (Exception ex)
                {
                }
            }
            if (ddlStatus.SelectedValue == "Registered")
            {
                gridRegistered.Visible = true;
                gridTrial.Visible = false;
                gridCompanies.Visible = false;
                btnActivate.Text = "Activate Company";
                try
                {
                    gridRegistered.DataSource = companyService.Search(ddlStatus.SelectedValue, txtSearch.Text);
                    gridRegistered.DataBind();
                }
                catch (Exception ex)
                {
                }
            }
            if (ddlStatus.SelectedValue == "Trial")
            {
                gridTrial.Visible = true;
                gridCompanies.Visible = false;
                gridRegistered.Visible = false;
                btnActivate.Text = "Disapproved";
              
                try
                {
                    var result = companyService.Search(ddlStatus.SelectedValue, txtSearch.Text);
                    gridTrial.DataSource = result;
                    gridTrial.DataBind();
                    //gridTrial.Rows[0].BackColor = Color.Black;
                    for (int i = 0; i < result.Count; i++)
                    {
                        DateTime end = Convert.ToDateTime((result[9]));
                        int diff = end.Day - DateTime.Now.Day;
                        if (diff <= 0)
                        {
                            gridTrial.Rows[i].BackColor = Color.Tomato;

                        }
                    }

                }
                catch (Exception ex)
                { }
            }
            if (ddlStatus.SelectedValue == "Block")
            {
                gridCompanies.Visible = true;
                gridRegistered.Visible = false;
                gridTrial.Visible = false;
                btnActivate.Text = "Unblock";
                try
                {
                    gridCompanies.DataSource = companyService.Search(ddlStatus.SelectedValue, txtSearch.Text);
                    gridCompanies.DataBind();
                }
                catch (Exception ex)
                {
                }
            }


        }


        protected void gridCompanies_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gridCompanies.PageIndex = e.NewPageIndex;
            BindData();
        }




        protected void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        protected void btnActivate_Click(object sender, EventArgs e)
        {
            //if (ddlStatus.SelectedValue == "Activate") //approved,block,disapproved
            //{
            //    for (int i = 0; i < gridCompanies.Rows.Count; i++)
            //    {
            //        CheckBox chk = (CheckBox)gridCompanies.Rows[i].Cells[0].Controls[1];

            //        if (chk.Checked)
            //        {
            //            int key = Convert.ToInt32(gridCompanies.DataKeys[i].Value);
            //            obj.CompanyId = key;


            //            obj.Status = "Disapproved";
            //            int Res = obj.ApprovedCompany();
            //            obj.Status = "Approved";
            //            ds = obj.SearchCompanyName();




            //        }

            //    }
            //    try
            //    {
            //        gridCompanies.DataSource = ds;
            //        gridCompanies.DataBind();
            //    }
            //    catch (Exception ex)
            //    {
            //    }

            //}
            //if (ddlStatus.SelectedValue == "Deactivate")
            //{

            //    for (int i = 0; i < gridCompanies.Rows.Count; i++)
            //    {
            //        CheckBox chk = (CheckBox)gridCompanies.Rows[i].Cells[0].Controls[1];
            //        if (chk.Checked)
            //        {
            //            int key = Convert.ToInt32(gridCompanies.DataKeys[i].Value);
            //            obj.CompanyId = key;



            //            obj.Status = "Approved";
            //            int Res = obj.ApprovedCompany();
            //            obj.Status = "Disapproved";
            //            ds = obj.SearchCompanyName();





            //        }


            //    }
            //    try
            //    {
            //        gridCompanies.DataSource = ds;
            //        gridCompanies.DataBind();
            //    }
            //    catch (Exception ex)
            //    {
            //    }
            //}
            //if (ddlStatus.SelectedValue == "Registered")
            //{

            //    for (int i = 0; i < gridCompanies.Rows.Count; i++)
            //    {
            //        CheckBox chk = (CheckBox)gridCompanies.Rows[i].Cells[0].Controls[1];
            //        if (chk.Checked)
            //        {
            //            int key = Convert.ToInt32(gridCompanies.DataKeys[i].Value);
            //            obj.CompanyId = key;


            //            obj.Status = "Approved";
            //            int Res = obj.ApprovedCompany();
            //            obj.Status = "Block";
            //            ds = obj.SearchCompanyName();





            //        }

            //    }
            //    try
            //    {
            //        gridCompanies.DataSource = ds;
            //        gridCompanies.DataBind();
            //    }
            //    catch (Exception ex)
            //    {
            //    }
            //}
            //if (ddlStatus.SelectedValue == "Trial") //trail
            //{
            //    for (int i = 0; i < gridTrial.Rows.Count; i++)
            //    {
            //        CheckBox chk = (CheckBox)gridTrial.Rows[i].Cells[0].Controls[1];
            //        if (chk.Checked)
            //        {
            //            int key = Convert.ToInt32(gridTrial.DataKeys[i].Value);
            //            obj.CompanyId = key;
            //            obj.Status = "Disapproved";
            //            int Res = obj.ApprovedCompany();
            //        }
            //    }
            //    obj.Status = "Trial";
            //    ds = obj.SearchCompanyName();
            //    try
            //    {
            //        gridTrial.DataSource = ds;
            //        gridTrial.DataBind();
            //    }
            //    catch
            //    {
            //    }
            //}

            //if (ddlStatus.SelectedValue == "Block") //registered
            //{
            //    for (int i = 0; i < gridCompanies.Rows.Count; i++)
            //    {
            //        CheckBox chk = (CheckBox)gridCompanies.Rows[i].Cells[0].Controls[1];
            //        if (chk.Checked)
            //        {
            //            int key = Convert.ToInt32(gridCompanies.DataKeys[i].Value);
            //            obj.CompanyId = key;
            //            obj.Status = "Disapproved";
            //            int Res = obj.ApprovedCompany();

            //        }
            //    }
            //    obj.Status = "Trial";
            //    ds = obj.SearchCompanyName();

            //    try
            //    {
            //        gridCompanies.DataSource = ds;
            //        gridCompanies.DataBind();
            //    }
            //    catch (Exception ex)
            //    {
            //    }
            //}




        }




        protected void gridRegistered_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void btnTrial_Click(object sender, EventArgs e)
        {


        }


        protected void btnFilter_Click(object sender, EventArgs e)
        {
            SearchText();
        }

        private void SearchText()
        {
            string SearchExpression = null;

            if (ddlStatus.SelectedValue == "Activate" || ddlStatus.SelectedValue == "Deactivate" || ddlStatus.SelectedValue == "Block")
            {
                if (!String.IsNullOrEmpty(txtSearch.Text))
                {
                    SearchExpression = string.Format("{0} '%{1}%'", gridCompanies.SortExpression, txtSearch.Text);
                }

               var result = GetRecords(txtSearch.Text.Trim());              
                gridCompanies.DataSource = result;
                gridCompanies.DataBind();
            }

            if (ddlStatus.SelectedValue == "Registered")
            {
                if (!String.IsNullOrEmpty(txtSearch.Text))
                {
                    SearchExpression = string.Format("{0} '%{1}%'", gridRegistered.SortExpression, txtSearch.Text);
                }

                var result = GetRecords(txtSearch.Text.Trim());
                gridRegistered.DataSource = result;
                gridRegistered.DataBind();
            }

            if (ddlStatus.SelectedValue == "Trial")
            {
                if (!String.IsNullOrEmpty(txtSearch.Text))
                {
                    SearchExpression = string.Format("{0} '%{1}%'", gridTrial.SortExpression, txtSearch.Text);
                }

                var result = GetRecords(txtSearch.Text.Trim());
                gridTrial.DataSource = result;
                gridTrial.DataBind();
            }

        }

        private IReadOnlyList<Service.ViewModel.Company> GetRecords(string companyName)
        {
            var companyService = new CompanyService();
            var searchResult = companyService.Search(ddlStatus.SelectedValue, companyName);
            if (ddlStatus.SelectedValue == "Activate")
            {
                gridCompanies.Visible = true;
                gridRegistered.Visible = false;
                gridTrial.Visible = false;
                btnActivate.Text = "Deactivate";
               
                try
                {
                    gridCompanies.DataSource = searchResult;
                    gridCompanies.DataBind();
                }
                catch (Exception ex)
                {
                }
            }

            if (ddlStatus.SelectedValue == "Deactivate")
            {
                gridCompanies.Visible = true;
                gridRegistered.Visible = false;
                gridTrial.Visible = false;
                btnActivate.Text = "Activate";
              
                try
                {
                    gridCompanies.DataSource = searchResult;
                    gridCompanies.DataBind();
                }
                catch (Exception ex)
                {
                }


            }
            if (ddlStatus.SelectedValue == "Registered")
            {
                gridRegistered.Visible = true;
                gridTrial.Visible = false;
                gridCompanies.Visible = false;
                btnActivate.Text = "Activate Company";
              
                try
                {
                    gridRegistered.DataSource = searchResult;
                    gridRegistered.DataBind();
                }
                catch (Exception ex)
                {
                }
            }

            if (ddlStatus.SelectedValue == "Trial")
            {
                gridTrial.Visible = true;
                gridCompanies.Visible = false;
                gridRegistered.Visible = false;
                btnActivate.Text = "Disapproved";

                try
                {
                    gridTrial.DataSource = searchResult;
                    gridTrial.DataBind();
                }
                catch (Exception ex)
                {
                }
            }

            if (ddlStatus.SelectedValue == "Block")
            {
                gridTrial.Visible = false;
                gridCompanies.Visible = true;
                gridRegistered.Visible = false;
                btnActivate.Text = "Disapproved";
               
                try
                {
                    gridCompanies.DataSource = searchResult;
                    gridCompanies.DataBind();
                }
                catch (Exception ex)
                {
                }
            }


            return searchResult;

        }

        protected void gridRegistered_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gridRegistered.PageIndex = e.NewPageIndex;
            BindData();
        }
        protected void gridTrial_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gridTrial.PageIndex = e.NewPageIndex;
            BindData();
        }

        public void BindData()
        {
            var companyService = new CompanyService();

            if (ddlStatus.SelectedValue == "Activate") //done
            {
                gridRegistered.Visible = false;
                gridCompanies.Visible = true;
                gridTrial.Visible = false;

                btnActivate.Text = "Deactivate";
               
                try
                {
                    gridCompanies.DataSource = companyService.Search(ddlStatus.SelectedValue, txtSearch.Text);
                    gridCompanies.DataBind();
                }
                catch (Exception ex)
                {
                }
            }


            if (ddlStatus.SelectedValue == "Deactivate")
            {
                gridCompanies.Visible = true;
                gridRegistered.Visible = false;
                gridTrial.Visible = false;
                btnActivate.Text = "Activate";
                
                try
                {
                    gridCompanies.DataSource = companyService.Search(ddlStatus.SelectedValue, txtSearch.Text);
                    gridCompanies.DataBind();
                }
                catch (Exception ex)
                {
                }
            }
            if (ddlStatus.SelectedValue == "Registered")
            {
                gridRegistered.Visible = true;
                gridTrial.Visible = false;
                gridCompanies.Visible = false;
                btnActivate.Text = "Activate Company";
               
                try
                {
                    gridRegistered.DataSource = companyService.Search(ddlStatus.SelectedValue, string.Empty);
                    gridRegistered.DataBind();
                }
                catch (Exception ex)
                {
                }
            }
            if (ddlStatus.SelectedValue == "Trial")
            {
                gridTrial.Visible = true;
                gridCompanies.Visible = false;
                gridRegistered.Visible = false;
                btnActivate.Text = "Disapproved";
              
                try
                {
                    var result = companyService.Search(ddlStatus.SelectedValue, txtSearch.Text);
                    gridTrial.DataSource = result;
                    gridTrial.DataBind();
                    //gridTrial.Rows[0].BackColor = Color.Black;
                    for (int i = 0; i < result.Count(); i++)
                    {



                        DateTime end = Convert.ToDateTime((result[9]));
                        int diff = end.Day - DateTime.Now.Day;
                        if (diff <= 0)
                        {
                            gridTrial.Rows[i].BackColor = Color.Red;

                        }
                    }

                }
                catch (Exception ex)
                { }
            }
            if (ddlStatus.SelectedValue == "Block")
            {
                gridCompanies.Visible = true;
                gridRegistered.Visible = false;
                gridTrial.Visible = false;
                btnActivate.Text = "Unblock";
               
                try
                {
                    gridCompanies.DataSource = companyService.Search(ddlStatus.SelectedValue, txtSearch.Text);
                    gridCompanies.DataBind();
                }
                catch (Exception ex)
                {
                }
            }
        }

        protected void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchText();
        }
        protected void btnFind_Click(object sender, EventArgs e)
        {
            SearchText();
        }
    }
}