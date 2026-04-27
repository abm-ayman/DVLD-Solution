using DataAccessLayer.DTOs;
using DataAccessLayer.Settings;
using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;




namespace DataAccessLayer
{
    public static class clsPersonData
    {
        public static DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT PersonID, NationalNo, FirstName, SecondName, LastName, 
                            DateOfBirth, Gender, Address, Phone, Email, 
                            NationalityCountryID, ImagePath
                     FROM People
                     WHERE IsDeleted = 0";

            using (SqlConnection connection = new SqlConnection(DataAccessLayer.Settings.clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }

            return dt; // List<PersonDTO>
        }

        public static List<PersonDTO> GetAllPeopleList()
        {
            List<PersonDTO> people = new List<PersonDTO>();

            string query = @"
        SELECT PersonID, NationalNo, FirstName, SecondName, ThirdName,
               LastName, DateOfBirth, Gender, Address, Phone,
               Email, NationalityCountryID, ImagePath
        FROM People
        WHERE IsDeleted = 0";

            using (SqlConnection connection = new SqlConnection(clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        PersonDTO person = new PersonDTO
                        {
                            ID = (int)reader["PersonID"],
                            NationalNo = (string)reader["NationalNo"],
                            FirstName = (string)reader["FirstName"],
                            SecondName = (string)reader["SecondName"],
                            ThirdName = reader["ThirdName"] != DBNull.Value ? (string)reader["ThirdName"] : null,
                            LastName = (string)reader["LastName"],
                            DateOfBirth = (DateTime)reader["DateOfBirth"],
                            Gender = Convert.ToInt32(reader["Gender"]),
                            Address = (string)reader["Address"],
                            Phone = (string)reader["Phone"],
                            Email = reader["Email"] != DBNull.Value ? (string)reader["Email"] : null,
                            NationalityCountryID = (int)reader["NationalityCountryID"],
                            ImagePath = reader["ImagePath"] != DBNull.Value ? (string)reader["ImagePath"] : null
                        };

                        people.Add(person);
                    }
                }
            }

            return people;
        }

        public static DataAccessLayer.DTOs.PersonDTO GetPersonInfoByPersonID(int ID)
        {
            string query = @"SELECT PersonID, NationalNo, FirstName, SecondName, ThirdName,
                        LastName, DateOfBirth, Gender, Address, Phone,
                        Email, NationalityCountryID, ImagePath
                 FROM People
                 WHERE PersonID = @PersonID AND IsDeleted = 0";

            using (SqlConnection connection = new SqlConnection(DataAccessLayer.Settings.clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@PersonID", ID);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return DataAccessLayer.Mappers.PersonMapper.FromReader(reader);
                    }
                }
            }

            return null;
        }

        public static DataAccessLayer.DTOs.PersonDTO GetPersonInfoByPersonNationalNo(string nationalNo)
        {
            string query = @"SELECT PersonID, NationalNo, FirstName, SecondName, ThirdName,
                        LastName, DateOfBirth, Gender, Address, Phone,
                        Email, NationalityCountryID, ImagePath
                 FROM People
                 WHERE NationalNo = @nationalNo
                   AND IsDeleted = 0";

            using (SqlConnection connection = new SqlConnection(DataAccessLayer.Settings.clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@nationalNo", nationalNo);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return DataAccessLayer.Mappers.PersonMapper.FromReader(reader);
                    }
                }
            }

            return null;
        }

        public static int AddNewPerson(DataAccessLayer.DTOs.PersonDTO personDTO)
        {
            string query = @"
                INSERT INTO [dbo].[People]
                (
                    [NationalNo],
                    [FirstName],
                    [SecondName],
                    [ThirdName],
                    [LastName],
                    [DateOfBirth],
                    [Gender],
                    [Address],
                    [Phone],
                    [Email],
                    [NationalityCountryID],
                    [ImagePath]
                )
                VALUES
                (
                    @NationalNo,
                    @FirstName,
                    @SecondName,
                    @ThirdName,
                    @LastName,
                    @DateOfBirth,
                    @Gender,
                    @Address,
                    @Phone,
                    @Email,
                    @NationalityCountryID,
                    @ImagePath
                );
                
                SELECT CAST(SCOPE_IDENTITY() AS INT);
                ";

            using (SqlConnection connection = new SqlConnection(DataAccessLayer.Settings.clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                DataAccessLayer.Mappers.PersonMapper.MapToCommand(command, personDTO,includeID: false);

                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    return insertedID;
                }
            }

            return -1;
        }

        public static bool UpdatePerson(DataAccessLayer.DTOs.PersonDTO personDTO)
        {
            int rowsAffected = 0;

            string query = @"UPDATE People
                     SET NationalNo = @nationalNo,
                         FirstName = @firstName,
                         SecondName = @secondName,
                         ThirdName = @thirdName,
                         LastName = @lastName,
                         DateOfBirth = @dateOfBirth,
                         Gender = @gender,
                         Address = @address,
                         Phone = @phone,
                         Email = @email,
                         NationalityCountryID = @nationalityCountryID,
                         ImagePath = @imagePath
                     WHERE PersonID = @PersonID; where IsDeleted = 0";

            using (SqlConnection connection = new SqlConnection(DataAccessLayer.Settings.clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                DataAccessLayer.Mappers.PersonMapper.MapToCommand(command, personDTO, includeID: true);

                try
                {
                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    // log error OR handle specific DB issue
                    throw;
                    
                }

                return rowsAffected > 0;
            }

        }

        public static bool HardDeletePerson(int ID)
        {
            string query = "DELETE FROM People WHERE PersonID = @PersonID AND IsDeleted = 0";

            using (SqlConnection connection = new SqlConnection(DataAccessLayer.Settings.clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@PersonID", SqlDbType.Int).Value = ID;

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public static bool SoftDeletePerson(int ID)
        {
            string query = @"UPDATE People 
                     SET IsDeleted = 1
                     WHERE PersonID = @PersonID";

            using (SqlConnection connection = new SqlConnection(clsConnectionStrings.DVLDConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@PersonID", SqlDbType.Int).Value = ID;

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }


    }

}
