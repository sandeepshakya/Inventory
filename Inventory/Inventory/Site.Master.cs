using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Inventory
{
    public partial class SiteMaster : MasterPage
    {
        private const string AntiXsrfTokenKey = "__AntiXsrfToken";
        private const string AntiXsrfUserNameKey = "__AntiXsrfUserName";
        private string _antiXsrfTokenValue;

        protected void Page_Init(object sender, EventArgs e)
        {
            // The code below helps to protect against XSRF attacks
            var requestCookie = Request.Cookies[AntiXsrfTokenKey];
            Guid requestCookieGuidValue;
            if (requestCookie != null && Guid.TryParse(requestCookie.Value, out requestCookieGuidValue))
            {
                // Use the Anti-XSRF token from the cookie
                _antiXsrfTokenValue = requestCookie.Value;
                Page.ViewStateUserKey = _antiXsrfTokenValue;
            }
            else
            {
                // Generate a new Anti-XSRF token and save to the cookie
                _antiXsrfTokenValue = Guid.NewGuid().ToString("N");
                Page.ViewStateUserKey = _antiXsrfTokenValue;

                var responseCookie = new HttpCookie(AntiXsrfTokenKey)
                {
                    HttpOnly = true,
                    Value = _antiXsrfTokenValue
                };
                if (FormsAuthentication.RequireSSL && Request.IsSecureConnection)
                {
                    responseCookie.Secure = true;
                }
                Response.Cookies.Set(responseCookie);
            }

            Page.PreLoad += master_Page_PreLoad;
        }

        protected void master_Page_PreLoad(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Set Anti-XSRF token
                ViewState[AntiXsrfTokenKey] = Page.ViewStateUserKey;
                ViewState[AntiXsrfUserNameKey] = Context.User.Identity.Name ?? String.Empty;
            }
            else
            {
                // Validate the Anti-XSRF token
                if ((string)ViewState[AntiXsrfTokenKey] != _antiXsrfTokenValue
                    || (string)ViewState[AntiXsrfUserNameKey] != (Context.User.Identity.Name ?? String.Empty))
                {
                    throw new InvalidOperationException("Validation of Anti-XSRF token failed.");
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Session["CompanyId"] = "Dummy User";
            if (!Page.IsPostBack)
            {
                if (Session["CompanyId"]!= null )
                {
                    this.UserInformation();
                   
                }
            }
        }

        protected void UserInformation()
        {
            ltrlUserInfo.Text = string.Empty;
            StringBuilder userInfo = new StringBuilder();
            userInfo.Append(" <a href='#' class='dropdown-toggle' data-toggle='dropdown' data-hover='dropdown' data-close-others='true'>");
            userInfo.Append("<img alt='' src=abc.png />");
            userInfo.Append(" <span class='username'>" + Session["CompanyId"].ToString() + "</span>");

            userInfo.Append("  <i class='fa fa-angle-down'></i>");
            userInfo.Append(" </a>");
            userInfo.Append("  <ul class='dropdown-menu'>");
            userInfo.Append("  <li>");
            userInfo.Append("      <a href='extra_profile.html'>");
            userInfo.Append("          <i class='fa fa-user'></i>My Profile");
            userInfo.Append("     </a>");
            userInfo.Append(" </li>");
            userInfo.Append(" <li>");
            userInfo.Append("     <a href='page_calendar.html'>");
            userInfo.Append("         <i class='fa fa-gear'></i>Setting");
            userInfo.Append("   </a>");
            userInfo.Append(" </li>");
            userInfo.Append(" <li class='divider'></li>");

            userInfo.Append(" <li>");
            userInfo.Append("  <a href='../../../../FORMS/Login.aspx'><i class='fa fa-key'></i>Log Out</a>");

            userInfo.Append(" </li>");
            userInfo.Append("  </ul>");
            ltrlUserInfo.Text = userInfo.ToString();
        }

        public string LabelMessage
        {
            get
            {
                return lblMsg.Text;
            }
            set
            {
                lblMsg.Text = value;
            }
        }

    }
}