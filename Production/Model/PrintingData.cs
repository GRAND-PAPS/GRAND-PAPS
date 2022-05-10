using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Production.Model
{
    public class PrintingData
    {
        public DataTable GetPrintingByDate(string StartDate, string EndDate)
        {
            DataTable dataTable = new DataTable();

            string query = "select d.Name as District, convert(varchar,cast( count(*) as money),1) as Registrants from Person p join Village v on v.VillageId=p.PlaceOfRegistrationId join Section s on s.SectionId=v.SectionId " +
                "join Chiefdom c on c.ChiefdomId=s.ChiefdomId " +
                "join District d on d.DistrictId=c.DistrictId where convert(date,DateOfRegistration,113) between '" + StartDate + "' and '" + EndDate + "' and RegistrationType=2 group by d.Name order by d.Name";

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
        public DataTable GetPrintingByEditUser(string StartDate, string EndDate)
        {
            DataTable dataTable = new DataTable();

            string query = "select d.Name as District, convert(varchar,cast( count(*) as money),1) as Registrants from Person p join Village v on v.VillageId=p.PlaceOfRegistrationId join Section s on s.SectionId=v.SectionId " +
                "join Chiefdom c on c.ChiefdomId=s.ChiefdomId " +
                "join District d on d.DistrictId=c.DistrictId where convert(date,DateOfRegistration,113) between '" + StartDate + "' and '" + EndDate + "' and RegistrationType=2 group by d.Name order by d.Name";

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