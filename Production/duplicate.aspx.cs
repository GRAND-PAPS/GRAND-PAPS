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
                        if (dt.Rows.Count > 0)
                        {
                            ResultGridView.DataSource = dt;
                            ResultGridView.DataBind();
                        }
                        else if (dt.Rows.Count == 0)
                        {
                            dt = null;
                            ResultGridView.DataSource = dt;
                            ResultGridView.DataBind();

                            lblStatus.Text = "No Data Available";
                        }
                        //else if(dt.Rows.Count<0)
                        //{
                        //    foreach(GridViewRow gvr in ResultGridView.Rows)
                        //    {
                        //        DataRow dr = dt.NewRow();
                        //        dr["Personid"] = gvr.Cells[0].Text;
                        //        dr["Surname"] = gvr.Cells[1].Text;
                        //        dr["Othernames"] = gvr.Cells[2].Text;
                        //        dr["Firstname"] = gvr.Cells[3].Text;
                        //        dr["ApplicantDateofRegistration"] = DateTime.Parse( gvr.Cells[4].Text);
                        //        dr["DuplicateId"] = gvr.Cells[5].Text;
                        //        dr["DuplicateSurname"] = gvr.Cells[6].Text;
                        //        dr["DuplicateOthernames"] = gvr.Cells[7].Text;
                        //        dr["DuplicateFirstname"] = gvr.Cells[8].Text;
                        //        dr["DuplicateDateofRegistration"] = gvr.Cells[9].Text;
                        //        dt.Rows.Add(dr);


                        //    }
                        //    DataRow drn = dt.NewRow();
                        //    drn["Personid"] = 0;
                        //    drn["Surname"] = 0;
                        //    drn["Othernames"] = 0;
                        //    drn["Firstname"] = 0;
                        //    drn["ApplicantDateofRegistration"] = DateTime.Now;
                        //    drn["DuplicateId"] = 0;
                        //    drn["DuplicateSurname"] = 0;
                        //    drn["DuplicateOthernames"] = 0;
                        //    drn["DuplicateFirstname"] = 0;
                        //    drn["DuplicateDateofRegistration"] = DateTime.Now;

                        //    dt.Rows.Add(drn);
                        //    ResultGridView.DataSource = dt;
                        //    ResultGridView.DataBind();
                        //}
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