using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Inventory.FORMS.Master_Page.SystemAdminMaster
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        public string AddText
        {
            get
            {
                return lblHeading.Text;

            }
            set
            {
                lblHeading.Text = value;
            }
        }
        int res1, res2, res3, res4, res5;
        SystemAdmin obj = new SystemAdmin();
        SystemAdmin objCount = new SystemAdmin();
        protected void Page_Load(object sender, EventArgs e)
        {

            LblWelcome.Text = "Welcome " + Session["username"];
            res1 = objCount.GetAllRegistered();
            lblTotalRegistered.Text = Convert.ToString(res1);
            res2 = objCount.GetApproved();
            lblApproved.Text = Convert.ToString(res2);
            res3 = objCount.GetDisApproved();
            lblDisApproved.Text = Convert.ToString(res3);
            res4 = objCount.GetBlockedCompany();
            lblBlocked.Text = Convert.ToString(res4);
            res5 = objCount.GetTrialCompany();
            lblTrial.Text = Convert.ToString(res5);


        }

        protected void lnkbtnHome_Click(object sender, EventArgs e)
        {

            Response.Redirect("~/FORMS/System Admin/Home.aspx");


        }
        protected void lnkbtnLogout_Click(object sender, EventArgs e)
        {
            obj.UserName = Convert.ToString(Session["username"]);
            int ers = obj.SystemAdminLogoff();
            Session.Abandon();
            Response.AddHeader("pragma", "no-cache");
            Response.AddHeader("cache-control", "private");
            Response.CacheControl = "no-cache";
            Response.Cache.SetExpires(DateTime.Now.AddMinutes(-1));
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetNoStore();
            Session["username"] = null;
            Response.Redirect("~/FORMS/System Admin/SystemAdminLogin.aspx");
        }
        protected void lnkbtnMyAcc_Click(object sender, EventArgs e)
        {

            Response.Redirect("~/FORMS/System Admin/ResetPassword.aspx");

        }
    }
}