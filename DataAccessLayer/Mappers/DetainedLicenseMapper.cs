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
    public static class DetainedLicenseMapper
    {
        public static DetainedLicenseDTO FromReader(SqlDataReader reader)
        {
            return new DetainedLicenseDTO
            {
                DetainID = (int)reader["DetainID"],

                LicenseID = (int)reader["LicenseID"],

                DetainDate = (DateTime)reader["DetainDate"],
                FineFees = Convert.ToDecimal(reader["FineFees"]),
                CreatedByUserID = (int)reader["CreatedByUserID"],

                IsReleased = (bool)reader["IsReleased"],

                ReleaseDate = reader["ReleaseDate"] != DBNull.Value
                    ? (DateTime?)reader["ReleaseDate"]
                    : null,

                ReleasedByUserID = reader["ReleasedByUserID"] != DBNull.Value
                    ? (int?)reader["ReleasedByUserID"]
                    : null,

                ReleaseApplicationID = reader["ReleaseApplicationID"] != DBNull.Value
                    ? (int?)reader["ReleaseApplicationID"]
                    : null
            };
        }

        public static void MapToCommand(SqlCommand command, DetainedLicenseDTO dto, bool includeDetainID)
        {
            if (includeDetainID)
            {
                command.Parameters.Add("@DetainID", SqlDbType.Int).Value = dto.DetainID;
            }

            // ALWAYS included (foreign key)
            command.Parameters.Add("@LicenseID", SqlDbType.Int).Value = dto.LicenseID;

            command.Parameters.Add("@DetainDate", SqlDbType.SmallDateTime).Value = dto.DetainDate;
            command.Parameters.Add("@FineFees", SqlDbType.SmallMoney).Value = dto.FineFees;
            command.Parameters.Add("@CreatedByUserID", SqlDbType.Int).Value = dto.CreatedByUserID;

            command.Parameters.Add("@IsReleased", SqlDbType.Bit).Value = dto.IsReleased;

            command.Parameters.Add("@ReleaseDate", SqlDbType.SmallDateTime).Value =
                dto.ReleaseDate.HasValue ? (object)dto.ReleaseDate.Value : DBNull.Value;

            command.Parameters.Add("@ReleasedByUserID", SqlDbType.Int).Value =
                dto.ReleasedByUserID.HasValue ? (object)dto.ReleasedByUserID.Value : DBNull.Value;

            command.Parameters.Add("@ReleaseApplicationID", SqlDbType.Int).Value =
                dto.ReleaseApplicationID.HasValue ? (object)dto.ReleaseApplicationID.Value : DBNull.Value;
        }

    }
}
