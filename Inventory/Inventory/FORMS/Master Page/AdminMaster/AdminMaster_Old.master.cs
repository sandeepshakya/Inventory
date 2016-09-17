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
using System.Xml;
using System.Xml.Xsl;
using System.IO;
using System.Data.SqlClient;   

public partial class Master_Page_AdminMaster_AdminMaster : System.Web.UI.MasterPage
{

    protected void Page_Load(object sender, EventArgs e)
    {
        StringWriter sw = new StringWriter();
        String xslPath = Server.MapPath("~/XslFiles/Admin.xsl");
        String xmlpath = Server.MapPath("~/XmlFiles/Admin.xml");
         
        XslCompiledTransform transform = new XslCompiledTransform();
        transform.Load(xslPath);
        transform.Transform(xmlpath, null, sw);
        //TextBox1.Mode = LiteralMode.PassThrough; 
        //TextBox1.Text = sw.ToString(); 
        Label3.Text = sw.ToString();
        
        //String xslPath = Server.MapPath("~/XslFiles/Admin.xsl");
        //String xmlpath = Server.MapPath("~/XmlFiles/Admin.xml");
        //XslCompiledTransform transform = new XslCompiledTransform();
        //transform.Load(xslPath);
        //transform.Transform(xmlpath, null, Response.Output);  
        
       
       
    }
    public string AddText
    {
        get
        {
            return lnkbtnAddValue.Text;

        }
        set
        {
            lnkbtnAddValue.Text = value;
        }

    }
    public string EditText
    {
        get
        {
            return lnkEditValue.Text;

        }
        set
        {
            lnkEditValue.Text = value;
        }

    }

    public string ViewText
    {
        get
        {
            return lnkbtnViewValue.Text;

        }
        set
        {
            lnkbtnViewValue.Text = value;
        }

    }

    public string Option1
    {
        get
        {
            return lnkbtn1.Text;

        }
        set
        {
            lnkbtn1.Text = value;
        }

    }

    public string Option2
    {
        get
        {
            return lnkbtn2.Text;

        }
        set
        {
            lnkbtn2.Text = value;
        }

    }

    public string Option3
    {
        get
        {
            return lnkbtn3.Text;

        }
        set
        {
            lnkbtn3.Text = value;
        }

    }

    public string linkAddUrl
    {
        get
        {
            return lnkbtnAddValue.PostBackUrl;

        }
        set
        {
            lnkbtnAddValue.PostBackUrl = value;
        }

    }

    public string linkEditUrl
    {
        get
        {
            return lnkEditValue.PostBackUrl;

        }
        set
        {
            lnkEditValue.PostBackUrl = value;
        }

    }

    public string linkViewUrl
    {
        get
        {
            return lnkbtnViewValue.PostBackUrl;

        }
        set
        {
            lnkbtnViewValue.PostBackUrl = value;
        }

    }

    public string Option1Url
    {
        get
        {
            return lnkbtn1.PostBackUrl;

        }
        set
        {
            lnkbtn1.PostBackUrl = value;
        }

    }

    public string Option2Url
    {
        get
        {
            return lnkbtn2.PostBackUrl;

        }
        set
        {
            lnkbtn2.PostBackUrl = value;
        }

    }

    public string Option3Url
    {
        get
        {
            return lnkbtn3.PostBackUrl;

        }
        set
        {
            lnkbtn3.PostBackUrl = value;
        }

    }

    //public string SetSession
    //{
    //    get
    //    {
    //        return lblUserSession.Text;

    //    }
    //    set
    //    {
    //       lblUserSession.Text = value;
    //    }

    //}



    protected void lnkbtnLogout_Click(object sender, EventArgs e)
    {
        string user = Convert.ToString(Session["UserID"]);
        //SqlParameter[] objParameter = new SqlParameter[1];

        SqlParameter[] objParameter = new SqlParameter[1];
        objParameter[0] = new SqlParameter("@UserName", SqlDbType.VarChar);
        objParameter[0].Value = user;

        DataLayer.DBAccess.DALWrapper.ExecuteNonSP("stp_UserLogoff", objParameter);

        
        Session.Abandon();
       
        Response.Redirect("~/FORMS/Admin Forms/Login/Login.aspx");
    }

  
    protected void lnkbtnNotePad_Click(object sender, EventArgs e)
    {
        System.Diagnostics.Process.Start("Notepad.exe");
    }


    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
       
    }
    protected void lnkbtnCalculator_Click1(object sender, EventArgs e)
    {
        System.Diagnostics.Process.Start("calc.exe");
    }
    protected void lnkbtnLogout_Click1(object sender, EventArgs e)
    {
 string user = Convert.ToString(Session["UserID"]);
        //SqlParameter[] objParameter = new SqlParameter[1];

        SqlParameter[] objParameter = new SqlParameter[1];
        objParameter[0] = new SqlParameter("@UserName", SqlDbType.VarChar);
        objParameter[0].Value = user;

        DataLayer.DBAccess.DALWrapper.ExecuteNonSP("stp_UserLogoff", objParameter);


        Session.Abandon();
        Session["theme"] = "";
        Response.Redirect("~/FORMS/Admin Forms/Login/Login.aspx");
    }
}

