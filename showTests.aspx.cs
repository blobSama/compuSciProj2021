using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace compuSciProj2021
{
    public partial class showTests : System.Web.UI.Page
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
        }

        private DataSet GetData()
        {
            testService ts = new testService();
            return ts.GetTests();
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if(e.CommandName == "goToTest")
            {
                int num = Convert.ToInt32(DataList1.DataKeys[e.Item.ItemIndex]); 
                Session["testNum"] = num;
                Response.Redirect("tests.aspx");
            }
        }

        private DataSet GetSortedTests(int diff, int time, int topic)
        {
            testService ts = new testService();
            return ts.GetMatchTests(diff, time, topic);
        }

        protected void sort_Click(object sender, EventArgs e)
        {
            int diff = DropDownList1.SelectedIndex;
            int time = DropDownList2.SelectedIndex;
            int topic = DropDownList3.SelectedIndex;
            DataList1.DataSource = GetSortedTests(diff, time, topic);
            DataList1.DataBind();
        }
    }
}