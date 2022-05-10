using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Production.Model
{
    public class DuplicateData
    {
        public DataTable GetTotalOutstandingDuplicates()
        {
            DataTable dataTable = new DataTable();

            string query = "select count(*) as 'Total Duplicates' from Person where RegistrationType=2 and Status=124";

            using (SqlConnection con = new SqlConnection(DBConnects.GetConnection()))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dataTable);
                    }
                }
                con.Close();
            }
            return dataTable;
        }
        public DataTable GetTotalOutstandingDuplicatesByDistrict()
        {
            DataTable dataTable = new DataTable();

            string query = "select d.Name as District, count(*) as 'Total Duplicates' from Person p join Village v on v.VillageId=p.PlaceOfRegistrationId join Section s on s.SectionId=v.SectionId join Chiefdom c on " +
                "c.ChiefdomId=s.ChiefdomId join District d on d.DistrictId=c.DistrictId where RegistrationType=2 and Status=124 group by d.Name order by d.Name";

            using (SqlConnection con = new SqlConnection(DBConnects.GetConnection()))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dataTable);
                    }
                }
                con.Close();
            }
            return dataTable;
        }
        public DataTable GetCleardDuplicatesByUser()
        {
            DataTable dataTable = new DataTable();

            string query = "select count(*) as 'Total Duplicates' from Person where RegistrationType=2 and Status=124";

            using (SqlConnection con = new SqlConnection(DBConnects.GetConnection()))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dataTable);
                    }
                }
                con.Close();
            }
            return dataTable;
        }
        public DataTable GetClearedDuplicatesByDate(string StartDate,string EndDate)
        {
            DataTable dataTable = new DataTable();

            string query = "select count(*) as 'Total Duplicates' from Person where RegistrationType=2 and Status=124";

            using (SqlConnection con = new SqlConnection(DBConnects.GetConnection()))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dataTable);
                    }
                }
                con.Close();
            }
            return dataTable;
        }
    }
}