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
            if (!IsPostBack)
            {
                PopulateGrid();
            }
            
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
            User u = new User();
            
            u.ID = ((GridView1.Rows[e.RowIndex].Cells[0])).Text;
            u.Firstname = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[1].Controls[0])).Text;
            u.Lastname = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[2].Controls[0])).Text;
            u.Addrs = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[3].Controls[0])).Text;
            u.pssWrd = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[5].Controls[0])).Text;
            u.Age = (int.Parse)(((TextBox)(GridView1.Rows[e.RowIndex].Cells[4].Controls[0])).Text);
            u.Active = (bool.Parse)(((TextBox)(GridView1.Rows[e.RowIndex].Cells[6].Controls[0])).Text);
            userService us = new userService();
            us.UpdateUser(u);
            GridView1.EditIndex = -1;
            PopulateGrid();
        }  
    }
}