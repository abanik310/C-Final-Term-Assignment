using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Entity
{
    class User
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        

        public User(string id,string name, string username, string password, string email, string dateOfBirth, string gender)
        {
            this.Name = name;
            this.Username = username;
            this.Password = password;
            this.Email = email;
            this.DateOfBirth = dateOfBirth;
            this.Gender = gender;
            
            
        }

    }
}
