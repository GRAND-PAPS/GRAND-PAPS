using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Reporting.WebForms;
using System.Configuration;

namespace Production
{
    public partial class manifest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        void RetrieveReport()
        {
            using(SqlConnection con = new SqlConnection(DBConnects.GetConnection()))
            {
                con.Open();
                string sql = "select d.Name as District, c.Name as TA, v.Name as Village, convert(date,DateOfIssue,113) as DateOfIssue, Pin,Surname,FirstName,ManifestId,PrinterId,p.EditUser from PersonCard p join Village v on v.VillageId=p.PlaceOfRegistrationId join Section s on s.SectionId=v.SectionId join Chiefdom c on c.ChiefdomId=s.ChiefdomId join District d on d.DistrictId=c.DistrictId where pin='0WD8KAZ7'";
                using(SqlCommand cmd = new SqlCommand(sql,con))
                {
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if(reader.HasRows)
                        {
                            while(reader.Read())
                            {
                                districtlbl.Text = reader[0].ToString();
                                villagelbl.Text = reader[2].ToString();
                                edituserlbl.Text = reader["edituser"].ToString();
                                //districtlbl.Text = reader[0].ToString();
                            }
                        }
                    }
                }
                con.Close();
            }
            ReportViewer1.LocalReport.DataSources.Clear();

            ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("PrintManifest"));
        }

        protected void manifestsearchbtn_Click(object sender, EventArgs e)
        {
            ReportViewer1.ProcessingMode = ProcessingMode.Local;
            ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/Report.rdlc");
            Customers dsCustomers = GetData("select top 20 * from customers");
            ReportDataSource datasource = new ReportDataSource("Customers", dsCustomers.Tables[0]);
            ReportViewer1.LocalReport.DataSources.Clear();
            ReportViewer1.LocalReport.DataSources.Add(datasource);
        }
        private Customers GetData(string query)
        {
            string conString = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            SqlCommand cmd = new SqlCommand(query);
            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.Connection = con;

                    sda.SelectCommand = cmd;
                    using (Customers dsCustomers = new Customers())
                    {
                        sda.Fill(dsCustomers, "DataTable1");
                        return dsCustomers;
                    }
                }
            }
        }
    }
}