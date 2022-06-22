using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

namespace compuSciProj2021
{
    public partial class Replies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            hello.Text = "Hello, " + ((User)Session["curUser"]).Firstname;
            if (!Page.IsPostBack)
            {
                populateDatalist();
            }
        }

        public void populateDatalist()
        {
            JobsService.jobsService js = new JobsService.jobsService();
            DataSet ds = js.UserReplies(((User)Session["curUser"]).ID);
            DataList1.DataSource = ds;
            DataList1.DataBind();
        }
    }
}