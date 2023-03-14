using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace compuSciProj2021
{
    public partial class qAsk : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["curUser"] != null)
            {
                hello.Text = "Hello, " + ((User)Session["curUser"]).Firstname;
            }
            else
            {
                Response.Write("<script>alert('Must sign up first.')</script>");
                Server.Transfer("Register.aspx");
            }
        }

        protected void submitQ_Click(object sender, EventArgs e)
        {
            string question = quest.Text.Replace("'", "''");
            string askUserId = ((User)Session["curUser"]).ID;
            DateTime askDate = DateTime.Now;
            fqnas f = new fqnas();
            f.Qstn = question;
            f.AskUsrId = askUserId;
            f.AskDate = askDate;
            fqnasService fs = new fqnasService();
            fs.InsertQuestion(f);
            Response.Redirect("faqs.aspx");
        }
    }
}