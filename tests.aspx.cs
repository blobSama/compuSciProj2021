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
    public partial class variablesTest : System.Web.UI.Page
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
                /*PopulateQuestions();*/
                populateDataList();
            }
        }

        public void populateDataList()
        {
            DataList1.DataSource = GetData();
            DataList1.DataBind();
        }

        private DataSet GetData()
        {
            int testNum = (int)Session["testNum"];
            testService ts = new testService();
            return ts.GetTestById(testNum);
        }

        protected void SubmitAns_Click(object sender, EventArgs e)
        { 
            int scorePer, score, right = 0, wrong = 0;
            DataSet tests = GetData();
            bool[] questions = new bool[tests.Tables[0].Rows.Count];
            string[] answers = new string[tests.Tables[0].Rows.Count];
            string[] rightAnswers = new string[tests.Tables[0].Rows.Count];
            scorePer = 100 / tests.Tables[0].Rows.Count;
            foreach (DataListItem item in DataList1.Items)
            {
                int qNum = Convert.ToInt32(DataList1.DataKeys[item.ItemIndex]);
                testService ts = new testService();
                DataSet ds = ts.GetRghtAnsByQ(qNum);
                string rAns = ds.Tables[0].Rows[0][0].ToString();
                rightAnswers[item.ItemIndex] = rAns;
                int i = 0;
                Label l = (Label)(item.FindControl("Label2"));
                for (; i < 4; i++)
                {
                    RadioButton r = (RadioButton)(item.FindControl((string)("answer" + (i + 1))));
                    if (r.Checked)
                    {
                        if (r.Text.Equals(rAns))
                        {
                            questions[item.ItemIndex] = true;
                            right++;
                            answers[item.ItemIndex] = r.Text;
                        }
                        else
                        {
                            questions[item.ItemIndex] = false;
                            wrong++;
                            answers[item.ItemIndex] = r.Text;
                        }
                        
                    }
                }
            }
            score = right * scorePer;
            Session["qAnswered"] = questions;
            Session["selectedAns"] = answers;
            Session["rightAnswrs"] = rightAnswers;
            Response.Write("<script>alert('Score is:" + score +", You got " + right + " questions right and " + wrong + " questions wrong. ');</script>");
            Server.Transfer("testResults.aspx");
        }

    }
}