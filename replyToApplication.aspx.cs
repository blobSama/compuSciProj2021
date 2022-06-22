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
    public partial class replyToApplication : System.Web.UI.Page
    {
        //i love u baby
        protected void Page_Load(object sender, EventArgs e)
        {
            hello.Text = "Hello, " + ((User)Session["curUser"]).Firstname;
            JobsService.jobsService js = new JobsService.jobsService();
            int offNum = Convert.ToInt32(Session["applicationReply"]);
            string repliedUsrId = Session["userReplyId"].ToString();
            if (js.isAnswered(offNum, repliedUsrId))
            {
                wrplceReply.Text = (js.GetReply(offNum, repliedUsrId).Tables[0].Rows[0][0]).ToString();
                if(js.IsAccepted(repliedUsrId, offNum))
                {
                    RadioButton1.Checked = true;
                }
                else
                {
                    RadioButton2.Checked = true;
                }
            }
            else
            {
                wrplceReply.Attributes.Add("placeholder", "Enter Your Reply Here");
            }
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            if (!RadioButton1.Checked && !RadioButton2.Checked)
            {
                error.Text = "Please reject or accept the applicant.";
            }
            else
            {
                updateApp();
                if (RadioButton1.Checked)
                {
                    Accept();
                }
                else
                {
                    
                }
                Response.Redirect("jobsForYou.aspx");
            }
        }

        public void updateApp()
        {
            string reply = wrplceReply.Text.Replace("'", "''");
            JobsService.jobsService js = new JobsService.jobsService();
            int offNum = Convert.ToInt32(Session["applicationReply"]);
            string repliedUsrId = Session["userReplyId"].ToString();
            js.UpdateRply(reply, offNum, repliedUsrId);
        }

        public void Accept()
        {
            int offNum = Convert.ToInt32(Session["applicationReply"]);
            string repliedUsrId = Session["userReplyId"].ToString();
            JobsService.jobsService js = new JobsService.jobsService();
            js.IsntRelevant(offNum);
            js.accept(repliedUsrId, offNum);
        }

        public void Reject()
        {
            int offNum = Convert.ToInt32(Session["applicationReply"]);
            string repliedUsrId = Session["userReplyId"].ToString();
            JobsService.jobsService js = new JobsService.jobsService();
            js.Reject(repliedUsrId,offNum);
        }
    }
}