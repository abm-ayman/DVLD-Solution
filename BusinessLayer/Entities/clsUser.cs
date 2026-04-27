using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;



namespace BusinessLayer
{
    public class clsUser
    {
        int UserID {  get; set; }
        int PersonID { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        bool IsActive { get; set; }

        public clsUser(int userID, int personID, string userName, string password, bool isActive)
        {
            UserID = userID;
            PersonID = personID;
            UserName = userName;
            Password = password;
            IsActive = isActive;
        }
    }
}
