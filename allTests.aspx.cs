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
    public partial class allTests : System.Web.UI.Page
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
                    DataList2.Visible = false;
                    populateDataListU();
                }
                else
                {
                    DataList1.Visible = false;
                    populateDataListM();
                }
            }
            else
            {
                Response.Redirect("Homepage.aspx");
            }
        }

        public void populateDataListU()
        {
            DataList1.DataSource = GetData();
            DataList1.DataBind();
        }

        private DataSet GetData()
        {
            string userdId = ((User)Session["curUser"]).ID;
            testService ts = new testService();
            return ts.GetAllComplTests(userdId);
        }

        public void populateDataListM()
        {
            DataList2.DataSource = GetDataM();
            DataList2.DataBind();
        }

        private DataSet GetDataM()
        {
            testService ts = new testService();
            return ts.GetAllComplTestsM();
        }

        protected void dis_Click(object sender, EventArgs e)
        {
            Session["curUser"] = null;
        }
    }
}