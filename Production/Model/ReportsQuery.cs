using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Production.Model
{
    public class ReportsQuery
    {
        public string GetManifestQuery(string PIN)
        {
            string query = "select d.Name as District, c.Name as TA, v.Name as Village,Pin," +
                "convert(date,DateOfIssue,113) as DateOfIssue, Surname,FirstName,PrinterId,pc.EditUser, " +
                "(select count(*) from PersonCard p1 where p1.ManifestId=pc.ManifestId) as CardCount " +
                "from PersonCard pc join Village v on v.VillageId = pc.PlaceOfRegistrationId join Section s on s.SectionId = v.SectionId" +
                " join Chiefdom c on c.ChiefdomId = s.ChiefdomId join District d on d.DistrictId = c.DistrictId " +
                "where ManifestId = (select ManifestId from PersonCard where pin='"+PIN+"') order by Surname, FirstName";
            return query;
        }
    }
}