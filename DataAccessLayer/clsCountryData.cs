using DataAccessLayer.DTOs;
using DataAccessLayer.Mappers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    internal class clsCountryData
    {

        public static DataTable GetAllCountries()
        {
            DataTable dt = new DataTable();

            string query = @"SELECT CountryID,
                            CountryName
                     FROM Countries;";

            using (SqlConnection connection = new SqlConnection(DataAccessLayer.Settings.clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }

            return dt;
        }

        public static CountryDTO GetCountryByID(int countryID)
        {
            string query = @"SELECT CountryID,
                            CountryName
                     FROM Countries
                     WHERE CountryID = @CountryID;";

            using (SqlConnection connection = new SqlConnection(DataAccessLayer.Settings.clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@CountryID", SqlDbType.Int).Value = countryID;

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return CountryMapper.FromReader(reader);
                    }
                }
            }

            return null;
        }


    }
}
