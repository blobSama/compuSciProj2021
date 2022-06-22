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
    public partial class jobsForYou : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["curUser"] != null)
            {
                if (isInWebService(((User)Session["curUser"]).ID))
                {
                    hello.Text = "Hello, " + ((User)Session["curUser"]).Firstname;
                }
                else
                {
                    Response.Redirect("jobSignUp.aspx");
                }
            }
            else
            {
                Response.Redirect("Homepage.aspx");
            }
            if (!Page.IsPostBack)
            {
                if (isWorkplace(((User)Session["curUser"]).ID))
                {
                    populateDataListW();
                    replies.Visible = false;
                    DataList2.Visible = false;
                    DropDownList1.Visible = false;
                    DropDownList2.Visible = false;
                    sort.Visible = false;
                    ddlList.Visible = false;
                }
                else
                {
                    populateDataListU();
                    DataList1.Visible = false;
                    addOffer.Visible = false;
                    populateDropDown();
                    DropDownList1.Items.Insert(0, new ListItem("Choose City:", "0"));
                    DropDownList2.Items.Insert(0, new ListItem("Choose Time of Upload:", "0"));
                }
            }
            DropDownList1.BackColor = System.Drawing.Color.FromArgb(22, 57, 95);
            DropDownList2.BackColor = System.Drawing.Color.FromArgb(22, 57, 95);
        }

        public void populateDropDown()
        {
            JobsService.jobsService js = new JobsService.jobsService();
            DropDownList1.DataSource = js.GetCitis();
            DropDownList1.DataTextField = "cityName";
            DropDownList1.DataValueField = "cityNum";
            DropDownList1.DataBind();
        }
        public void populateDataListW()
        {
            JobsService.jobsService js = new JobsService.jobsService();
            DataSet ds = js.GetApplyingUsrs(((User)Session["curUser"]).ID);
            string[] ids = new string[ds.Tables[0].Rows.Count];
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ids[i] = ds.Tables[0].Rows[i][0].ToString();
                string s1 = js.GetUsrInfo(ds.Tables[0].Rows[i][0].ToString()).Tables[0].Rows[0][0].ToString() + " " + js.GetUsrInfo(ds.Tables[0].Rows[i][0].ToString()).Tables[0].Rows[0][1].ToString();
                ds.Tables[0].Rows[i][0] = s1;
            }
            Session["usrIds"] = ids;
            DataList1.DataSource = ds;
            DataList1.DataBind();
        }

        public void populateDataListU()
        {
            JobsService.jobsService js = new JobsService.jobsService();
            DataSet ds = js.Getjobs();
            DataList2.DataSource = ds;
            DataList2.DataBind();
        }

        public bool isInWebService(string id)
        {
            JobsService.jobsService js = new JobsService.jobsService();
            DataSet ds = js.GetUsrInfo(id);
            if (ds.Tables[0].Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isWorkplace(string id)
        {
            JobsService.jobsService js = new JobsService.jobsService();
            DataSet ds = js.findwrkplce(id);
            if (ds.Tables[0].Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected void DataList2_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "applyForJob")
            {
                JobsService.Application app = new JobsService.Application();
                JobsService.jobsService js = new JobsService.jobsService();
                int num = Convert.ToInt32(DataList2.DataKeys[e.Item.ItemIndex]);
                string id = ((User)Session["curUser"]).ID;
                app.UserId = id;
                app.offerNumber = num;
                DataSet ds = js.WrkplceByOffr(num);
                app.WorkId = ds.Tables[0].Rows[0][0].ToString();
                if (!js.isApplied(num, app.UserId))
                {
                    Session["userApplication"] = app;
                    Response.Redirect("applyForJob.aspx");
                }
                else
                {
                    Response.Write("<script>alert('You can only apply for a job once.');</script>");
                }
            }
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "applicationReply")
            {
                Session["applicationReply"] = DataList1.DataKeys[e.Item.ItemIndex];
                Label userId = (Label)(DataList1.Items[e.Item.ItemIndex].FindControl("usrId"));
                Session["userReplyId"] = ((string[])Session["usrIds"])[e.Item.ItemIndex];
                Response.Redirect("replyToApplication.aspx");
            }
        }

        protected void sort_Click(object sender, EventArgs e)
        {
            int date = Convert.ToInt32(DropDownList2.SelectedValue);
            int city = Convert.ToInt32(DropDownList1.SelectedValue);
            JobsService.jobsService js = new JobsService.jobsService();
            DataList2.DataSource = js.GetSortedJobs(city, date);
            DataList2.DataBind();
        }
    }
}