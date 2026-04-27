using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Settings
{
    public static class clsConnectionStrings
    {
        public static string DVLDConnectionString = "Server=.;Database=DVLD;User Id=sa;Password=123456;";

        public static void SetSQLConnectionConfig(string query)
        {
            SqlCommand command = new SqlCommand(query);

            SqlConnection connection = new SqlConnection(DataAccessLayer.Settings.clsConnectionStrings.DVLDConnectionString);
        }

    }
}
