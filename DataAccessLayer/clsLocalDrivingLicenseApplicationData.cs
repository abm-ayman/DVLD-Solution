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
    public static class clsLocalDrivingLicenseApplicationData
    {
        public static int AddLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationDTO dto)
        {
            string query = @"
                            INSERT INTO [dbo].[LocalDrivingLicenseApplications]
                            (
                                ApplicationID,
                                LicenseClassID
                            )
                            VALUES
                            (
                                @ApplicationID,
                                @LicenseClassID
                            );

                            SELECT CAST(SCOPE_IDENTITY() AS INT);";

            using (SqlConnection connection = new SqlConnection(DataAccessLayer.Settings.clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                DataAccessLayer.Mappers.LocalDrivingLicenseApplicationMapper.MapToCommand(command, dto, includeID: false);

                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int newID))
                {
                    return newID;
                }
            }

            return -1;
        }
        public static LocalDrivingLicenseApplicationDTO GetByApplicationID(int applicationID)
        {
            string query = @"
                            SELECT LocalDrivingLicenseApplicationID,
                                   ApplicationID,
                                   LicenseClassID
                            FROM LocalDrivingLicenseApplications
                            WHERE ApplicationID = @ApplicationID;";

            using (SqlConnection connection = new SqlConnection(DataAccessLayer.Settings.clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@ApplicationID", SqlDbType.Int).Value = applicationID;

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return DataAccessLayer.Mappers.LocalDrivingLicenseApplicationMapper
                            .FromReader(reader);
                    }
                }
            }

            return null;
        }

    }
}
