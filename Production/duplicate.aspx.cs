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
    public partial class duplicate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DuplicateRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            duplicateidtextbox.Enabled = true;
            Personidtextbox.Enabled = false;

        }

        protected void DuplicateRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Personidtextbox.Enabled = true;
            duplicateidtextbox.Enabled = false;

        }
        void GetPersonId()
        {
            using (SqlConnection con = new SqlConnection(DBConnects.GetConnection()))
            {
                // string query = "select PersonId,surname,firstname from Person p join Village v on v.VillageId=p.PlaceOfRegistrationId " +
                string query = "SELECT PersonId, (select Surname from Person p where p.PersonId=b.PersonId) as Surname,	(select OtherNames from Person p where p.PersonId=b.PersonId) as Othernames, " +
                    "(select FirstName from Person p where p.PersonId=b.PersonId) as Firstname, (select DateOfRegistration from Person p where p.PersonId=b.PersonId) as ApplicantDateofRegistration, DuplicateId, " +
                    "(select Surname from Person p where p.PersonId=b.DuplicateId) as DuplicateSurname,	(select OtherNames from Person p where p.PersonId=b.DuplicateId) as DuplicateOthernames, " +
                    "(select FirstName from Person p where p.PersonId=b.DuplicateId) as DuplicateFirstname, (select DateOfRegistration from Person p where p.PersonId=b.DuplicateId) as DuplicateDateofRegistration from " +
                    "BioResult b where b.PersonId="+Personidtextbox.Text+" or	DuplicateId="+Personidtextbox.Text+"";
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        ResultGridView.DataSource = dt;
                        ResultGridView.DataBind();
                    }
                }
                con.Close();
            }
        }

        protected void duplicatebtn_Click(object sender, EventArgs e)
        {
            GetPersonId();
        }
    }
}