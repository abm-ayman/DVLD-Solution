using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    internal class clsApplication
    {

        int ApplicationID { get; set; }
        int ApplicationPersonID { get; set; }
        DateTime ApplicaionDate { get; set; }
        int ApplicationType { get; set; }
        byte ApplicationStatus { get; set; }
        DateTime LastStatusDate { get; set; }
        decimal PaidFees { get; set; }
        int CreatedByUserID { get; set; }


    }
}
