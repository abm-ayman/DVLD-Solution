using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataAccessLayer.DTOs;



namespace BusinessLayer
{
    public class clsUser
    {
        enum enMode { AddNew, Update }
        enMode _Mode;

        public int UserID { get; }
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public clsUser(int userID, int personID, string userName, string password, bool isActive)
        {

            UserID = userID;
            PersonID = personID;
            UserName = userName;
            Password = password;
            IsActive = isActive;
        }

        public static clsUser FindUser(string username)
        { 
            UserDTO userDTO = DataAccessLayer.clsUserData.GetUserInfoByUsername(username);

            if (userDTO != null)
            {
                return BLLMappers.BLLUserMapper.ConvertToBLLUser(userDTO);
            }

            return null;
        }

        public static clsUser FindUser(string username, string password)
        {
            UserDTO userDTO = DataAccessLayer.clsUserData.GetUserInfoByUsername(username, password);

            if (userDTO != null)
            {
                return BLLMappers.BLLUserMapper.ConvertToBLLUser(userDTO);
            }

            return null;
        }

        public static DataTable GetPeople()
        {
            return DataAccessLayer.clsPersonData.GetAllPeople();
        }

    }
}
