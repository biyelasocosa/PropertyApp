using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Province
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public Province(string desc)
        {
            this.Description = desc;
        }
    }
}
