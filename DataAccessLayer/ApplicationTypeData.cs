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
    internal class ApplicationTypeData
    {

        public static ApplicationTypeDTO GetApplicationTypeByID(int applicationTypeID)
        {
            string query = @"SELECT ApplicationTypeID,
                            ApplicationTypeTitle,
                            ApplicationFees
                     FROM ApplicationTypes
                     WHERE ApplicationTypeID = @ApplicationTypeID;";

            using (SqlConnection connection = new SqlConnection(DataAccessLayer.Settings.clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@ApplicationTypeID", SqlDbType.Int).Value = applicationTypeID;

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return ApplicationTypeMapper.FromReader(reader);
                    }
                }
            }

            return null;
        }

        public static DataTable GetAllApplicationTypes()
        {
            DataTable dt = new DataTable();

            string query = @"SELECT ApplicationTypeID,
                            ApplicationTypeTitle,
                            ApplicationFees
                     FROM ApplicationTypes;";

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

        public static int AddNewApplicationType(ApplicationTypeDTO typeDTO)
        {
            string query = @"
                            INSERT INTO ApplicationTypes
                            (
                                ApplicationTypeTitle,
                                ApplicationFees
                            )
                            VALUES
                            (
                                @ApplicationTypeTitle,
                                @ApplicationFees
                            );

                            SELECT CAST(SCOPE_IDENTITY() AS INT);";

            using (SqlConnection connection = new SqlConnection(DataAccessLayer.Settings.clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                ApplicationTypeMapper.MapToCommand(command, typeDTO, includeID: false);

                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int newID))
                {
                    return newID;
                }
            }

            return -1;
        }

        public static bool UpdateApplicationType(ApplicationTypeDTO typeDTO)
        {
            string query = @"
                            UPDATE ApplicationTypes
                            SET ApplicationTypeTitle = @ApplicationTypeTitle,
                                ApplicationFees = @ApplicationFees
                            WHERE ApplicationTypeID = @ApplicationTypeID;";

            using (SqlConnection connection = new SqlConnection(DataAccessLayer.Settings.clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                ApplicationTypeMapper.MapToCommand(command, typeDTO, includeID: true);

                connection.Open();

                return command.ExecuteNonQuery() > 0;
            }
        }

        public static bool DeleteApplicationType(int applicationTypeID)
        {
            string query = @"DELETE FROM ApplicationTypes
                     WHERE ApplicationTypeID = @ApplicationTypeID;";

            using (SqlConnection connection = new SqlConnection(DataAccessLayer.Settings.clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@ApplicationTypeID", SqlDbType.Int).Value = applicationTypeID;

                connection.Open();

                return command.ExecuteNonQuery() > 0;
            }
        }


    }
}
