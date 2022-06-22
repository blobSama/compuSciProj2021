using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace compuSciProj2021
{
    public partial class descriptAndDiff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["curUser"] != null && ((User)Session["curUser"]).Manager)
            {
                hello.Text = "Hello, " + ((User)Session["curUser"]).Firstname;
                usrSignIn.Visible = false;
                usrRegister.Visible = false;
            }
            else
            {
                Response.Redirect("Homepage.aspx");
            }
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            CheckValidity();
            int testNum = Convert.ToInt32(Session["testNum"]);
            testService ts = new testService();
            ts.insertDiffAndDesc(DropDownList1.Text, descript.Text, testNum);
            ts.makeRelevant(testNum);
            Response.Redirect("showTests.aspx");
        }

        public void CheckValidity()
        {
            descript.Text = descript.Text.Replace("'", "''");
        }
    }
}