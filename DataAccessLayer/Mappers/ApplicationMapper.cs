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
    internal class ApplicationMapper
    {
        public static void MapToCommand(SqlCommand command, ApplicationDTO app, bool includeID)
            {
                // Used for UPDATE
                if (includeID)
                {
                    command.Parameters.Add("@ApplicationID", SqlDbType.Int).Value = app.ApplicationID;
                }

                command.Parameters.Add("@ApplicantPersonID", SqlDbType.Int).Value = app.ApplicationPersonID;

                command.Parameters.Add("@ApplicationDate", SqlDbType.DateTime).Value = app.ApplicationDate;

                command.Parameters.Add("@ApplicationTypeID", SqlDbType.Int).Value = app.ApplicationTypeID;

                command.Parameters.Add("@ApplicationStatus", SqlDbType.TinyInt).Value = app.ApplicationStatus;

                command.Parameters.Add("@LastStatusDate", SqlDbType.DateTime).Value = app.LastStatusDate;

                command.Parameters.Add("@PaidFees", SqlDbType.SmallMoney).Value = app.PaidFees;

                command.Parameters.Add("@CreatedByUserID", SqlDbType.Int).Value = app.CreatedByUserID;
            }
        
        public static ApplicationDTO FromReader(SqlDataReader reader)
            {
                return new ApplicationDTO
                {
                    ApplicationID = (int)reader["ApplicationID"],
                    ApplicationPersonID = (int)reader["ApplicantPersonID"],
                    ApplicationDate = (DateTime)reader["ApplicationDate"],
                    ApplicationTypeID = (int)reader["ApplicationTypeID"],
                    ApplicationStatus = Convert.ToByte(reader["ApplicationStatus"]),
                    LastStatusDate = (DateTime)reader["LastStatusDate"],
                    PaidFees = Convert.ToDecimal(reader["PaidFees"]),
                    CreatedByUserID = (int)reader["CreatedByUserID"]
                };
            }
        
    }
}
