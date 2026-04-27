using DataAccessLayer.DTOs;
using DataAccessLayer.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mappers
{
    internal class UserMapper
    {

        public static UserDTO FromReader(SqlDataReader reader)
        {
            return new UserDTO
            {
                UserID = (int)reader["UserID"],
                PersonID = (int)reader["PersonID"],
                UserName = (string)reader["UserName"],
                Password = (string)reader["Password"],
                IsActive = (bool)reader["IsActive"]
            };

        }

        public static void MapToCommand(SqlCommand command, UserDTO UserDTO, bool includeID)
        {
            // ID only for UPDATE
            if (includeID)
            {
                command.Parameters.Add("@UserID", SqlDbType.Int).Value = UserDTO.UserID;
            }

            command.Parameters.Add("@PersonID", SqlDbType.Int).Value = UserDTO.PersonID;
            command.Parameters.Add("@UserName", SqlDbType.NVarChar, 20).Value = UserDTO.UserName;
            command.Parameters.Add("@Password", SqlDbType.NVarChar, 20).Value = UserDTO.Password;
            command.Parameters.Add("@IsActive", SqlDbType.Bit).Value = UserDTO.IsActive;

        }


    }
}
