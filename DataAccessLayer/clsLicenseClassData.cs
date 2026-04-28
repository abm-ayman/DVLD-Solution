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
    public static class clsLicenseClassData
    {

        public static LicenseClassDTO GetLicenseClassByID(int licenseClassID)
        {
            string query = @"
                            SELECT LicenseClassID,
                                   ClassName,
                                   ClassDescription,
                                   MinimumAllowedAge,
                                   DefaultValidityLength,
                                   ClassFees
                            FROM LicenseClasses
                            WHERE LicenseClassID = @LicenseClassID;";

            using (SqlConnection connection = new SqlConnection(DataAccessLayer.Settings.clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@LicenseClassID", SqlDbType.Int).Value = licenseClassID;

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return DataAccessLayer.Mappers.LicenseClassMapper.FromReader(reader);
                    }
                }
            }

            return null;
        }

        public static List<LicenseClassDTO> GetAllLicenseClasses()
        {
            List<LicenseClassDTO> classes = new List<LicenseClassDTO>();

            string query = @"
                            SELECT LicenseClassID,
                                   ClassName,
                                   ClassDescription,
                                   MinimumAllowedAge,
                                   DefaultValidityLength,
                                   ClassFees
                            FROM LicenseClasses
                            ORDER BY LicenseClassID;";

            using (SqlConnection connection = new SqlConnection(DataAccessLayer.Settings.clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        classes.Add(
                            DataAccessLayer.Mappers.LicenseClassMapper.FromReader(reader)
                        );
                    }
                }
            }

            return classes;
        }
    }
}
