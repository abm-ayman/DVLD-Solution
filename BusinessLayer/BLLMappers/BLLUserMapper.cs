using DataAccessLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.BLLMappers
{
    public class BLLUserMapper
    {
        public static clsUser ConvertToBLLUser(UserDTO userDTO)
        {
            return new clsUser(userDTO.UserID, userDTO.PersonID, userDTO.UserName, userDTO.Password, userDTO.IsActive);
        }
    }
}
