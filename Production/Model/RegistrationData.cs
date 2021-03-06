using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace Production.Model
{
    public class RegistrationData
    {
        
        public DataTable  GetregistrationByDate(string StartDate, string EndDate)
        {
            DataTable dataTable = new DataTable();

            string query = "select d.Name as District, convert(varchar,cast( count(*) as money),1) as Registrants from Person p join Village v on v.VillageId=p.PlaceOfRegistrationId join Section s on s.SectionId=v.SectionId " +
                "join Chiefdom c on c.ChiefdomId=s.ChiefdomId " +
                "join District d on d.DistrictId=c.DistrictId where convert(date,DateOfRegistration,113) between '"+ StartDate + "' and '"+ EndDate + "' and RegistrationType=2 group by d.Name order by d.Name";

            using(SqlConnection con = new SqlConnection(DBConnects.GetConnection()))
            {
                con.Open();
                using(SqlCommand cmd = new SqlCommand(query,con))
                {
                    using(SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dataTable);
                    }
                }
                con.Close();
            }
            return dataTable;
        }
        public DataTable GetRegistrationByGender(string StartDate, string EndDate)
        {
            DataTable dataTable = new DataTable();

            string query = "select d.Name as District, convert(varchar,cast(sum(case when p.sex=1 then 1 else 0 end) as money),1) as Male, convert(varchar,cast(sum(case when p.sex=2 then 1 else 0 end) as money),1) as Female " +
                "from Person p join Village v on v.VillageId=p.PlaceOfRegistrationId join Section s on s.SectionId=v.SectionId join Chiefdom c on c.ChiefdomId=s.ChiefdomId join District d on d.DistrictId=c.DistrictId " +
                "where convert(date,DateOfRegistration,113) between '"+StartDate+"' and '"+EndDate+"' and RegistrationType=2 group by d.Name order by d.Name";

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