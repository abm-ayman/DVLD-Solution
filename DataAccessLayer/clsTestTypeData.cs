using DataAccessLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class clsTestTypeData
    {
        public static List<TestTypeDTO> GetAllTestTypesList()
        {
            List<TestTypeDTO> testTypes = new List<TestTypeDTO>();

            string query = @"
                            SELECT TestTypeID,
                                   TestTypeTitle,
                                   TestTypeDescription,
                                   TestTypeFees
                            FROM TestTypes
                            ORDER BY TestTypeID;";

            using (SqlConnection connection = new SqlConnection(DataAccessLayer.Settings.clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        testTypes.Add(
                            DataAccessLayer.Mappers.TestTypeMapper.FromReader(reader)
                        );
                    }
                }
            }

            return testTypes;
        }

        public static DataTable GetAllTestTypes()
        {
            DataTable dt = new DataTable();

            string query = @"
                            SELECT TestTypeID,
                                   TestTypeTitle,
                                   TestTypeDescription,
                                   TestTypeFees
                            FROM TestTypes
                            ORDER BY TestTypeID;";

            using (SqlConnection connection = new SqlConnection(DataAccessLayer.Settings.clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        dt.Load(reader);
                    }
                }
            }

            return dt;
        }

        public static TestTypeDTO GetTestTypeByID(int testTypeID)
        {
            string query = @"
                            SELECT TestTypeID,
                                   TestTypeTitle,
                                   TestTypeDescription,
                                   TestTypeFees
                            FROM TestTypes
                            WHERE TestTypeID = @TestTypeID;";

            using (SqlConnection connection = new SqlConnection(DataAccessLayer.Settings.clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@TestTypeID", SqlDbType.Int).Value = testTypeID;

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return DataAccessLayer.Mappers.TestTypeMapper.FromReader(reader);
                    }
                }
            }

            return null;
        }

    }
}
