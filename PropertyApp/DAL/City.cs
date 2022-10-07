using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class City
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public int ProvinceID { get; set; }
        public City(string desc, int provId)
        {
            this.Description = desc;
            this.ProvinceID = provId;
        }
    }
}
