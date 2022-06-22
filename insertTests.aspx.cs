using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace compuSciProj2021
{
    public partial class insertTests : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            hello.Text = "Hello, " + ((User)Session["curUser"]).Firstname;
            usrSignIn.Visible = false;
            usrRegister.Visible = false;
            if (!(((User)Session["curUSer"]).Manager))
            {
                userData.Visible = false;
            }
            if(Session["curQuestNum"] != null)
            {
                Session["curQuestNum"] = (Convert.ToInt32(Session["curQuestNum"])) + 1;
            }
            else
            {
                Session["curQuestNum"] = 0;
            }
        }

        protected void addAnother_Click(object sender, EventArgs e)
        {
            addQ();
            Response.Redirect("insertTests.aspx");
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            addQ();
            Response.Redirect("descriptAndDiff.aspx");
        }

        public void addQ()
        {
            testService ts = new testService();
            int qNum = Convert.ToInt32(Session["curQuestNum"]);
            int testNum = Convert.ToInt32(Session["testNum"]);
            CheckValidity();
            string question = quest.Text;
            string ans1 = answer1.Text;
            string ans2 = answer2.Text;
            string ans3 = answer3.Text;
            string ans4 = answer4.Text;
            string rightAnswer = rightAns.Text;
            string explain = expl.Text;
            ts.insertQuestion(qNum, testNum, question, ans1, ans2, ans3, ans4, rightAnswer, explain);
        }

        public void CheckValidity()
        {
            answer1.Text = answer1.Text.Replace("'", "''");
            answer2.Text = answer2.Text.Replace("'", "''");
            answer3.Text = answer3.Text.Replace("'", "''");
            answer4.Text = answer4.Text.Replace("'", "''");
            rightAns.Text = rightAns.Text.Replace("'", "''");
            expl.Text = expl.Text.Replace("'", "''");
        }
    }
}