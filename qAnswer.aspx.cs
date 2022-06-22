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
    public partial class qAnswer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["curUser"] != null)
            {
                fqnasService fs = new fqnasService();
                DataSet ds = fs.GetFaqByNum(Convert.ToInt32(Session["questNum"].ToString()));
                question.Text = (ds.Tables[0].Rows[0][3]).ToString();
                hello.Text = "Hello, " + ((User)Session["curUser"]).Firstname;
            }
            else
            {
                Response.Write("<script>alert('Must sign up to answer.')</script>");
                Server.Transfer("Register.aspx");
            }


        }

        protected void submit_Click(object sender, EventArgs e)
        {
            string userId = ((User)Session["curUser"]).ID;
            DateTime today = DateTime.Now;
            string ans = answer.Text.Replace("'", "''");
            fqnas f = new fqnas();
            f.AnsUsrId = userId;
            f.AnsDate = today;
            f.Ans = ans;
            fqnasService fs = new fqnasService();
            fs.InsertAnswer(f, Convert.ToInt32(Session["questNum"].ToString()));
            Response.Redirect("faqs.aspx");
        }
    }
}