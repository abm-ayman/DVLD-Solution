using DataAccessLayer.DTOs;
using DataAccessLayer.Settings;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DataAccessLayer
{
    public static class clsUserData
    {

        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            string query = "select UserID, PersonID, UserName, Password, IsActive from Users;";

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

        public static DataAccessLayer.DTOs.UserDTO GetUserInfoByUserID(int userID)
        {

            string query = "select UserID, PersonID, UserName, Password, IsActive from Users where UserID = @UserID;";

            using (SqlConnection connection = new SqlConnection(DataAccessLayer.Settings.clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@UserID", userID);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return DataAccessLayer.Mappers.UserMapper.FromReader(reader);
                    }

                }

            }

            return null;
        }

        public static int AddNewUser(UserDTO userDTO)
        {
            string query = @"
                INSERT INTO [dbo].[Users]
                ([PersonID], [UserName], [Password], [IsActive])
                VALUES (@PersonID, @UserName, @Password, @IsActive);

                SELECT CAST(SCOPE_IDENTITY() AS INT);";

            using (SqlConnection connection = new SqlConnection(DataAccessLayer.Settings.clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                DataAccessLayer.Mappers.UserMapper.MapToCommand(command, userDTO, includeID: false);

                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    return insertedID;
                }
            }

            return -1;

        }

        public static bool UpdateUser(UserDTO userDTO)
        {
            int rowsAffected = 0;

            string query = @"
                UPDATE [dbo].[Users]
                SET 
                    [PersonID] = @PersonID,
                    [UserName] = @UserName,
                    [Password] = @Password,
                    [IsActive] = @IsActive
                WHERE [UserID] = @UserID;";

            using (SqlConnection connection = new SqlConnection(DataAccessLayer.Settings.clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                DataAccessLayer.Mappers.UserMapper.MapToCommand(command, userDTO, includeID: true);


                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

                return rowsAffected > 0;
            }



        }

        public static bool HardDeleteUser(int userID)
        {
            string query = "DELETE FROM Users WHERE UserID = @UserID AND IsDeleted = 0";

            using (SqlConnection connection = new SqlConnection(clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@UserID", SqlDbType.Int).Value = userID;

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public static bool SoftDeleteUser(int userID)
        {
            string query = @"
                UPDATE Users
                SET IsDeleted = 1
                WHERE UserID = @UserID AND IsDeleted = 0";

            using (SqlConnection connection = new SqlConnection(clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@UserID", SqlDbType.Int).Value = userID;

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }


    }
}
