using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Production.Model;

namespace Production
{
    public partial class Production : System.Web.UI.MasterPage
    {
        SqlConnection con = new SqlConnection(DBConnects.GetConnection());

        DashBoradQueries dash = new DashBoradQueries();
        protected void Page_Load(object sender, EventArgs e)
        {
            printedtoday.Text = string.Format("{0:0,0}", dash.Getcardprinted());
            dayshiftprinted.Text = string.Format("{0:0,0}", dash.Getdayshift());
            nightshiftprinted.Text = string.Format("{0:0,0}", dash.Getnightshift());
        }
    }
}