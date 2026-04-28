using DataAccessLayer.DTOs;
using DataAccessLayer.Mappers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class clsInternationalLicenseData
    {
        public static int AddInternationalLicense(InternationalLicenseDTO dto)
        {
            string query = @"
                            INSERT INTO [dbo].[InternationalLicenses]
                            (
                                ApplicationID,
                                DriverID,
                                IssuedUsingLocalLicenseID,
                                IssueDate,
                                ExpirationDate,
                                IsActive,
                                CreatedByUserID
                            )
                            VALUES
                            (
                                @ApplicationID,
                                @DriverID,
                                @IssuedUsingLocalLicenseID,
                                @IssueDate,
                                @ExpirationDate,
                                @IsActive,
                                @CreatedByUserID
                            );

                            SELECT CAST(SCOPE_IDENTITY() AS INT);";

            using (SqlConnection connection = new SqlConnection(DataAccessLayer.Settings.clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                InternationalLicenseMapper.MapToCommand(command, dto, includeID: false);

                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int newID))
                {
                    return newID;
                }
            }

            return -1;
        }
        public static InternationalLicenseDTO GetInternationalLicenseByDriverID(int driverID)
        {
            string query = @"
                            SELECT InternationalLicenseID,
                                   ApplicationID,
                                   DriverID,
                                   IssuedUsingLocalLicenseID,
                                   IssueDate,
                                   ExpirationDate,
                                   IsActive,
                                   CreatedByUserID
                            FROM InternationalLicenses
                            WHERE DriverID = @DriverID;";

            using (SqlConnection connection = new SqlConnection(DataAccessLayer.Settings.clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@DriverID", SqlDbType.Int).Value = driverID;

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return InternationalLicenseMapper.FromReader(reader);
                    }
                }
            }

            return null;
        }
        public static bool DeactivateInternationalLicense(int internationalLicenseID)
        {
            string query = @"
                            UPDATE [dbo].[InternationalLicenses]
                            SET IsActive = 0
                            WHERE InternationalLicenseID = @InternationalLicenseID;";

            using (SqlConnection connection = new SqlConnection(DataAccessLayer.Settings.clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@InternationalLicenseID", SqlDbType.Int).Value = internationalLicenseID;

                connection.Open();

                return command.ExecuteNonQuery() > 0;
            }
        }
        public static bool RenewInternationalLicense(int internationalLicenseID, DateTime newExpirationDate)
        {
            string query = @"
                            UPDATE [dbo].[InternationalLicenses]
                            SET 
                                IsActive = 1,
                                IssueDate = @IssueDate,
                                ExpirationDate = @ExpirationDate
                            WHERE InternationalLicenseID = @InternationalLicenseID;";

            using (SqlConnection connection = new SqlConnection(DataAccessLayer.Settings.clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@InternationalLicenseID", SqlDbType.Int).Value = internationalLicenseID;

                command.Parameters.Add("@IssueDate", SqlDbType.DateTime).Value = DateTime.Now;

                command.Parameters.Add("@ExpirationDate", SqlDbType.DateTime).Value = newExpirationDate;

                connection.Open();

                return command.ExecuteNonQuery() > 0;
            }
        }

    }
}
