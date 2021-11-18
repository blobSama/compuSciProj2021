using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace compuSciProj2021
{
    public partial class showTests : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["curUser"] != null)
            {
                hello.Text = "Hello, " + ((User)Session["curUser"]).Firstname;
                populateDataList();
            }
            else
            {
                Response.Redirect("Homepage.aspx");
            }
        }
     

        public void populateDataList()
        {
            DataList1.DataSource = GetData();
            DataList1.DataBind();
        }

        private DataSet GetData()
        {
            testService ts = new testService();
            return ts.GetTests();
        }
    }
}