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
    public partial class jobs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["curUser"] != null)
            {
                hello.Text = "Hello, " + ((User)Session["curUser"]).Firstname;
            }
            else
            {
                Response.Redirect("Homepage.aspx");
            }
            if (!Page.IsPostBack)
            {
                populateDropDown();
            }
        }
        
        public void populateDropDown()
        {
            JobsService.jobsService j = new JobsService.jobsService();
            DropDownList1.DataSource = j.GetCitis();
            DropDownList1.DataTextField = "cityName";
            DropDownList1.DataValueField = "cityNum";
            DropDownList1.DataBind();
        }
    }
}