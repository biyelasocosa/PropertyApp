using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Agent
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public  string Phone { get; set; }
        public string Status { get; set; }
        public int Agency { get; set; }
        public Agent (string name, string surname, string email, string password, string phone, string status, int agency)
        {
            this.Name = name;
            this.Surname = surname;
            this.Email = email;
            this.Password = password;
            this.Phone = phone;
            this.Status = status;
            this.Agency = agency;
        }
        public Agent(int agentID, string email, string phone, string status)
        {
            this.ID = agentID;
            this.Email = email;
            this.Phone = phone;
            this.Status = status;
        }
        public Agent (int agentID)
        {
            this.ID = agentID;
        }
    }
}
