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
    public partial class learnPy : System.Web.UI.Page
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
                    insertClass.Visible = false;
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
            }
            if (!Page.IsPostBack)
            {
                if(Session["curUser"] == null)
                {
                    populateDropDownGuest();
                    DropDownList1.Items.Insert(0, new ListItem("Choose Topic:", "0"));
                }
                else
                {
                    populateDropDown();
                    DropDownList1.Items.Insert(0, new ListItem("Choose Topic:", "0"));
                }
            }
            DropDownList1.BackColor = System.Drawing.Color.FromArgb(22, 57, 95);
            DropDownList2.BackColor = System.Drawing.Color.FromArgb(22, 57, 95);
        }

        public void populateDropDown()
        {
            testService ts = new testService();
            int curTop = ((User)Session["curUser"]).CurTop;
            DropDownList1.DataSource = ts.getSubjects(curTop);
            DropDownList1.DataTextField = "subjName";
            DropDownList1.DataValueField = "subjNum";
            DropDownList1.DataBind();
        }

        public void populateDropDownGuest()
        {
            testService ts = new testService();
            DropDownList1.DataSource = ts.getSubjectsGuest();
            DropDownList1.DataTextField = "subjName";
            DropDownList1.DataValueField = "subjNum";
            DropDownList1.DataBind();
        }

        protected void classChoose_Click(object sender, EventArgs e)
        {
            bool list1 = Convert.ToInt32(DropDownList1.SelectedValue.ToString()) == 0;
            bool list2 = false;
            if (DropDownList2.SelectedValue.ToString().Equals(""))
            {
                list2 = true;
            }
            else
            {
                if (Convert.ToInt32(DropDownList2.SelectedValue.ToString()) == 0)
                {
                    list2 = true;
                }
            }
            if (list1 || list2)
            {
                Response.Write("<script>alert('Please select a topic and a sub topic')</script>");
            }
            else
            {
                ClassService cs = new ClassService();
                int subtopNum = Convert.ToInt32(DropDownList2.SelectedValue);
                DataSet ds = cs.getClassBySubtop(subtopNum);
                Session["classNum"] = ds.Tables[0].Rows[0][0];
                classText.Text = (ds.Tables[0].Rows[0][2]).ToString();
                question.Text = (ds.Tables[0].Rows[0][4]).ToString();
                uploadTime.Text = uploadTime.Text + (ds.Tables[0].Rows[0][5]).ToString();
                question.Visible = true;
                answer.Visible = true;
                checkAns.Visible = true;
                uploadTime.Visible = true;
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Session["curUser"] == null)
            {
                ClassService cs = new ClassService();
                DropDownList2.DataSource = cs.getSubtopsByTopicGuest(Convert.ToInt32(DropDownList1.SelectedValue));
                DropDownList2.DataTextField = "subTopName";
                DropDownList2.DataValueField = "subTopNum";
                DropDownList2.DataBind();
                DropDownList2.Items.Insert(0, new ListItem("Choose Sub Topic:", "0"));
            }
            else
            {
                int curSubTop = ((User)Session["curUser"]).CurSubTop;
                ClassService cs = new ClassService();
                DropDownList2.DataSource = cs.getSubtopsByTopic(Convert.ToInt32(DropDownList1.SelectedValue), curSubTop);
                DropDownList2.DataTextField = "subTopName";
                DropDownList2.DataValueField = "subTopNum";
                DropDownList2.DataBind();
                DropDownList2.Items.Insert(0, new ListItem("Choose Sub Topic:", "0"));
            }
        }

        protected void checkAns_Click(object sender, EventArgs e)
        {
            ClassService cs = new ClassService();
            int val = Convert.ToInt32(DropDownList2.SelectedValue);
            string uId = ((User)Session["curUser"]).ID;
            string ans = answer.Text;
            int subTopSerial =  cs.getSubTopSerial(val, Convert.ToInt32(DropDownList1.SelectedValue)), subSerial = cs.getSubSerial(Convert.ToInt32(DropDownList1.SelectedValue));
            DataSet ds = cs.getSubtops(Convert.ToInt32(DropDownList1.SelectedValue));
            if (cs.checkAns(ans, val))
            {
                if (((User)Session["curUSer"]).CurSubTop == subTopSerial && ((User)Session["curUSer"]).CurTop == subSerial)
                {
                    rightOrWrong.Text = "Correct Answer!";
                    int subTopNum = Convert.ToInt32(DropDownList1.SelectedValue);
                    if (Convert.ToInt32(Convert.ToInt32(ds.Tables[0].Rows[ds.Tables[0].Rows.Count - 1][0])) == subTopNum)
                    {
                        cs.UpdateTopUsr(uId);
                        userService us = new userService();
                        User u = new User();
                        DataSet dataset = us.GetUser(((User)Session["curUser"]).ID);
                        u.CurSubTop = Convert.ToInt32(dataset.Tables[0].Rows[0][9]);
                        u.CurTop = Convert.ToInt32(dataset.Tables[0].Rows[0][8]);
                        Session["curUser"] = u;
                        Server.Transfer("learnPy.aspx");
                    }
                    else
                    {
                        cs.UpdateSubTopUsr(uId);
                        userService us = new userService();
                        User u = new User();
                        DataSet dataset = us.GetUser(((User)Session["curUser"]).ID);
                        u.CurSubTop = Convert.ToInt32(dataset.Tables[0].Rows[0][9]);
                        u.CurTop = Convert.ToInt32(dataset.Tables[0].Rows[0][8]);
                        Session["curUser"] = u;
                        Server.Transfer("learnPy.aspx");
                    }
                }
                else
                {
                    rightOrWrong.Text = "Youv'e already answered this question. Proceed to the next lesson!";
                }
            }
            else
            {
                rightOrWrong.Text = "Try Again...";
            }
        }

        protected void insertClass_Click(object sender, EventArgs e)
        {
            Response.Redirect("insertClass.aspx");
        }
    }
}