using DataAccessLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mappers
{
    public static class TestMapper
    {
        public static TestDTO FromReader(SqlDataReader reader)
        {
            return new TestDTO
            {
                TestID = (int)reader["TestID"],
                TestAppointmentID = (int)reader["TestAppointmentID"],

                TestResult = (bool)reader["TestResult"],

                Notes = reader["Notes"] != DBNull.Value
                    ? (string)reader["Notes"]
                    : string.Empty,

                CreatedByUserID = (int)reader["CreatedByUserID"]
            };
        }

        public static void MapToCommand(SqlCommand command, TestDTO dto, bool includeID)
        {
            if (includeID)
            {
                command.Parameters.Add("@TestID", SqlDbType.Int).Value = dto.TestID;
            }

            command.Parameters.Add("@TestAppointmentID", SqlDbType.Int)
                   .Value = dto.TestAppointmentID;

            command.Parameters.Add("@TestResult", SqlDbType.Bit)
                   .Value = dto.TestResult;

            command.Parameters.Add("@Notes", SqlDbType.NVarChar, 500).Value =
                string.IsNullOrEmpty(dto.Notes) ? (object)DBNull.Value : dto.Notes;

            command.Parameters.Add("@CreatedByUserID", SqlDbType.Int)
                   .Value = dto.CreatedByUserID;
        }

    }
}
