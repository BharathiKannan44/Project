using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCollegeAdmission.DAL
{
    public static class DButils
    {
        public static SqlConnection GetDbconnection()
        {
                string connectionString = ConfigurationManager.ConnectionStrings["Online-College-Admission"].ConnectionString;
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                return sqlConnection;
        }
        
    }
}
