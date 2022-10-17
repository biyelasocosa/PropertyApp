using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PropertyAgent
    {
        public int ID { get; set; }
        public int Property { get; set; }
        public int Agent { get; set; }
        public string Date { get; set; }
        public PropertyAgent(int property, int agent, string date)
        {
            this.Property = property;
            this.Agent = agent;
            this.Date = date;
        }
        public PropertyAgent()
        {

        }
    }
}
