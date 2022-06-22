using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace compuSciProj2021
{
    public partial class InsertClass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["curUser"] != null && ((User)Session["curUser"]).Manager)
            {
                hello.Text = "Hello, " + ((User)Session["curUser"]).Firstname;
                usrSignIn.Visible = false;
                usrRegister.Visible = false;
            }
            else
            {
                Response.Redirect("Homepage.aspx");
            }
            if (!IsPostBack)
            {
                PopulateDropDown();
            }
            DropDownList1.BackColor = System.Drawing.Color.FromArgb(22, 57, 95);
        }

        public void insertClass()
        {
            string clasTxt = classTxt.Text.Replace("'", "''");
            int topic = Convert.ToInt32(DropDownList1.SelectedValue);
            string subTopicNane = subTopName.Text;
            string quest = question.Text;
            string ans = answer.Text;
            ClassService cs = new ClassService();
            cs.insertClass(topic, subTopicNane, clasTxt, quest, ans);
        }

        public void PopulateDropDown()
        {
            testService ts = new testService();
            DropDownList1.DataSource = ts.getSubjectsGuest();
            DropDownList1.DataTextField = "subjName";
            DropDownList1.DataValueField = "subjNum";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, new ListItem("Choose Topic:", "0"));
        }

        protected void addClass_Click(object sender, EventArgs e)
        {
            insertClass();
            Response.Redirect("learnPy.aspx");
        }
    }
}