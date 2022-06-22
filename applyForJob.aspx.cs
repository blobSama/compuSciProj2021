using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace compuSciProj2021
{
    public partial class applyForJob : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            hello.Text = "Hello, " + ((User)Session["curUser"]).Firstname;
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            InsertApplication(CheckValidity());
            Response.Redirect("jobsForYou.aspx");
            
        }

        public void InsertApplication(string cv)
        {
            ((JobsService.Application)(Session["userApplication"])).Cv = cv;
            ((JobsService.Application)(Session["userApplication"])).Reply = "";
            JobsService.jobsService js = new JobsService.jobsService();
            js.InsertAplctn((JobsService.Application)(Session["userApplication"]));
        }

        public string CheckValidity()
        {
            string s1 = usrCv.Text;
            s1 = s1.Replace("'", "''");
            return s1;
        }
    }
}