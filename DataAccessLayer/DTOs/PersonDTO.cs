using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DTOs
{
    public class PersonDTO
    {

        public int ID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public string ImagePath { get; set; }





        public PersonDTO(int iD, string nationalNo, string firstName, string secondName, string thirdName, string lastName, DateTime dateOfBirth, int gender, string address, string phone, string email, int nationalityCountryID, string imagePath)
        {
            ID = iD;
            NationalNo = nationalNo;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Address = address;
            Phone = phone;
            Email = email;
            NationalityCountryID = nationalityCountryID;
            ImagePath = imagePath;
        }

        public PersonDTO()
        {
        }
    }
}
