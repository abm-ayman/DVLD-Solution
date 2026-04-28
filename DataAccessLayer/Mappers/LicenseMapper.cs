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
    public static class LicenseMapper
    {
        public static LicenseDTO FromReader(SqlDataReader reader)
        {
            return new LicenseDTO
            {
                LicenseID = (int)reader["LicenseID"],
                ApplicationID = (int)reader["ApplicationID"],
                LicenseClassID = (int)reader["LicenseClassID"],

                IssueDate = (DateTime)reader["IssueDate"],
                ExpirationDate = (DateTime)reader["ExpirationDate"],

                Notes = reader["Notes"] != DBNull.Value
                    ? (string)reader["Notes"]
                    : string.Empty,

                PaidFees = Convert.ToInt32(reader["PaidFees"]),
                IsActive = (bool)reader["IsActive"],
                IssueReasonID = (int)reader["IssueReasonID"],
                CreatedByUserID = (int)reader["CreatedByUserID"]
            };
        }
        public static void MapToCommand(SqlCommand command, LicenseDTO dto, bool includeID)
        {
            if (includeID)
            {
                command.Parameters.Add("@LicenseID", SqlDbType.Int).Value = dto.LicenseID;
            }

            command.Parameters.Add("@ApplicationID", SqlDbType.Int).Value = dto.ApplicationID;

            command.Parameters.Add("@LicenseClassID", SqlDbType.Int).Value = dto.LicenseClassID;

            command.Parameters.Add("@IssueDate", SqlDbType.DateTime).Value = dto.IssueDate;

            command.Parameters.Add("@ExpirationDate", SqlDbType.DateTime).Value = dto.ExpirationDate;

            command.Parameters.Add("@Notes", SqlDbType.NVarChar, 500).Value =
                string.IsNullOrEmpty(dto.Notes) ? (object)DBNull.Value : dto.Notes;

            command.Parameters.Add("@PaidFees", SqlDbType.Int).Value = dto.PaidFees;

            command.Parameters.Add("@IsActive", SqlDbType.Bit).Value = dto.IsActive;

            command.Parameters.Add("@IssueReasonID", SqlDbType.Int).Value = dto.IssueReasonID;

            command.Parameters.Add("@CreatedByUserID", SqlDbType.Int).Value = dto.CreatedByUserID;
        }


    }
}
