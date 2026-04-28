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
    public static class clsDriversData
    {
        public static int AddDriver(DriverDTO dto)
        {
            string query = @"
                            INSERT INTO [dbo].[Drivers]
                            (
                                PersonID,
                                CreatedByUserID,
                                CreatedDate
                            )
                            VALUES
                            (
                                @PersonID,
                                @CreatedByUserID,
                                @CreatedDate
                            );

                            SELECT CAST(SCOPE_IDENTITY() AS INT);";

            using (SqlConnection connection = new SqlConnection(DataAccessLayer.Settings.clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                DataAccessLayer.Mappers.DriverMapper.MapToCommand(command, dto, includeID: false);

                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int driverID))
                {
                    return driverID;
                }
            }

            return -1;
        }

        public static DriverDTO GetDriverByPersonID(int personID)
        {
            string query = @"
                            SELECT DriverID,
                                   PersonID,
                                   CreatedByUserID,
                                   CreatedDate
                            FROM Drivers
                            WHERE PersonID = @PersonID;";

            using (SqlConnection connection = new SqlConnection(DataAccessLayer.Settings.clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@PersonID", SqlDbType.Int).Value = personID;

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return DataAccessLayer.Mappers.DriverMapper.FromReader(reader);
                    }
                }
            }

            return null;
        }

        public static List<DriverDTO> GetAllDrivers()
        {
            List<DriverDTO> drivers = new List<DriverDTO>();

            string query = @"
                            SELECT DriverID,
                                   PersonID,
                                   CreatedByUserID,
                                   CreatedDate
                            FROM Drivers
                            ORDER BY DriverID DESC;";

            using (SqlConnection connection = new SqlConnection(DataAccessLayer.Settings.clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        drivers.Add(
                            DataAccessLayer.Mappers.DriverMapper.FromReader(reader)
                        );
                    }
                }
            }

            return drivers;
        }

        public static bool UpdateDriver(DriverDTO dto)
        {
            string query = @"
    UPDATE [dbo].[Drivers]
    SET 
        PersonID = @PersonID,
        CreatedByUserID = @CreatedByUserID,
        CreatedDate = @CreatedDate
    WHERE DriverID = @DriverID;";

            using (SqlConnection connection = new SqlConnection(DataAccessLayer.Settings.clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                DataAccessLayer.Mappers.DriverMapper.MapToCommand(command, dto, includeID: true);

                connection.Open();

                return command.ExecuteNonQuery() > 0;
            }
        }


    }
}
