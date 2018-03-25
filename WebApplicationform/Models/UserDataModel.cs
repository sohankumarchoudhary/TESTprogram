using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationform.Models
{
    public class UserDataModel
    {

        public string Name { get; set; }
        public int mobileno { get; set; }
        public string City { get; set; }

        public int SaveDetails()
        {
            SqlConnection con = new SqlConnection(GetConString.ConString());
            string query = "INSERT INTO Profile (Id, Name, mobileno, City) values (" + 14+", '" + Name + "','" + mobileno + "','" + City + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
}
