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
    public static class clsTestData
    {
        public static int AddTest(TestDTO dto)
        {
            string query = @"
    INSERT INTO [dbo].[Tests]
    (
        TestAppointmentID,
        TestResult,
        Notes,
        CreatedByUserID
    )
    VALUES
    (
        @TestAppointmentID,
        @TestResult,
        @Notes,
        @CreatedByUserID
    );

    SELECT CAST(SCOPE_IDENTITY() AS INT);";

            using (SqlConnection connection = new SqlConnection(DataAccessLayer.Settings.clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                DataAccessLayer.Mappers.TestMapper.MapToCommand(command, dto, includeID: false);

                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int testID))
                {
                    return testID;
                }
            }

            return -1;
        }

        public static TestDTO GetTestByAppointmentID(int testAppointmentID)
        {
            string query = @"
    SELECT TestID,
           TestAppointmentID,
           TestResult,
           Notes,
           CreatedByUserID
    FROM Tests
    WHERE TestAppointmentID = @TestAppointmentID;";

            using (SqlConnection connection = new SqlConnection(DataAccessLayer.Settings.clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@TestAppointmentID", SqlDbType.Int).Value = testAppointmentID;

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return DataAccessLayer.Mappers.TestMapper.FromReader(reader);
                    }
                }
            }

            return null;
        }

        public static List<TestDTO> GetAllTests()
        {
            List<TestDTO> tests = new List<TestDTO>();

            string query = @"
    SELECT TestID,
           TestAppointmentID,
           TestResult,
           Notes,
           CreatedByUserID
    FROM Tests
    ORDER BY TestID DESC;";

            using (SqlConnection connection = new SqlConnection(DataAccessLayer.Settings.clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tests.Add(
                            DataAccessLayer.Mappers.TestMapper.FromReader(reader)
                        );
                    }
                }
            }

            return tests;
        }



    }

}
