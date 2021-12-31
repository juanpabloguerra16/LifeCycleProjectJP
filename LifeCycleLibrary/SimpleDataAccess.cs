using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace LifeCycleLibrary
{
    public class SimpleDataAccess
    {
        private static string GetConenctionString(string name = "UserDatabase")
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public static List<PersonModel> LoadPeople() 
        {
            string sql = "select * from dbo.Person";
            using (IDbConnection cnn = new SqlConnection(GetConenctionString()))
            {
                var people = cnn.Query<PersonModel>(sql).ToList();
                return people; 
            }
        }


    }
}
