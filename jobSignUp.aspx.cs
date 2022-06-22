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
    public partial class jobs : System.Web.UI.Page
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
                Response.Redirect("Homepage.aspx");
            }
            if (!Page.IsPostBack)
            {
                populateDropDown();
            }
        }
        
        public void populateDropDown()
        {
            JobsService.jobsService j = new JobsService.jobsService();
            DropDownList1.DataSource = j.GetCitis();
            DropDownList1.DataTextField = "cityName";
            DropDownList1.DataValueField = "cityNum";
            DropDownList1.DataBind();
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            JobsService.jobsService js = new JobsService.jobsService();
            string id = ((User)Session["curUSer"]).ID;
            string fName = ((User)Session["curUSer"]).Firstname;
            string lName = ((User)Session["curUSer"]).Lastname;
            string addrs = usrAddrs.Text;
            string phone = usrPhone.Text;
            string mailAdd = ((User)Session["curUSer"]).Addrs;
            int city = int.Parse(DropDownList1.SelectedValue);
            js.InsertUsr(id, fName, lName, addrs, phone, mailAdd, city);
            Response.Redirect("jobsForYou.aspx");
        }
    }
}