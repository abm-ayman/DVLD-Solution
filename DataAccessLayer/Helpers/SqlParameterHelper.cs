using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Helpers
{
    public static class SqlParameterHelper
    {
        public static object ToDbValue(string value)
        {
            return string.IsNullOrEmpty(value) ? DBNull.Value : (object)value;
        }

        public static object ToDbValue(int? value)
        {
            return value.HasValue ? (object)value.Value : DBNull.Value;
        }

        public static object ToDbValue(DateTime? value)
        {
            return value.HasValue ? (object)value.Value : DBNull.Value;
        }

        public static object ToDbValue(object value)
        {
            return value ?? DBNull.Value;
        }

    }
}
