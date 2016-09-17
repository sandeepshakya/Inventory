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

public partial class FORMS_System_Admin_Default : System.Web.UI.Page
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

    protected void GridView1_DataBound(object sender, EventArgs e)
    {
        //foreach (GridViewRow objRow in GridView1.Rows)
        //{
        //    TableCell tcCheckCell = new TableCell(0);
        //    CheckBox chkCheckBox = new CheckBox();
        //    tcCheckCell.Controls.Add(chkCheckBox);
        //    objRow.Cells.AddAt(0, tcCheckCell);
        //}
    }
}
