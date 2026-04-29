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
    public static class TestAppointmentMapper
    {
        public static TestAppointmentDTO FromReader(SqlDataReader reader)
        {
            return new TestAppointmentDTO
            {
                TestAppointmentID = (int)reader["TestAppointmentID"],
                TestTypeID = (int)reader["TestTypeID"],
                LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"],

                AppointmentDate = (DateTime)reader["AppointmentDate"],

                PaidFees = Convert.ToInt32(reader["PaidFees"]),
                CreatedByUserID = (int)reader["CreatedByUserID"],

                IsLocked = (bool)reader["IsLocked"]
            };
        }

        public static void MapToCommand(SqlCommand command, TestAppointmentDTO dto, bool includeID)
        {
            if (includeID)
            {
                command.Parameters.Add("@TestAppointmentID", SqlDbType.Int)
                       .Value = dto.TestAppointmentID;
            }

            command.Parameters.Add("@TestTypeID", SqlDbType.Int)
                   .Value = dto.TestTypeID;

            command.Parameters.Add("@LocalDrivingLicenseApplicationID", SqlDbType.Int)
                   .Value = dto.LocalDrivingLicenseApplicationID;

            command.Parameters.Add("@AppointmentDate", SqlDbType.DateTime)
                   .Value = dto.AppointmentDate;

            command.Parameters.Add("@PaidFees", SqlDbType.Int)
                   .Value = dto.PaidFees;

            command.Parameters.Add("@CreatedByUserID", SqlDbType.Int)
                   .Value = dto.CreatedByUserID;

            command.Parameters.Add("@IsLocked", SqlDbType.Bit)
                   .Value = dto.IsLocked;
        }

    }
}
