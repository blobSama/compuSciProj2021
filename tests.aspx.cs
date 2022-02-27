using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;

namespace compuSciProj2021
{
    public partial class variablesTest : System.Web.UI.Page
    {
        public static Stopwatch stopwatch = new Stopwatch();
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
                populateDataList();
                DateTime startTest = DateTime.Now;
                Session["testStart"] = startTest;
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
            testService ts = new testService();
            int scorePer, score, right = 0, wrong = 0;
            DataSet tests = GetData();
            bool[] questions = new bool[tests.Tables[0].Rows.Count];
            string[] answers = new string[tests.Tables[0].Rows.Count];
            string[] rightAnswers = new string[tests.Tables[0].Rows.Count];
            scorePer = 100 / tests.Tables[0].Rows.Count;
            foreach (DataListItem item in DataList1.Items)
            {
                int qNum = Convert.ToInt32(DataList1.DataKeys[item.ItemIndex]);
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
            stopwatch.Stop();
            long time = stopwatch.ElapsedMilliseconds;
            Double testSeconds = 0;
            Double testMinutes = 0;
            Double testhours = 0;
            DateTime endTest = DateTime.Now;
            object v = Session["testStart"];
            DateTime testStart = (DateTime)v;
            testhours = (endTest.Subtract(testStart).TotalHours) % 1;
            testMinutes = (endTest.Subtract(testStart).TotalMinutes) % 60;
            testSeconds = (endTest.Subtract(testStart).TotalSeconds) % 60;
            score = right * scorePer;
            DateTime testTime = new DateTime(endTest.Year, endTest.Month, endTest.Day, Convert.ToInt32(testhours), Convert.ToInt32(testMinutes), Convert.ToInt32(testSeconds));
            string id = ((User)Session["curUser"]).ID;
            int testNum = Convert.ToInt32(Session["testNum"]);
            ts.insertTest(testTime, score, id, testNum);
            Session["qAnswered"] = questions;
            Session["selectedAns"] = answers;
            Session["rightAnswrs"] = rightAnswers;
            Response.Write("<script>alert('Score is:" + score +", You got " + right + " questions right and " + wrong + " questions wrong. ');</script>");
            Server.Transfer("testResults.aspx");
        }
    }
}