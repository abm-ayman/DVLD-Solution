using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DTOs
{
    public class TestTypeDTO
    {
        public int TestTypeID { get; set; }
        public string TestTypeTitle { get; set; } // nvarchar(100)
        public string TestTypeDescription { get; set; } // nvarchar(500)
        public int TestTypeFees { get; set; }

    }
}
