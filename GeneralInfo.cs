using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_work
{
    public class GeneralInfo
    {
        public string PhotoPath { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string PhoneNumber { get; set; }
        public string PassportNumber { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public string HomeAddress { get; set; }
        public DateTime PassportIssueDate { get; set; }
        public string PassportIssuedBy { get; set; }


        public GeneralInfo(string photoPath, string surname, string name, string patronymic, string phoneNumber, string passportNumber,
                          DateTime dateOfBirth, string placeOfBirth, string homeAddress,
                          DateTime passportIssueDate, string passportIssuedBy, string gender)
        {
            PhotoPath = photoPath;
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            PhoneNumber = phoneNumber;
            PassportNumber = passportNumber;
            DateOfBirth = dateOfBirth;
            PlaceOfBirth = placeOfBirth;
            HomeAddress = homeAddress;
            PassportIssueDate = passportIssueDate;
            PassportIssuedBy = passportIssuedBy;
            Gender = gender;
        }
    }
}