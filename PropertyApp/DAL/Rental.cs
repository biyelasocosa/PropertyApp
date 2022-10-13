using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Rental
    {
        public int ID { get; set; }
        public int Property { get; set; }
        public int Tenant { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public Rental (int property, int tenant, string startDate, string endDate)
        {
            this.Property = property;
            this.Tenant = tenant;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }
        public Rental (int id, string startDate, string endDate)
        {
            this.ID = id;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }
    }
}
