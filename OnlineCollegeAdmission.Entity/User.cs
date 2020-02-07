using System;

namespace OnlineCollegeAdmission.Entity
{
    public class User
    {
        public int userId { get; set; }
        public string password { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public DateTime dob { get; set; }
        public string emailId { get; set; }
        public string phoneNumber { get; set; }
        public string role { get; set; }

        public User(string firstName,string lastName,string gender,DateTime dob,string emailId, string phoneNumber,string password, string role)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.dob = dob;
            this.emailId = emailId;
            this.phoneNumber = phoneNumber;
            this.password = password;
            this.role = role;
        }
    }
}
