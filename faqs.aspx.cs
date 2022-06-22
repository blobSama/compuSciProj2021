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
    public partial class faqs : System.Web.UI.Page
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
                PopulateDatalist();
                foreach (DataListItem item in DataList1.Items)
                {
                    string str = ((Label)item.FindControl("ans")).Text;
                    if (((Label)item.FindControl("ans")).Text.Equals(""))
                    {
                        ((Button)item.FindControl("answerQ")).Visible = true;
                    }
                    else
                    {
                        str = ((Label)item.FindControl("ans")).Text;
                    }
                }
            }
        }

        public void PopulateDatalist()
        {
            fqnasService fs = new fqnasService();
            DataSet ds = fs.GetFaqs();
            userService us = new userService();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string us1Name = (us.GetUser(ds.Tables[0].Rows[i][1].ToString())).Tables[0].Rows[0][1].ToString() + " " + (us.GetUser(ds.Tables[0].Rows[i][1].ToString())).Tables[0].Rows[0][2].ToString();
                ds.Tables[0].Rows[i][1] = us1Name + ": ";
                if (!ds.Tables[0].Rows[i][2].ToString().Equals(""))
                {
                    string us2Name = (us.GetUser(ds.Tables[0].Rows[i][2].ToString())).Tables[0].Rows[0][1].ToString() + " " + (us.GetUser(ds.Tables[0].Rows[i][2].ToString())).Tables[0].Rows[0][2].ToString();
                    ds.Tables[0].Rows[i][2] = us2Name + ": ";
                }
            }
            DataList1.DataSource = ds;
            DataList1.DataBind();
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "AnswerQuest")
            {
                Session["questNum"] = Convert.ToInt32(DataList1.DataKeys[e.Item.ItemIndex]);
                Response.Redirect("qAnswer.aspx");
            }
        }

        protected void askQ_Click(object sender, EventArgs e)
        {
            Response.Redirect("qAsk.aspx");
        }
    }
}