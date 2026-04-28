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
    public static class DriverMapper
    {
        public static DriverDTO FromReader(SqlDataReader reader)
        {
            return new DriverDTO
            {
                DriverID = (int)reader["DriverID"],
                PersonID = (int)reader["PersonID"],
                CreatedByUserID = (int)reader["CreatedByUserID"],
                CreatedDate = (DateTime)reader["CreatedDate"]
            };
        }

        public static void MapToCommand(SqlCommand command, DriverDTO dto, bool includeID)
        {
            if (includeID)
            {
                command.Parameters.Add("@DriverID", SqlDbType.Int).Value = dto.DriverID;
            }

            command.Parameters.Add("@PersonID", SqlDbType.Int).Value = dto.PersonID;

            command.Parameters.Add("@CreatedByUserID", SqlDbType.Int).Value = dto.CreatedByUserID;

            command.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = dto.CreatedDate;
        }

    }
}

