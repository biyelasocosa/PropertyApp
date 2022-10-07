using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Property
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public byte Image { get; set; }
        public int PropertyType { get; set; }
        public string Status { get; set; }
        public int Surbub { get; set; }
        public Property(string desc, double price, byte img, int propertytype, string status, int surbub)
        {
            this.Description = desc;
            this.Price = price;
            this.Image = img;
            this.PropertyType = propertytype;
            this.Status = status;
            this.Surbub = surbub;
        }
    }
}
