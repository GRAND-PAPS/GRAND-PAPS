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
        public string SendToBlackList(string personid)
        {
            string edituser = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string query = "update person set status = 285 where personid = '" + personid + "' insert into blacklist(PersonId, Pin, Surname, OtherNames, FirstName, DateOfBirth, Sex, " +
                "DateOfRegistration, Telephone, Receipt, Status, EditUser, EditMachine, FirstApprover, SecondAprover, DateOfEdit) select PersonId, Pin, Surname, OtherNames, FirstName, " +
                "DateOfBirth, Sex, DateOfRegistration, Telephone, Receipt,110,'" + edituser + "',EditMachine,'','',getdate() from Person where personid = '" + personid + "'";
            return query;
        }
        public string RemoveBlackList(string personid)
        {
            string edituser = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string query = "update person set status=110 where personid='" + personid + "' insert into blacklist(PersonId,Pin,Surname,OtherNames,FirstName,DateOfBirth,Sex," +
                "DateOfRegistration,Telephone,Receipt,Status,EditUser,EditMachine,FirstApprover,SecondAprover,DateOfEdit) select PersonId,Pin,Surname,OtherNames,FirstName," +
                "DateOfBirth,Sex,DateOfRegistration,Telephone,Receipt,110,'" + edituser + "',EditMachine,'','',getdate() from Person where personid ='" + personid + "'";
            return query;
        }
        public DataTable GetValuesByPeronid(string personid)
        {
            DataTable dataTable = new DataTable();
            string query = "select Receipt,Pin,Surname,FirstName,OtherNames,DateOfBirth,DateOfRegistration,d.Name as District,c.Name as TA, v.Name as Village,Personid from Person p " +
                "join Village v on v.VillageId=p.PlaceOfRegistrationId join Section s on s.SectionId=v.SectionId join Chiefdom c on c.ChiefdomId=s.ChiefdomId join District d on " +
                "d.DistrictId=c.DistrictId where RegistrationType=2 and Personid='" + personid + "'";
            using(SqlConnection con = new SqlConnection(DBConnects.GetConnection()))
            {
                using(SqlCommand cmd = new SqlCommand())
                {

                }
            }
            return dataTable;
        }
    }
}