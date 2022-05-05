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
            if(!Page.IsPostBack)
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
            DistrictDropDown.Items.Clear();
            DistrictDropDown.Items.Insert(0,"SELECT DISTRICT");
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
            TADropDown.Items.Clear();
            //TADropDown.Items.Add("SELECT TA");

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

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Persontextbox.Enabled = true;
            Pintextbox.Enabled = false;
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Persontextbox.Enabled = false;
            Pintextbox.Enabled = true;
        }
        void SearchByPersonId()
        {
            using(SqlConnection con = new SqlConnection(DBConnects.GetConnection()))
            {
                using(SqlCommand command = new SqlCommand("",con))
                {

                }
            }
        }

        protected void TADropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(DBConnects.GetConnection()))
            {
               // string query = "select PersonId,surname,firstname from Person p join Village v on v.VillageId=p.PlaceOfRegistrationId " +
                string query = "select PersonId,surname from Person p join Village v on v.VillageId=p.PlaceOfRegistrationId " +
                    "join Section s on s.SectionId=v.SectionId join Chiefdom c on c.ChiefdomId=s.ChiefdomId join District d on d.DistrictId=c.DistrictId " +
                    "where RegistrationType=2 and status=285 and c.Name='"+TADropDown.SelectedItem.ToString()+"'";
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                        dataGridView1.DataBind();
                    }
                }
                con.Close();
            }
        }

        protected void dataGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = dataGridView1.SelectedRow;
            bfirstnamelbl.Text = row.Cells[1].Text;
            bothernameslbl.Text = row.Cells[1].Text;
            bsurnamelbl.Text = row.Cells[1].Text;
            bDOBlbl.Text = row.Cells[1].Text;
            bRegistrationlbl.Text = row.Cells[1].Text;
            bDistrict.Text = row.Cells[1].Text;
        }
    }
}