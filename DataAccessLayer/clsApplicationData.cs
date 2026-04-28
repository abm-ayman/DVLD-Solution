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
    internal class clsApplicationData
    {

        public static DataTable GetAllApplications()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT ApplicationID,
                                    ApplicantPersonID,
                                    ApplicationDate,
                                    ApplicationTypeID,
                                    ApplicationStatus,
                                    LastStatusDate,
                                    PaidFees,
                                    CreatedByUserID
                             FROM Applications WHERE IsDeleted = 0 ;";

            using (SqlConnection connection = new SqlConnection(DataAccessLayer.Settings.clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dt.Load(reader);
                }

            }

            return dt;
        }

        public static ApplicationDTO GetApplicationInfoByApplicationID(int applicationID)
        {
            string query = @"SELECT ApplicationID,
                            ApplicantPersonID,
                            ApplicationDate,
                            ApplicationTypeID,
                            ApplicationStatus,
                            LastStatusDate,
                            PaidFees,
                            CreatedByUserID
                     FROM Applications
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
                        return DataAccessLayer.Mappers.ApplicationMapper.FromReader(reader);
                    }
                }
            }

            return null;
        }

        public static int AddNewApplication(ApplicationDTO applicationDTO)
        {
            string query = @"
                            INSERT INTO [dbo].[Applications]
                            (
                                [ApplicantPersonID],
                                [ApplicationDate],
                                [ApplicationTypeID],
                                [ApplicationStatus],
                                [LastStatusDate],
                                [PaidFees],
                                [CreatedByUserID]
                            )
                            VALUES
                            (
                                @ApplicantPersonID,
                                @ApplicationDate,
                                @ApplicationTypeID,
                                @ApplicationStatus,
                                @LastStatusDate,
                                @PaidFees,
                                @CreatedByUserID
                            );

                            SELECT CAST(SCOPE_IDENTITY() AS INT);";

            using (SqlConnection connection = new SqlConnection(DataAccessLayer.Settings.clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                DataAccessLayer.Mappers.ApplicationMapper.MapToCommand(command, applicationDTO, includeID: false);

                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    return insertedID;
                }
            }

            return -1;
        }

        public static bool UpdateApplication(ApplicationDTO applicationDTO)
        {
            string query = @"
                            UPDATE [dbo].[Applications]
                            SET 
                                [ApplicantPersonID] = @ApplicantPersonID,
                                [ApplicationDate] = @ApplicationDate,
                                [ApplicationTypeID] = @ApplicationTypeID,
                                [ApplicationStatus] = @ApplicationStatus,
                                [LastStatusDate] = @LastStatusDate,
                                [PaidFees] = @PaidFees,
                                [CreatedByUserID] = @CreatedByUserID
                            WHERE ApplicationID = @ApplicationID;";

            using (SqlConnection connection = new SqlConnection(DataAccessLayer.Settings.clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // include ID for UPDATE
                DataAccessLayer.Mappers.ApplicationMapper.MapToCommand(command, applicationDTO, includeID: true);

                connection.Open();

                return command.ExecuteNonQuery() > 0;
            }
        }

        public static bool SoftDeleteApplication(int applicationID)
        {
            string query = @"
                            UPDATE [dbo].[Applications]
                            SET IsDeleted = 1
                            WHERE ApplicationID = @ApplicationID;";

            using (SqlConnection connection = new SqlConnection(DataAccessLayer.Settings.clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@ApplicationID", SqlDbType.Int).Value = applicationID;

                connection.Open();

                return command.ExecuteNonQuery() > 0;
            }
        }

        public static bool HardDeleteApplication(int applicationID)
        {
            string query = @"
                            DELETE FROM [dbo].[Applications]
                            WHERE ApplicationID = @ApplicationID;";

            using (SqlConnection connection = new SqlConnection(DataAccessLayer.Settings.clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@ApplicationID", SqlDbType.Int).Value = applicationID;

                connection.Open();

                return command.ExecuteNonQuery() > 0;
            }
        }


    }





}
