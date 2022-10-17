using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;


namespace BLL
{
    public class BusinessLogicLayer
    {
        DataAccessLayer dal = new DataAccessLayer();
        public int InsertPropertyType(PropertyType type)
        {
            return dal.InsertPropertyType(type);
        }
        public DataTable GetPropertyType()
        {
            return dal.GetPropertyType();
        }

        public int InsertProvince(Province prov)
        {
            return dal.InsertProvince(prov);
        }
        public DataTable GetProvince()
        {
            return dal.GetProvince();
        }

        public int InsertCity(City city)
        {
            return dal.InsertCity(city);
        }
        public DataTable GetCity()
        {
            return dal.GetCity();
        }

        public int InsertSurbub(Surbub surb)
        {
            return dal.InsertSurbub(surb);
        }
        public DataTable GetSurbub()
        {
            return dal.GetSurbub();
        }

        //Property
        public int InsertPropety(Property propty)
        {
            return dal.InsertPropery(propty);
        }
        public DataTable GetProperty()
        {
            return dal.GetProperty();
        }
        public int UpdateProperty(Property propty)
        {
            return dal.UpdateProperty(propty);
        }
        //Agency
        public int InsertAgency(Agency agency)
        {
            return dal.InsertAgency(agency);
        }
        public DataTable GetAgency()
        {
            return dal.GetAgency();
        }
        //Agent
        public int InsertAgent(Agent agent)
        {
            return dal.InsertAgent(agent);
        }
        public int UpdateAgent(Agent agent)
        {
            return dal.UpdateAgent(agent);
        }
        public DataTable GetAgent()
        {
            return dal.GetAgent();
        }
        public int DeleteAgent(int agentID)
        {
            return dal.DeleteAgent(agentID);
        }
        //Rental
        public int InsertRental(Rental rent)
        {
            return dal.InsertRental(rent);
        }
        public int UpdateRental(Rental rent)
        {
            return dal.UpdateRental(rent);
        }
        public DataTable GetRental()
        {
            return dal.GetRental();
        }
        //Tenant
        public int InsertTenant(Tenant ten)
        {
            return dal.InsertTenant(ten);
        }
        public int UpdateTenant(Tenant ten)
        {
            return dal.UpdateTenant(ten);
        }
        public DataTable GetTenant()
        {
            return dal.GetTenant();
        }
        public int DeleteTenant(int tenantId)
        {
            return dal.DeleteTenant(tenantId);
        }
        //PropertyAgent
        public int InsertPropertyAgent(PropertyAgent pa)
        {
            return dal.InsertPropertyAgent(pa);
        }
        public DataTable GetPropertyAgent()
        {
            return dal.GetPropertyAgent();
        }
        //Login
        public DataTable Login(string email, string password)
        {
            return dal.Login(email, password);
        }
    }
}
