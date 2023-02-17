using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SQLservices
    {
        private string connectionsring = "Data Source=CISM-I-294; Initial Catalog=UniteRepository; Trusted_Connection=True;TrustServerCertificate=true; Encrypt=False";
        public object addCountry(string name)
        {
            using (SqlConnection con = new SqlConnection(connectionsring))
            {
                using (SqlCommand cmd = new SqlCommand("addcountry", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@CountryName", SqlDbType.VarChar).Value = name;
                   // cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = txtLastName.Text;

                    con.Open();
                   return cmd.ExecuteNonQuery();
                }
            }
        }
        public DataSet getsatebycountry(int id)
        {
            DataSet result = null;
            using (var sqlConnection = new SqlConnection(connectionsring))
            {
                using (var command = sqlConnection.CreateCommand())
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(command))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.CommandText = "getstatebycountry";
                       
                            command.Parameters.Add("@Countryid", SqlDbType.VarChar).Value = id;

                        result = new DataSet();
                        sda.Fill(result);
                    }
                }
            }
            return result;
        }
        public DataSet GetAllcountry()
        {
            DataSet result = null;
            using (var sqlConnection = new SqlConnection(connectionsring))
            {
                using (var command = sqlConnection.CreateCommand())
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(command))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.CommandText = "GetAllCountryList";


                        result = new DataSet();
                        sda.Fill(result);
                    }
                }
            }
            return result;
        }
        public DataSet GetcitybyState(int id)
        {
            DataSet result = null;
            using (var sqlConnection = new SqlConnection(connectionsring))
            {
                using (var command = sqlConnection.CreateCommand())
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(command))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.CommandText = "GetCitybyState ";

                        command.Parameters.Add("@Stateid", SqlDbType.VarChar).Value = id;

                        result = new DataSet();
                        sda.Fill(result);
                    }
                }
            }
            return result;
        }
        public DataSet GetAllState()
        {
            DataSet result = null;
            using (var sqlConnection = new SqlConnection(connectionsring))
            {
                using (var command = sqlConnection.CreateCommand())
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(command))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.CommandText = "GetAllState";


                        result = new DataSet();
                        sda.Fill(result);
                    }
                }
            }
            return result;
        }
        public DataSet GetAllCity()
        {
            DataSet result = null;
            using (var sqlConnection = new SqlConnection(connectionsring))
            {
                using (var command = sqlConnection.CreateCommand())
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(command))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.CommandText = "GetAllCity";


                        result = new DataSet();
                        sda.Fill(result);
                    }
                }
            }
            return result;
        }

    }
}
