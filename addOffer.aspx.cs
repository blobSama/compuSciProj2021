using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace compuSciProj2021
{
    public partial class addOffer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            hello.Text = "Hello, " + ((User)Session["curUser"]).Firstname;
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

        protected void submit_Click(object sender, EventArgs e)
        {
            JobsService.jobsService j = new JobsService.jobsService();
            string workId = ((User)Session["curUser"]).ID;
            string descript = jobDescript.Text;
            DateTime dateOfUpload = DateTime.Now;
            int city = Convert.ToInt32(DropDownList1.SelectedValue);
            j.insertOffer(workId, descript, dateOfUpload, city);
            Response.Redirect("jobsForYou.aspx");
        }
    }
}