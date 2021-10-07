using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Windows.Input;

namespace compuSciProj2020
{
    public partial class updateInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["curUser"] != null)
            {
                hello.Text = "Hello, " + ((User)Session["curUser"]).Firstname;
                PopulateLabels();
                passwordChnge.Attributes["type"] = "password";
                passwordVrfy.Attributes["type"] = "password";
            }
            else
            {
                Response.Redirect("Homepage.aspx");
            }
        }

        protected void PopulateLabels()
        {
            firstName.Text = ((User)Session["curUser"]).Firstname;
            lastName.Text = ((User)Session["curUser"]).Lastname;
            mail.Text = ((User)Session["curUser"]).Addrs;
            ageShow.Text = ((User)Session["curUser"]).Age.ToString();
        }

        protected void showPass_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('Password is: " + ((User)Session["curUser"]).pssWrd + "');</script>");
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string firstN = fNameChange.Text;
            string lastN = lNameChange.Text;
            string email = mailChange.Text;
            int age;
            string pass = passwordChnge.Text;
            string passVrfy = passwordVrfy.Text;
            string id = ((User)Session["curUser"]).ID;
            if(string.IsNullOrEmpty(fNameChange.Text))
            {
                firstN = ((User)Session["curUser"]).Firstname;
            }

            if (string.IsNullOrEmpty(lNameChange.Text))
            {
                lastN = ((User)Session["curUser"]).Lastname;
            }

            if (string.IsNullOrEmpty(mailChange.Text))
            {
                email = ((User)Session["curUser"]).Addrs;
            }

            if (string.IsNullOrEmpty(ageChange.Text))
            {
                age = ((User)Session["curUser"]).Age;
            }
            else
            {
                age = int.Parse(ageChange.Text);
            }

            if (string.IsNullOrEmpty(passwordChnge.Text))
            {
                pass = ((User)Session["curUser"]).pssWrd;
                passVrfy = pass;
            }
            
            User u1 = new User();
            u1.Addrs = email;
            u1.Age = age;
            u1.Firstname = firstN;
            u1.Lastname = lastN;
            u1.pssWrd = pass;
            u1.passwordVerify = passVrfy;
            u1.ID = id;

            if (validation.CheckUser(u1))
            {
                userService us = new userService();
                us.UpdateUser(u1);
                Session["curUser"] = u1;
                Session["curUserFName"] = u1.Firstname;
                Response.Redirect("Homepage.aspx");
            }
            else
            {
                Submit.CssClass = "sub1";
                csWrng.Text = "Something went wrong. Please check your input fits the description and try again..";
            }
        }
    }
}