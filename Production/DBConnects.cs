using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Production
{
    public class DBConnects
    {
        public static string GetConnection()
        {
            //string query = @"Data Source=DBC\NRB;Initial Catalog=Inrs;User ID=ApplicationUser;Password=spudR8N2";
           string query  = @"Data Source=GRANDPA\GRANDPA;Initial Catalog=INRS2;Integrated Security=True";
           // string query = @"Data Source=ISSAH\SQLEXPRESS;Initial Catalog=INRS2;Persist Security Info=True;User ID=sa;Password=lengan1";

            return query;
        }
    }
}