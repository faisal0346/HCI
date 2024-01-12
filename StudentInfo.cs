using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_project_v1
{
    public class StudentInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public string Role { get; set; }
        public string Course { get; set; }
        public string Instructors { get; set; }
        public DateTime Date { get; set; }
        public string Session { get; set; }

        public StudentInfo(string firstName, string lastName, string gender, string phone, string email,
                           string address, string postCode, string role, string course, DateTime date, string session)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Phone = phone;
            Email = email;
            Address = address;
            PostCode = postCode;
            Role = role;
            Course = course;
            Date = date;
            Session = session;
        }
    }
}
