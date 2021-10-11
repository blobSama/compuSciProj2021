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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["curUser"] != null)
            {
                hello.Text = "Hello, " + ((User)Session["curUser"]).Firstname;
            }
            else
            {
                hello.Text = "Hello, Guest";

            }
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            string firstN = Request.Form["fName"];
            string lastN = Request.Form["lName"];
            string mail = Request.Form["mail"];
            int age = int.Parse(Request.Form["age"]);
            string pass = Request.Form["password"];
            string passVrfy = Request.Form["passwordConfirm"];
            string id = UId.Text;

            User u1 = new User();
            u1.Addrs = mail;
            u1.Age = age;
            u1.Firstname = firstN;
            u1.Lastname = lastN;
            u1.pssWrd = pass;
            u1.passwordVerify = passVrfy;
            u1.ID = id;

            if (validation.CheckUser(u1))
            {
                userService us = new userService();
                DataSet ds = us.GetUser(u1.ID);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    us.InsertUser(u1);
                    Session["curUser"] = u1;
                    Session["curUserFName"] = u1.Firstname;
                    Response.Redirect("Homepage.aspx");
                }
                else
                {
                    submit.Enabled = false;
                    submit.CssClass = "sub1";
                    csWrong.Text = "User already exists.";
                }
            }
            else
            {
                submit.Enabled = false;
                submit.CssClass = "sub1";
                csWrong.Text = "Something went wrong. Please try again.";
            }
        }
    }
}