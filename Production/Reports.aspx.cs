using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Production.Model;

namespace Production
{
    public partial class Reports : System.Web.UI.Page
    {
        RegistrationData regdata = new RegistrationData();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void drpreportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (drpreportType.Text != "SELECT REPORT TYPE")
            {
                DIsplay();
            }
            else { hideDetails(); }
        }
        void DIsplay()
        {
            EndDate.Visible = true;
            StartDate.Visible = true;
            lblEndDate.Visible = true;
            lblStartDate.Visible = true;
            rd1.Visible = true;
            rd2.Visible = true;

            if(drpreportType.Text == "PRINTING REPORT" || drpreportType.Text== "DUPLICATES REPORT" || drpreportType.Text== "BLACKLIST REPORT")
            {
                rd1.Text = "By District";
                rd2.Text = "By User";
            }
            else if(drpreportType.Text== "REGISTRATION REPORTS")
            {
                //rd1.Text = "By District";
                rd1.Visible = false;
                rd2.Text = "By Gender";
            }
        }
        void hideDetails()
        {
            EndDate.Visible = false;
            StartDate.Visible = false;
            lblEndDate.Visible = false;
            lblStartDate.Visible = false;
            rd1.Visible = false;
            rd2.Visible = false;

        }

        protected void btnLoad_Click(object sender, EventArgs e)
        {
            gridResult.DataSource = regdata.GetregistrationByDate(StartDate.Text, EndDate.Text);
            gridResult.DataBind();
        }
        void DisplayData()
        {
            if(drpreportType.Text== "REGISTRATION REPORTS")
            {
                if (rd2.Checked == true) { regdata.GetRegistrationByGender(StartDate.Text, EndDate.Text); }
                else if (rd2.Checked == false) { regdata.GetregistrationByDate(StartDate.Text,EndDate.Text); }
            }
            else if(drpreportType.Text== "PRINTING REPORT")
            {
                
            }
        }
    }
}