using DataAccessLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class clsLicenseData
    {
        public static int IssueLicense(LicenseDTO dto)
        {
            string query = @"
                            INSERT INTO [dbo].[Licenses]
                            (
                                ApplicationID,
                                LicenseClassID,
                                IssueDate,
                                ExpirationDate,
                                Notes,
                                PaidFees,
                                IsActive,
                                IssueReasonID,
                                CreatedByUserID
                            )
                            VALUES
                            (
                                @ApplicationID,
                                @LicenseClassID,
                                @IssueDate,
                                @ExpirationDate,
                                @Notes,
                                @PaidFees,
                                @IsActive,
                                @IssueReasonID,
                                @CreatedByUserID
                            );

                            SELECT CAST(SCOPE_IDENTITY() AS INT);";

            using (SqlConnection connection = new SqlConnection(DataAccessLayer.Settings.clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                DataAccessLayer.Mappers.LicenseMapper.MapToCommand(command, dto, includeID: false);

                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int licenseID))
                {
                    return licenseID;
                }
            }

            return -1;
        }

    }
}
