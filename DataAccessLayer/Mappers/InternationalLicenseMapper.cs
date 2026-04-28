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
    public static class InternationalLicenseMapper
    {
        public static InternationalLicenseDTO FromReader(SqlDataReader reader)
        {
            return new InternationalLicenseDTO
            {
                InternationalLicenseID = (int)reader["InternationalLicenseID"],
                ApplicationID = (int)reader["ApplicationID"],
                DriverID = (int)reader["DriverID"],
                IssuedUsingLocalLicenseID = (int)reader["IssuedUsingLocalLicenseID"],

                IssueDate = (DateTime)reader["IssueDate"],
                ExpirationDate = (DateTime)reader["ExpirationDate"],

                IsActive = (bool)reader["IsActive"],

                CreatedByUserID = (int)reader["CreatedByUserID"]
            };
        }

        public static void MapToCommand(SqlCommand command, InternationalLicenseDTO dto, bool includeID)
        {
            if (includeID)
            {
                command.Parameters.Add("@InternationalLicenseID", SqlDbType.Int).Value = dto.InternationalLicenseID;
            }

            command.Parameters.Add("@ApplicationID", SqlDbType.Int).Value = dto.ApplicationID;

            command.Parameters.Add("@DriverID", SqlDbType.Int).Value = dto.DriverID;

            command.Parameters.Add("@IssuedUsingLocalLicenseID", SqlDbType.Int).Value = dto.IssuedUsingLocalLicenseID;

            command.Parameters.Add("@IssueDate", SqlDbType.DateTime).Value = dto.IssueDate;

            command.Parameters.Add("@ExpirationDate", SqlDbType.DateTime).Value = dto.ExpirationDate;

            command.Parameters.Add("@IsActive", SqlDbType.Bit).Value = dto.IsActive;

            command.Parameters.Add("@CreatedByUserID", SqlDbType.Int).Value = dto.CreatedByUserID;
        }


    }


}
