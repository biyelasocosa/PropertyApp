using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Surbub
    {
        public int ID { get; set; }
        public string Description {get; set;}
        public string PostalCode { get; set; }
        public int City { get; set; }

        public Surbub(string desc, string postal, int city)
        {
            this.Description = desc;
            this.PostalCode = postal;
            this.City = city;
        }
    }
}
