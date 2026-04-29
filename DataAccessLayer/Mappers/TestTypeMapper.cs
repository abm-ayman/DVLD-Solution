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
    public static class TestTypeMapper
    {
        public static TestTypeDTO FromReader(SqlDataReader reader)
        {
            return new TestTypeDTO
            {
                TestTypeID = (int)reader["TestTypeID"],
                TestTypeTitle = (string)reader["TestTypeTitle"],
                TestTypeDescription = (string)reader["TestTypeDescription"],
                TestTypeFees = Convert.ToInt32(reader["TestTypeFees"])
            };
        }

        public static void MapToCommand(SqlCommand command, TestTypeDTO dto, bool includeID)
        {
            if (includeID)
            {
                command.Parameters.Add("@TestTypeID", SqlDbType.Int)
                       .Value = dto.TestTypeID;
            }

            command.Parameters.Add("@TestTypeTitle", SqlDbType.NVarChar, 100)
                   .Value = dto.TestTypeTitle;

            command.Parameters.Add("@TestTypeDescription", SqlDbType.NVarChar, 500)
                   .Value = dto.TestTypeDescription;

            command.Parameters.Add("@TestTypeFees", SqlDbType.Int)
                   .Value = dto.TestTypeFees;
        }

    }
}
