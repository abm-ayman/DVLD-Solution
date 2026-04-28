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
    public static class LocalDrivingLicenseApplicationMapper
    {
        public static LocalDrivingLicenseApplicationDTO FromReader(SqlDataReader reader)
        {
            return new LocalDrivingLicenseApplicationDTO
            {
                LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"],
                ApplicationID = (int)reader["ApplicationID"],
                LicenseClassID = (int)reader["LicenseClassID"]
            };
        }

        public static void MapToCommand(SqlCommand command, LocalDrivingLicenseApplicationDTO dto, bool includeID)
        {
            if (includeID)
            {
                command.Parameters.Add("@LocalDrivingLicenseApplicationID", SqlDbType.Int)
                       .Value = dto.LocalDrivingLicenseApplicationID;
            }

            command.Parameters.Add("@ApplicationID", SqlDbType.Int)
                   .Value = dto.ApplicationID;

            command.Parameters.Add("@LicenseClassID", SqlDbType.Int)
                   .Value = dto.LicenseClassID;
        }
    }
}
