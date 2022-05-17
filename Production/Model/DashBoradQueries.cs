using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Production.Model
{
    public class DashBoradQueries
    {
        public int Getcardprinted()
        {
            string query = "select COUNT(*) from Person where status=190";
            int result;
            using (SqlConnection con = new SqlConnection(DBConnects.GetConnection()))
            {
                con.Open();
                using(SqlCommand cmd = new SqlCommand(query,con))
                {
                    result = int.Parse( cmd.ExecuteScalar().ToString());
                }
                con.Close();
            }
            return result;
        }
        public int Getdayshift()
        {
            string query = "select COUNT(*) from Person where status=150";
            int result;
            using (SqlConnection con = new SqlConnection(DBConnects.GetConnection()))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    result = int.Parse( cmd.ExecuteScalar().ToString());
                }
                con.Close();
            }
            return result;
        }
        public int Getnightshift()
        {
            string query = "select COUNT(*)from Person where status=250";
            int result;
            using (SqlConnection con = new SqlConnection(DBConnects.GetConnection()))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    result = int.Parse(cmd.ExecuteScalar().ToString());
                }
                con.Close();
            }
            return result;
        }
    }
}