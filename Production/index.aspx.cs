﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Production
{
    public partial class index : System.Web.UI.Page
    {
        //SqlConnection con = new SqlConnection(@"Data Source=DBC\NRB;Initial Catalog=Inrs;User ID=ApplicationUser;Password=spudR8N2");
        //SqlConnection con = new SqlConnection(@"Data Source=GRANDPA\GRANDPA;Initial Catalog=INRS2;Integrated Security=True");

        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    Getcardprinted();
        //    Getdayshift();
        //    Getnightshift();
        //}

        //public void Getcardprinted()
        //{
        //    con.Open();
        //    string query = "select COUNT(*) from PersonCard where status=250 and CONVERT(date, DateofIssue,113) = Cast(GETDATE() as date)";
        //    SqlCommand command = new SqlCommand(query, con);
        //    command.ExecuteNonQuery();

        //    string regist = command.ExecuteScalar().ToString();
        //    int reg = int.Parse(regist);
        //    printedtoday.Text = string.Format("{0:0,0}", reg);


        //}

        //public void Getdayshift()
        //{
        //    string query = "select COUNT(*) " +
        //        "from PersonCard where CONVERT(date, DateOfIssue, 113) = Cast(GETDATE() as date) " +
        //        "and Status in (250) and CONVERT(varchar(8), DateOfIssue,108) between '07:00' and '16:10'";
        //    SqlCommand command = new SqlCommand(query, con);
        //    command.ExecuteNonQuery();

        //    string regist = command.ExecuteScalar().ToString();
        //    int reg = int.Parse(regist);
        //    dayshiftprinted.Text = string.Format("{0:0,0}", reg);
        //}

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