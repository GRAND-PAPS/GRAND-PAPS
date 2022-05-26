using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace Production
{
    public partial class index : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            GetcardprintedperPerson();
            GetDistricts();
        }

        public void GetcardprintedperPerson()
        {
            using (SqlConnection con = new SqlConnection(DBConnects.GetConnection()))
            {
                con.Open();
                string query = "select EditUser, COUNT(*) as PrintedToDay from PersonCard where CONVERT(date, DateOfIssue, 113) = Cast(GETDATE() as date) " +
                    "and Status in (250) and CONVERT(varchar(8), DateOfIssue,108) between '07:00' and '18:00' group by EditUser";
                SqlCommand command = new SqlCommand(query, con);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                StringBuilder sb = new StringBuilder();
                sb.Append("<table class='col-lg-12 fs-4'>");
                sb.Append("<tr>");
                foreach(DataColumn dc in dt.Columns)
                {
                    sb.Append("<th>");
                    sb.Append(dc.ColumnName.ToUpper());
                    sb.Append("</th>");
                }
                sb.Append("</tr>");

                foreach(DataRow dr in dt.Rows)
                {
                    sb.Append("<tr>");
                    foreach(DataColumn dc in dt.Columns)
                    {
                        sb.Append("<th>");
                        sb.Append(dr[dc.ColumnName].ToString());
                        sb.Append("</th>");
                    }
                    sb.Append("</tr>");
                }
                sb.Append("</table>");
                Officerspanel.Controls.Add(new Label { Text=sb.ToString() });
                con.Close();
            }

        }

        public void GetDistricts()
        {
            using (SqlConnection con = new SqlConnection(DBConnects.GetConnection()))
            {
                string query = "select d.Name as District, COUNT(*) as PrintedToDay from PersonCard pc " +
                    "join village v on v.VillageId = pc.PlaceOfRegistrationId " +
                    "join section s on s.SectionId = v.SectionId " +
                    "join Chiefdom c on c.ChiefdomId = s.ChiefdomId " +
                    "join District d on d.DistrictId = c.DistrictId " +
                    "where CONVERT(date, pc.DateOfIssue, 113) = Cast(GETDATE() as date) " +
                    "and Status in (250) and CONVERT(varchar(8), pc.DateOfIssue,108) between '07:00' and '18:00' " +
                    "group by d.Name " +
                    "order by d.Name";
                SqlCommand comm = new SqlCommand(query, con);
                con.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                StringBuilder sb = new StringBuilder();
                sb.Append("<table class='col-lg-12 fs-4'>");
                sb.Append("<tr>");
                foreach (DataColumn dc in dt.Columns)
                {
                    sb.Append("<th>");
                    sb.Append(dc.ColumnName.ToUpper());
                    sb.Append("</th>");
                }
                sb.Append("</tr>");

                foreach (DataRow dr in dt.Rows)
                {
                    sb.Append("<tr>");
                    foreach (DataColumn dc in dt.Columns)
                    {
                        sb.Append("<th>");
                        sb.Append(dr[dc.ColumnName].ToString());
                        sb.Append("</th>");
                    }
                    sb.Append("</tr>");
                }
                sb.Append("</table>");
                Districtpanel.Controls.Add(new Label { Text = sb.ToString() });
                con.Close();
            }
        }

        //public void Getnightshift()
        //{
        //    string query = "select COUNT(*) " +
        //       "from PersonCard where CONVERT(date, DateOfIssue, 113) = Cast(GETDATE() as date) " +
        //       "and Status in (250) and CONVERT(varchar(8), DateOfIssue,108) between '16:10' and '23:59'";
        //    SqlCommand command = new SqlCommand(query, con);
        //    command.ExecuteNonQuery();

        //    string regist = command.ExecuteScalar().ToString();
        //    int reg = int.Parse(regist);
        //    dayshiftprinted.Text = string.Format("{0:0,0}", reg);
        //}

    }
}