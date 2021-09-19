using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace accommodation_management
{
    public class Utilities
    {
        public SqlDataReader SqlQuery(string query)
        {
            string connectString;
            // change "AttachDbFilename" to the path of the .mdf file on your computer
            connectString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =C:\Users\hasan\OneDrive\Documents\accommodation-management\acm.mdf; Integrated Security = True";
            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = new SqlConnection(connectString);
            conn.Open();
            cmd = new SqlCommand(query, conn);
            SqlDataReader dr;
            // this should have the data from the db
            dr = cmd.ExecuteReader();

            // dr has the data that we should use to login the user


            // closing the connection
            // dr.Close();

            //conn.Close();
            dr.Read();
            return dr;
        }
    }
}
