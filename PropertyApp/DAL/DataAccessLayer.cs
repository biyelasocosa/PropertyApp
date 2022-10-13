using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DataAccessLayer
    {
        static string connString = "Data Source = DESKTOP-OP41M4M\\MSSQLSERVER1; Initial Catalog = PropertyDB; Integrated Security = true;";
        SqlConnection dbCon = new SqlConnection(connString);
        SqlCommand dbCmd;
        SqlDataAdapter dbAdapter;
        DataTable dt;

        //Manage PropertyType
        public int InsertPropertyType(PropertyType type)
        {
            dbCon.Open();
            dbCmd = new SqlCommand("sp_InsertPropertyType", dbCon);
            dbCmd.CommandType = CommandType.StoredProcedure;

            dbCmd.Parameters.AddWithValue("@PropertyTypeDesc", type.Description);
            int x = dbCmd.ExecuteNonQuery();

            dbCon.Close();
            return x;
        }
        public DataTable GetPropertyType()
        {
            dbCon.Open();
            dbCmd = new SqlCommand("sp_GetPropertyType", dbCon);

            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbCon.Close();
            return dt;
        }
        // Province
        public int InsertProvince(Province prov)
        {
            dbCon.Open();
            dbCmd = new SqlCommand("sp_InsertProvince", dbCon);
            dbCmd.CommandType = CommandType.StoredProcedure;

            dbCmd.Parameters.AddWithValue("@Description", prov.Description);
            int x = dbCmd.ExecuteNonQuery();

            dbCon.Close();
            return x;
        }
        public DataTable GetProvince()
        {
            dbCon.Open();
            dbCmd = new SqlCommand("sp_GetProvince", dbCon);

            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbCon.Close();
            return dt;
        }
        //City
        public int InsertCity(City city)
        {
            dbCon.Open();
            dbCmd = new SqlCommand("sp_InsertCity", dbCon);
            dbCmd.CommandType = CommandType.StoredProcedure;

            dbCmd.Parameters.AddWithValue("@Description", city.Description);
            dbCmd.Parameters.AddWithValue("@Province", city.ProvinceID);
            int x = dbCmd.ExecuteNonQuery();

            dbCon.Close();
            return x;
        }
        public DataTable GetCity()
        {
            dbCon.Open();
            dbCmd = new SqlCommand("sp_GetCity", dbCon);

            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbCon.Close();
            return dt;
        }

        //Surbub
        public int InsertSurbub(Surbub surb)
        {
            dbCon.Open();
            dbCmd = new SqlCommand("sp_InsertSurbub", dbCon);
            dbCmd.CommandType = CommandType.StoredProcedure;

            dbCmd.Parameters.AddWithValue("@Description", surb.Description);
            dbCmd.Parameters.AddWithValue("@PostalCode", surb.PostalCode);
            dbCmd.Parameters.AddWithValue("@City", surb.City);

            int x = dbCmd.ExecuteNonQuery();
            dbCon.Close();
            return x;
        }
        public DataTable GetSurbub()
        {
            dbCon.Open();
            dbCmd = new SqlCommand("sp_GetSurbub", dbCon);

            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbCon.Close();
            return dt;

        }

        // Property
        public int InsertPropery(Property propty)
        {
            dbCon.Open();
            dbCmd = new SqlCommand("sp_InsertProperty", dbCon);
            dbCmd.CommandType = CommandType.StoredProcedure;

            dbCmd.Parameters.AddWithValue("@Description", propty.Description);
            dbCmd.Parameters.AddWithValue("@Price", propty.Price);
            dbCmd.Parameters.AddWithValue("@Image", propty.Image);
            dbCmd.Parameters.AddWithValue("@PropertyType",propty.PropertyType);
            dbCmd.Parameters.AddWithValue("@Status", propty.Status);
            dbCmd.Parameters.AddWithValue("@Surbub", propty.Surbub);

            int x = dbCmd.ExecuteNonQuery();
            dbCon.Close();
            return x;

        }
        public DataTable GetProperty()
        {
            dbCon.Open();
            dbCmd = new SqlCommand("sp_GetProperty", dbCon);

            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbCon.Close();
            return dt;
        }
        //Agency
        public int InsertAgency(Agency agency)
        {
            dbCon.Open();
            dbCmd = new SqlCommand("sp_InsertAgency", dbCon);
            dbCmd.CommandType = CommandType.StoredProcedure;

            dbCmd.Parameters.AddWithValue("@Name", agency.Name);
            dbCmd.Parameters.AddWithValue("@Surbub", agency.Surbub);

            int x = dbCmd.ExecuteNonQuery();
            dbCon.Close();
            return x;
        }
        public DataTable GetAgency()
        {
            dbCon.Open();
            dbCmd = new SqlCommand("sp_GetAgency", dbCon);

            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbCon.Close();
            return dt;
        }
        //Agent
        public int InsertAgent(Agent agent)
        {
            dbCon.Open();
            dbCmd = new SqlCommand("sp_InsertAgent", dbCon);
            dbCmd.CommandType = CommandType.StoredProcedure;

            dbCmd.Parameters.AddWithValue("@Name", agent.Name);
            dbCmd.Parameters.AddWithValue("@Surname", agent.Surname);
            dbCmd.Parameters.AddWithValue("@Email", agent.Email);
            dbCmd.Parameters.AddWithValue("@Password", agent.Password);
            dbCmd.Parameters.AddWithValue("@Phone", agent.Phone);
            dbCmd.Parameters.AddWithValue("@Status", agent.Status);
            dbCmd.Parameters.AddWithValue("@Agency", agent.Agency);

            int x = dbCmd.ExecuteNonQuery();
            dbCon.Close();
            return x;
        }
        public int UpdateAgent(Agent agent)
        {
            dbCon.Open();
            dbCmd = new SqlCommand("sp_UpdateAgent", dbCon);
            dbCmd.CommandType = CommandType.StoredProcedure;

            dbCmd.Parameters.AddWithValue("@AgentID", agent.ID);
            dbCmd.Parameters.AddWithValue("@Email", agent.Email);
            dbCmd.Parameters.AddWithValue("@Phone", agent.Phone);
            dbCmd.Parameters.AddWithValue("@Status", agent.Status);

            int x = dbCmd.ExecuteNonQuery();
            dbCon.Close();
            return x;
        }
        public DataTable GetAgent()
        {
            dbCon.Open();
            dbCmd = new SqlCommand("sp_GetAgent", dbCon);

            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbCon.Close();
            return dt;
        }
        public int DeleteAgent(int agentID)
        {
            dbCon.Open();
            dbCmd = new SqlCommand("sp_DeleteAgent", dbCon);
            dbCmd.CommandType = CommandType.StoredProcedure;

            dbCmd.Parameters.AddWithValue("@AgentID", agentID);
            int x = dbCmd.ExecuteNonQuery();

            dbCon.Close();
            return x;
        }
        public int InsertRental(Rental rent)
        {
            dbCon.Open();
            dbCmd = new SqlCommand("sp_InsertRental", dbCon);
            dbCmd.CommandType = CommandType.StoredProcedure;

            dbCmd.Parameters.AddWithValue("@Property", rent.Property) ;
            dbCmd.Parameters.AddWithValue("@Tenant", rent.Tenant);
            dbCmd.Parameters.AddWithValue("@StartDate", rent.StartDate);
            dbCmd.Parameters.AddWithValue("@EndDate", rent.EndDate); 

            int x = dbCmd.ExecuteNonQuery();
            dbCon.Close();
            return x;
        }
        public int UpdateRental(Rental rent)
        {
            dbCon.Open();
            dbCmd = new SqlCommand("sp_UpdateRental", dbCon);
            dbCmd.CommandType = CommandType.StoredProcedure;

            dbCmd.Parameters.AddWithValue("@StartDate", rent.StartDate);
            dbCmd.Parameters.AddWithValue("@EndDate", rent.EndDate);

            int x = dbCmd.ExecuteNonQuery();
            dbCon.Close();
            return x;
        }
        public DataTable GetRental()
        {
            dbCon.Open();
            dbCmd = new SqlCommand("sp_GetRental", dbCon);

            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbCon.Close();
            return dt;
        }
        public DataTable Login(string email, string password)
        {
            dbCon.Open();
            dbCmd = new SqlCommand("sp_Login", dbCon);
            dbCmd.CommandType = CommandType.StoredProcedure;

            dbCmd.Parameters.AddWithValue("@Email", email);
            dbCmd.Parameters.AddWithValue("@Password", password);

            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbCon.Close();
            return dt;
        }


    }
}
