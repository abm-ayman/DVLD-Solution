using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using DataAccessLayer;



namespace BusinessLayer
{
    internal class clsPerson
    {
        
        enum enMode { AddNew, Update};
        enMode _Mode;

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
        public int NationalityCountrID { get; set; }
        public string ImagePath { get; set; }


        public clsPerson()
        {

        }

        public clsPerson(ref int ID, string nationalNo, string firstName, string secondName, string thirdName, string lastName, DateTime dateOfBirth, int gender, string address, string phone, string email, int nationalityCountrID, string imagePath)
        {
            
            this.ID = ID;
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
            NationalityCountrID = nationalityCountrID;
            ImagePath = imagePath;
        }


        





















    }
}
