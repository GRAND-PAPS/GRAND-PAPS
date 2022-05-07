using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Production
{
    public partial class Reports : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void drpreportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //result = x > y ? "x is greater than y" : "x is less than y";

            //drpreportType.Text != "SELECT REPORT TYPE" ?{ DIsplay(); }: { hideDetails(); }

            if (drpreportType.Text != "SELECT REPORT TYPE")
            {
                DIsplay();
            }
            else { hideDetails(); }
            //lblStartDate.Text = drpreportType.Text;
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
                rd1.Text = "By District";
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
    }
}