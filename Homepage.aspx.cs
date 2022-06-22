using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace compuSciProj2021
{
    public partial class Homepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["curUser"] != null)
            {
                hello.Text = "Hello, " + ((User)Session["curUser"]).Firstname;
                usrSignIn.Visible = false;
                usrRegister.Visible = false;
                if (!(((User)Session["curUSer"]).Manager))
                {
                    userData.Visible = false;
                }
            }
            else
            {
                hello.Text = "Hello, Guest";
                userData.Visible = false;
                infoUpdate.Visible = false;
                tests.Visible = false;
                showDonetests.Visible = false;
                findJobs.Visible = false;
                dis.Visible = false;
            }
        }

        protected void dis_Click(object sender, EventArgs e)
        {
            Session["curUser"] = null;
            Server.Transfer("Homepage.aspx");
        }
    }
}