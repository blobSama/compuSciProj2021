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
    public partial class testResults : System.Web.UI.Page
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
                populateDataList();
            }
        }

        public void populateDataList()
        {
            DataList1.DataSource = GetData();
            DataList1.DataBind();
            foreach (DataListItem item in DataList1.Items)
            {
                string[] usAnswers = (string[])(Session["selectedAns"]);
                ((Label)item.FindControl("ansr")).Text = usAnswers[item.ItemIndex];
                if (((Boolean[])Session["qAnswered"])[item.ItemIndex])
                {
                    ((Label)item.FindControl("rghtOrwrng")).Text = "Correct!";
                }
                else
                {
                    ((Label)item.FindControl("rghtOrwrng")).Text = "Incorrect...";
                    ((Label)item.FindControl("Label3")).Text = "The right answer was:";
                    ((Label)item.FindControl("rightAns")).Text = ((string[])Session["rightAnswrs"])[item.ItemIndex];
                }
            }
        }

        private DataSet GetData()
        {
            int testNum = (int)Session["testNum"];
            testService ts = new testService();
            return ts.GetTestById(testNum);
        }
    }
}