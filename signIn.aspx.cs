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
    public partial class signIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["curUser"] != null)
            {
                Response.Redirect("Homepage.aspx");
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
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string id = idTxt.Text;
            string passWord = passTxt.Text;
            userService us = new userService();
            DataSet ds = us.GetUsersByIdAndPas(id, passWord);
            if (ds.Tables[0].Rows.Count != 0 && bool.Parse(ds.Tables[0].Rows[0][6].ToString()))
            {
                User u = new User();
                u.ID = ds.Tables[0].Rows[0][0].ToString();
                u.pssWrd = ds.Tables[0].Rows[0][4].ToString();
                u.Firstname = ds.Tables[0].Rows[0][1].ToString();
                u.Lastname = ds.Tables[0].Rows[0][2].ToString();
                u.Addrs = ds.Tables[0].Rows[0][3].ToString();
                u.Age = Int32.Parse(ds.Tables[0].Rows[0][5].ToString());
                u.Manager = bool.Parse(ds.Tables[0].Rows[0][7].ToString());
                u.CurTop = Convert.ToInt32(ds.Tables[0].Rows[0][8]);
                u.CurSubTop = Convert.ToInt32(ds.Tables[0].Rows[0][9]);
                Session["curUser"] = u;
                Response.Redirect("Homepage.aspx");
            }
            else
            {
                if (ds.Tables[0].Rows.Count == 0)
                {
                    problemShow.Text = "Please enter an existing user or sign up.";
                }
                else
                {
                    if (!bool.Parse(ds.Tables[0].Rows[0][6].ToString()))
                    {
                        problemShow.Text = "Please check with admins activity status.";
                    }
                    else
                    {
                        problemShow.Text = "Please enter an existing user or sign up.";
                    }
                }
            }
        }
    }
}