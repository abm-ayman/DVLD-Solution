using DataAccessLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mappers
{
    public static class CountryMapper
    {
        public static CountryDTO FromReader(SqlDataReader reader)
        {
            return new CountryDTO
            {
                CountryID = (int)reader["CountryID"],
                CountryName = (string)reader["CountryName"]
            };
        }
    }


}
