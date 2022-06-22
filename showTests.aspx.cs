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
    public partial class showTests : System.Web.UI.Page
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
                    addTest.Visible = false;
                    DropDownList4.Visible = false;
                }
            }
            else
            {
                Response.Redirect("Homepage.aspx");
            }
            if (!Page.IsPostBack)
            {
                populateDropDown();
                if (!(((User)Session["curUSer"]).Manager))
                {
                    populateDataList();
                }
                else
                {
                    PopulateGrid();
                }
            }
            DropDownList1.BackColor = System.Drawing.Color.FromArgb(22, 57, 95);
            DropDownList2.BackColor = System.Drawing.Color.FromArgb(22, 57, 95);
            DropDownList3.BackColor = System.Drawing.Color.FromArgb(22, 57, 95);
        }
     

        public void populateDataList()
        {
            DataList1.DataSource = GetData();
            DataList1.DataBind();
        }
        //i love u so much 
        public void populateDropDown()
        {
            testService ts = new testService();
            int curTop = ((User)Session["curUser"]).CurTop;
            DropDownList3.DataSource = ts.getSubjects(curTop);
            DropDownList3.DataTextField = "subjName";
            DropDownList3.DataValueField = "subjNum";
            DropDownList3.DataBind();
            DropDownList3.Items.Insert(0, new ListItem("Choose Topic:", "0"));
            DropDownList4.DataSource = ts.getSubjectsGuest();
            DropDownList4.DataTextField = "subjName";
            DropDownList4.DataValueField = "subjNum";
            DropDownList4.DataBind();
            DropDownList4.Items.Insert(0, new ListItem("Choose Topic:", "0"));
        }

        private DataSet GetData()
        {
            bool ok;
            int curTop = ((User)Session["curUser"]).CurTop;
            testService ts = new testService();
            DataSet dataset = ts.GetTestsUser(curTop);
            dataset.Tables[0].Columns.Add("hasPassed", typeof(bool));
            if(dataset.Tables[0].Rows.Count != 0)
            {
                foreach (DataRow dr in dataset.Tables[0].Rows)
                {
                    ok = ts.hasPassed(((User)Session["curUser"]).ID, Convert.ToInt32(dr[4]));
                    dataset.Tables[0].Rows[dataset.Tables[0].Rows.IndexOf(dr)][6] = ok;
                }
            }
            return dataset;
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
            int topic = Convert.ToInt32(DropDownList3.SelectedValue);
            DataList1.DataSource = GetSortedTests(diff, time, topic);
            DataList1.DataBind();
        }

        protected void addTest_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(DropDownList4.SelectedValue) == 0)
            {
                Response.Write("<script>alert('Please select a subject for the test.')</script>");
            }
            else
            {
                testService ts = new testService();
                int num = Convert.ToInt32(DropDownList4.SelectedValue);
                Session["testNum"] = ts.CreateTest(num);
                Session["testSubj"] = num;
                Response.Redirect("insertTests.aspx");
            }
        }

        public void PopulateGrid()
        {
            testService ts = new testService();
            GridView1.DataSource = ts.GetTests();
            GridView1.DataBind();
        }
        //i love u baby 
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            PopulateGrid();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            PopulateGrid();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Test t = new Test();
            int tn;
            if(Int32.TryParse(((GridView1.Rows[e.RowIndex].Cells[0])).Text, out tn))
            {
                t.TestNum = tn;
                DateTime dt;
                if (DateTime.TryParse((((TextBox)(GridView1.Rows[e.RowIndex].Cells[1].Controls[0])).Text), out dt))
                {
                    t.UploadDate = dt;
                    t.IsActive = (bool.Parse)(((TextBox)(GridView1.Rows[e.RowIndex].Cells[2].Controls[0])).Text);
                    string topic = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[3].Controls[0])).Text;
                    t.Difficulty = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[4].Controls[0])).Text;
                    t.Descript = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[5].Controls[0])).Text;
                    if (validation.TopicVald(topic))
                    {
                        t.TestTopic = validation.testTopByName(topic);
                        if (validation.TestVald(t))
                        {
                            testService ts = new testService();
                            ts.updateTest(t);
                            GridView1.EditIndex = -1;
                            PopulateGrid();
                            valdWrng.Text = "";
                        }
                        else
                        {
                            valdWrng.Text = "Please check your input and try again.";
                        }
                    }
                    else
                    {
                        valdWrng.Text = "Please check your input and try again.";
                    }
                }
                else
                {
                    valdWrng.Text = "Please check your input and try again.";
                }
            }
            else
            {
                valdWrng.Text = "Please check your input and try again.";
            }
            
        }
    }
}