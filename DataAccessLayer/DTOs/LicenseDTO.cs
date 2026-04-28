using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DTOs
{
    public class LicenseDTO
    {
        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int LicenseClassID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; } // nullable >> nvarchar(500)
        public int PaidFees { get; set; }
        public bool IsActive { get; set; }
        public int IssueReasonID { get; set; }
        public int CreatedByUserID { get; set; }

    }
}
