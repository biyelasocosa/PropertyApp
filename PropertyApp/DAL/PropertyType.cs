using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PropertyType
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public PropertyType(string desc)
        {
            this.Description = desc;
        }
    }
}
