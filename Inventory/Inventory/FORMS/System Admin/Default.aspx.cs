using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Inventory.FORMS.System_Admin
{
    public partial class Defau : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SystemAdmin objCount = new SystemAdmin();
            DataSet ds = objCount.ViewCompany();

            if (ds.Tables.Count > 0)
            {

                //BoundField bField = new BoundField();

                //CheckBox  chk =new CheckBox ();
                //bField.DataField = chk;

                foreach (DataColumn dc in ds.Tables[0].Columns)
                {

                    BoundField bField = new BoundField();


                    bField.DataField = dc.ColumnName;


                    bField.HeaderText = dc.ColumnName;


                    GridView1.Columns.Add(bField);

                }
                try
                {
                    GridView1.DataSource = ds.Tables[0];

                    GridView1.DataBind();
                }
                catch (Exception ex)
                {
                }
            }
        }
    }
}