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
    public static class LicenseClassMapper
    {
        public static LicenseClassDTO FromReader(SqlDataReader reader)
        {
            return new LicenseClassDTO
            {
                LicenseClassID = (int)reader["LicenseClassID"],
                ClassName = (string)reader["ClassName"],
                ClassDescription = (string)reader["ClassDescription"],
                MinimumAllowedAge = Convert.ToInt32(reader["MinimumAllowedAge"]),
                DefaultValidityLength = Convert.ToInt32(reader["DefaultValidityLength"]),
                ClassFees = Convert.ToInt32(reader["ClassFees"])
            };
        }

        public static void MapToCommand(SqlCommand command, LicenseClassDTO dto, bool includeID)
        {
            if (includeID)
            {
                command.Parameters.Add("@LicenseClassID", SqlDbType.Int).Value = dto.LicenseClassID;
            }

            command.Parameters.Add("@ClassName", SqlDbType.NVarChar, 50).Value = dto.ClassName;

            command.Parameters.Add("@ClassDescription", SqlDbType.NVarChar, 500).Value = dto.ClassDescription;

            command.Parameters.Add("@MinimumAllowedAge", SqlDbType.TinyInt).Value = dto.MinimumAllowedAge;

            command.Parameters.Add("@DefaultValidityLength", SqlDbType.TinyInt).Value = dto.DefaultValidityLength;

            command.Parameters.Add("@ClassFees", SqlDbType.SmallMoney).Value = dto.ClassFees;
        }
    }
}
