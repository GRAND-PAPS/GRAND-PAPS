using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Production
{
    public partial class blacklist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                LoadDistrict();
            }
            
        }
        public void LoadRecords()
        {
            DataTable Records = new DataTable();

            using(SqlConnection con = new SqlConnection(DBConnects.GetConnection()))
            {

            }
        }
        public void LoadDistrict()
        {
            DistrictDropDown.Items.Add("SELECT DISTRICT");
            using (SqlConnection con = new SqlConnection(DBConnects.GetConnection()))
            {
                string query = "select * from district where districtid>0 order by name";
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DistrictDropDown.DataSource = dt;
                        DistrictDropDown.DataBind();
                    }
                }
                con.Close();
            }
        }

        protected void DistrictDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TADropDown.Items.Clear();
            TADropDown.Items.Add("SELECT TA");

            using (SqlConnection con = new SqlConnection(DBConnects.GetConnection()))
            {
                string query = "select * from chiefdom where DistrictId=" + DistrictDropDown.SelectedValue+" order by name";
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        TADropDown.DataSource = dt;
                        TADropDown.DataBind();
                    }
                }
                con.Close();
            }
        }
    }
}