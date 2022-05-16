using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace Production.Model
{
    public class BlackListData
    {
        public DataTable GetBlackListedData(int personid)
        {
            DataTable dataTable = new DataTable();
            
            using(SqlConnection con = new SqlConnection(DBConnects.GetConnection()))
            {
                con.Open();
                using(SqlCommand cmd = new SqlCommand(GetBlackListDataQuery(personid), con))
                {
                    using(SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
                con.Close();
            }
            return dataTable;
        }
        public string GetBlackListDataQuery(int personid)
        {
            string query = "select p.PersonId, FirstName,OtherNames,Surname,DateOfBirth,DateOfRegistration,d.Name as District, (select Blob from PersonBlob pb where Type=16 and pb.PersonId=p.PersonId ) as Photo " +
                "from Person p join Village v on v.VillageId=p.PlaceOfRegistrationId join Section s on s.SectionId=v.SectionId join Chiefdom c on c.ChiefdomId=s.ChiefdomId join District d on d.DistrictId=c.DistrictId " +
                "where Status=285 and PersonId='" + personid + "'";

            return query;
        }
    }
}