using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace compuSciProj2021
{
    public partial class usersData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PopulateGrid();
            if (Session["curUser"] != null && ((User)Session["curUser"]).Manager)
            {
                hello.Text = "Hello, " + ((User)Session["curUser"]).Firstname;
            }
            else
            {
                Response.Redirect("Homepage.aspx");
            }
        }

        public void PopulateGrid()
        {
            userService us = new userService();
            GridView1.DataSource = us.GetUsers();
            GridView1.DataBind();
        }

        protected void del_Click(object sender, EventArgs e)
        {
            if (validation.idExists(idNum.Text))
            {
                userService us = new userService();
                us.LogicalDelete(idNum.Text);
                IDWrng.Text = "";
            }
            else
            {
                idNum.Text = "";
                IDWrng.Text = "Please enter valid id number.";
            }
        }
    }
}