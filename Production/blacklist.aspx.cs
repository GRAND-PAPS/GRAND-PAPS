using Production.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
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
            BlackListData bd = new BlackListData();

            string query = "select p.PersonId, FirstName,OtherNames,Surname,DateOfBirth,DateOfRegistration,d.Name as District, (select Blob from PersonBlob pb where Type=16 and pb.PersonId=p.PersonId ) as Photo " +
                "from Person p join Village v on v.VillageId=p.PlaceOfRegistrationId join Section s on s.SectionId=v.SectionId join Chiefdom c on c.ChiefdomId=s.ChiefdomId join District d on d.DistrictId=c.DistrictId " +
                "where Status=285 and PersonId='" + row.Cells[1].Text + "'";

            using (SqlConnection con = new SqlConnection(DBConnects.GetConnection()))
            {
                //int id = int.Parse(row.Cells[0].Text);
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable data = new DataTable();
                        adapter.Fill(data);

                        lblPersonID.Text = data.Rows[0]["Personid"].ToString();
                        bfirstnamelbl.Text = data.Rows[0]["firstname"].ToString();
                        bothernameslbl.Text = data.Rows[0]["othernames"].ToString();
                        bsurnamelbl.Text = data.Rows[0]["Surname"].ToString();
                        bDOBlbl.Text = data.Rows[0]["DateOfBirth"].ToString();
                        bRegistrationlbl.Text = data.Rows[0]["DateOfRegistration"].ToString();
                        bDistrict.Text = data.Rows[0]["District"].ToString();



                        //string id = data.Rows[0]["PersonId"].ToString();
                        string id = "50865";
                        Bpicture.Visible = id != "0";
                        if (id != "0")
                        {
                            byte[] bytes = (byte[])GetData("SELECT top 1 blob FROM personblob WHERE Type=17 and PersonId =" + id).Rows[0]["blob"];
                            string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
                            Bpicture.ImageUrl = "data:image/png;base64," + base64String;
                        }

                    }
                }
            }
        }
        private DataTable GetData(string query)
        {
            DataTable dt = new DataTable();
            //string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(DBConnects.GetConnection()))
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(dt);
                    }
                }
                return dt;
            }
        }
        protected void dataGridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dataGridView1.PageIndex = e.NewPageIndex;
            this.TADropDown_SelectedIndexChanged(sender, e);
        }

        protected void Blacklistbtn_Click(object sender, EventArgs e)
        {
            BlackListData blackListData = new BlackListData();
            using(SqlConnection con = new SqlConnection(DBConnects.GetConnection()))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(blackListData.SendToBlackList(lblPersonID.Text), con))
                {
                    cmd.ExecuteNonQuery();
                    blacklistagelbl.Text = lblPersonID.Text + " Succesfully blacklisted";
                }
                con.Close();
            }
        }

        protected void removeblacklistbtn_Click(object sender, EventArgs e)
        {
            BlackListData blackListData = new BlackListData();
            using (SqlConnection con = new SqlConnection(DBConnects.GetConnection()))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(blackListData.RemoveBlackList(lblPersonID.Text), con))
                {
                    cmd.ExecuteNonQuery();
                    blacklistagelbl.Text = lblPersonID.Text + " Succesfully Removed from blacklisted";
                }
                con.Close();
            }
            this.TADropDown_SelectedIndexChanged(sender, e);
        }
    }
}