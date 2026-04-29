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
    public static class clsTestAppointmentData
    {
        public static int ScheduleTestAppointment(TestAppointmentDTO dto)
        {
            string query = @"
                            INSERT INTO [dbo].[TestAppointments]
                            (
                                TestTypeID,
                                LocalDrivingLicenseApplicationID,
                                AppointmentDate,
                                PaidFees,
                                CreatedByUserID,
                                IsLocked
                            )
                            VALUES
                            (
                                @TestTypeID,
                                @LocalDrivingLicenseApplicationID,
                                @AppointmentDate,
                                @PaidFees,
                                @CreatedByUserID,
                                @IsLocked
                            );

                            SELECT CAST(SCOPE_IDENTITY() AS INT);";

            using (SqlConnection connection = new SqlConnection(DataAccessLayer.Settings.clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                DataAccessLayer.Mappers.TestAppointmentMapper
                    .MapToCommand(command, dto, includeID: false);

                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int newID))
                {
                    return newID;
                }
            }

            return -1;
        }

        public static bool LockAppointment(int testAppointmentID)
        {
            string query = @"
    UPDATE [dbo].[TestAppointments]
    SET IsLocked = 1
    WHERE TestAppointmentID = @TestAppointmentID
      AND IsLocked = 0;";

            using (SqlConnection connection = new SqlConnection(DataAccessLayer.Settings.clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@TestAppointmentID", SqlDbType.Int)
                       .Value = testAppointmentID;

                connection.Open();

                return command.ExecuteNonQuery() > 0;
            }
        }

    }
}
