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

    internal class PersonMapper
    {
        public static PersonDTO FromReader(SqlDataReader reader)
        {
            return new PersonDTO
            {
                ID = (int)reader["PersonID"],
                NationalNo = (string)reader["NationalNo"],
                FirstName = (string)reader["FirstName"],
                SecondName = (string)reader["SecondName"],

                ThirdName = reader["ThirdName"] != DBNull.Value
                            ? (string)reader["ThirdName"]
                            : null,

                LastName = (string)reader["LastName"],
                DateOfBirth = (DateTime)reader["DateOfBirth"],
                Gender = Convert.ToInt32(reader["Gender"]),
                Address = (string)reader["Address"],
                Phone = (string)reader["Phone"],

                Email = reader["Email"] != DBNull.Value
                        ? (string)reader["Email"]
                        : null,

                NationalityCountryID = (int)reader["NationalityCountryID"],

                ImagePath = reader["ImagePath"] != DBNull.Value
                            ? (string)reader["ImagePath"]
                            : null
            };
        }

        public static void MapToCommand(SqlCommand command, PersonDTO personDTO, bool includeID)
        {
            // ID only for UPDATE
            if (includeID)
            {
                command.Parameters.Add("@PersonID", SqlDbType.Int).Value = personDTO.ID;
            }

            command.Parameters.Add("@NationalNo", SqlDbType.NVarChar, 20).Value = personDTO.NationalNo;

            command.Parameters.Add("@FirstName", SqlDbType.NVarChar, 20).Value = personDTO.FirstName;

            command.Parameters.Add("@SecondName", SqlDbType.NVarChar, 20).Value = personDTO.SecondName;

            command.Parameters.Add("@ThirdName", SqlDbType.NVarChar, 20).Value =
                SqlParameterHelper.ToDbValue(personDTO.ThirdName);

            command.Parameters.Add("@LastName", SqlDbType.NVarChar, 20).Value = personDTO.LastName;

            command.Parameters.Add("@DateOfBirth", SqlDbType.DateTime).Value = personDTO.DateOfBirth;

            command.Parameters.Add("@Gender", SqlDbType.TinyInt).Value = personDTO.Gender;

            command.Parameters.Add("@Address", SqlDbType.NVarChar, 500).Value = personDTO.Address;

            command.Parameters.Add("@Phone", SqlDbType.NVarChar, 20).Value = personDTO.Phone;

            command.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value =
                SqlParameterHelper.ToDbValue(personDTO.Email);

            command.Parameters.Add("@NationalityCountryID", SqlDbType.Int).Value = personDTO.NationalityCountryID;

            command.Parameters.Add("@ImagePath", SqlDbType.NVarChar, 250).Value =
                SqlParameterHelper.ToDbValue(personDTO.ImagePath);
        }
    }


}
