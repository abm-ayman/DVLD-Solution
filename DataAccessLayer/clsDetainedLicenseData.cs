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
    internal class clsDetainedLicenseData
    {
        public static DetainedLicenseDTO GetDetainedLicenseByID(int detainID)
        {
            string query = @"
                            SELECT DetainID,
                                   LicenseID,
                                   DetainDate,
                                   FineFees,
                                   CreatedByUserID,
                                   IsReleased,
                                   ReleaseDate,
                                   ReleasedByUserID,
                                   ReleaseApplicationID
                            FROM DetainedLicenses
                            WHERE DetainID = @DetainID;";

            using (SqlConnection connection = new SqlConnection(DataAccessLayer.Settings.clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@DetainID", SqlDbType.Int).Value = detainID;

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return DataAccessLayer.Mappers.DetainedLicenseMapper.FromReader(reader);
                    }
                }
            }

            return null;
        }

        public static DetainedLicenseDTO GetLatestDetainedLicenseByLicenseID(int licenseID)
        {
            string query = @"
                            SELECT TOP 1
                                   DetainID,
                                   LicenseID,
                                   DetainDate,
                                   FineFees,
                                   CreatedByUserID,
                                   IsReleased,
                                   ReleaseDate,
                                   ReleasedByUserID,
                                   ReleaseApplicationID
                            FROM DetainedLicenses
                            WHERE LicenseID = @LicenseID
                            ORDER BY DetainID DESC;";

            using (SqlConnection connection = new SqlConnection(DataAccessLayer.Settings.clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@LicenseID", SqlDbType.Int).Value = licenseID;

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return DataAccessLayer.Mappers.DetainedLicenseMapper.FromReader(reader);
                    }
                }
            }

            return null;
        }

        public static DetainedLicenseDTO GetActiveDetainedLicense(int licenseID)
        {
            string query = @"
                            SELECT TOP 1
                                   DetainID,
                                   LicenseID,
                                   DetainDate,
                                   FineFees,
                                   CreatedByUserID,
                                   IsReleased,
                                   ReleaseDate,
                                   ReleasedByUserID,
                                   ReleaseApplicationID
                            FROM DetainedLicenses
                            WHERE LicenseID = @LicenseID
                              AND IsReleased = 0
                            ORDER BY DetainID DESC;";

            using (SqlConnection connection = new SqlConnection(DataAccessLayer.Settings.clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@LicenseID", SqlDbType.Int).Value = licenseID;

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return DataAccessLayer.Mappers.DetainedLicenseMapper.FromReader(reader);
                    }
                }
            }

            return null;
        }

        public static bool ReleaseLicense(int licenseID, int releasedByUserID, int releaseApplicationID)
        {
            string query = @"
                            UPDATE [dbo].[DetainedLicenses]
                            SET 
                                IsReleased = 1,
                                ReleaseDate = @ReleaseDate,
                                ReleasedByUserID = @ReleasedByUserID,
                                ReleaseApplicationID = @ReleaseApplicationID
                            WHERE LicenseID = @LicenseID
                              AND IsReleased = 0;";

            using (SqlConnection connection = new SqlConnection(DataAccessLayer.Settings.clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@LicenseID", SqlDbType.Int).Value = licenseID;

                command.Parameters.Add("@ReleaseDate", SqlDbType.SmallDateTime).Value = DateTime.Now;

                command.Parameters.Add("@ReleasedByUserID", SqlDbType.Int).Value = releasedByUserID;

                command.Parameters.Add("@ReleaseApplicationID", SqlDbType.Int).Value = releaseApplicationID;

                connection.Open();

                return command.ExecuteNonQuery() > 0;
            }
        }

        public static int DetainLicense(int licenseID, decimal fineFees, int createdByUserID)
        {

            string query = @"
                            INSERT INTO [dbo].[DetainedLicenses]
                            (
                                LicenseID,
                                DetainDate,
                                FineFees,
                                CreatedByUserID,
                                IsReleased,
                                ReleaseDate,
                                ReleasedByUserID,
                                ReleaseApplicationID
                            )
                            VALUES
                            (
                                @LicenseID,
                                @DetainDate,
                                @FineFees,
                                @CreatedByUserID,
                                0,
                                NULL,
                                NULL,
                                NULL
                            );

                            SELECT CAST(SCOPE_IDENTITY() AS INT);";

            using (SqlConnection connection = new SqlConnection(DataAccessLayer.Settings.clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@LicenseID", SqlDbType.Int).Value = licenseID;
                command.Parameters.Add("@DetainDate", SqlDbType.SmallDateTime).Value = DateTime.Now;
                command.Parameters.Add("@FineFees", SqlDbType.SmallMoney).Value = fineFees;
                command.Parameters.Add("@CreatedByUserID", SqlDbType.Int).Value = createdByUserID;

                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int detainID))
                {
                    return detainID;
                }
            }

            return -1;
        }

    }
}
