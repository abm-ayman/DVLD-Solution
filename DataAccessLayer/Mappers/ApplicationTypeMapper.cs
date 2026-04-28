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
    public static class ApplicationTypeMapper
    {
        public static ApplicationTypeDTO FromReader(SqlDataReader reader)
        {
            return new ApplicationTypeDTO
            {
                ApplicationTypeID = (int)reader["ApplicationTypeID"],
                ApplicationTypeTitle = (string)reader["ApplicationTypeTitle"],
                ApplicationFees = Convert.ToDecimal(reader["ApplicationFees"])
            };
        }

        public static void MapToCommand(SqlCommand command, ApplicationTypeDTO type, bool includeID)
        {
            if (includeID)
            {
                command.Parameters.Add("@ApplicationTypeID", SqlDbType.Int).Value = type.ApplicationTypeID;
            }

            command.Parameters.Add("@ApplicationTypeTitle", SqlDbType.NVarChar, 150).Value =
                type.ApplicationTypeTitle;

            command.Parameters.Add("@ApplicationFees", SqlDbType.SmallMoney).Value =
                type.ApplicationFees;
        }
    }
}
