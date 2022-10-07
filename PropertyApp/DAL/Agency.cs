using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Agency
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Surbub { get; set; }
        public Agency(string name, int surbub)
        {
            this.Name = name;
            this.Surbub = surbub;
        }
    }
}
