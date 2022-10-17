using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Tenant
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Status { get; set;}
        public int UserType { get; set; }

        public Tenant(string name, string surname, string email, string password, string phone, string status, int user)
        {
            this.Name = name;
            this.Surname = surname;
            this.Email = email;
            this.Password = password;
            this.Phone = phone;
            this.Status = status;
            this.UserType = user;
        }
        public Tenant(int id, string email, string phone, string status)
        {
            this.ID = id;
            this.Email = email;
            this.Phone = phone;
            this.Status = status;
        }
    }
}
