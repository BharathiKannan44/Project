using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using OnlineCollegeAdmission.Entity;

namespace OnlineCollegeAdmission.DAL
{
    class CollegeRepsitory
    {
        public static void AddCollege(College college)
        {
            
        }
        public static DataTable GetCollegeTable()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Online-College-Admission"].ConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("select * From College", sqlConnection))
                {
                    SqlDataAdapter sqlDataAdpater = new SqlDataAdapter(sqlCommand);
                    DataTable dataTable = new DataTable();
                    sqlDataAdpater.Fill(dataTable);
                    return dataTable;
                }
            }
        }
    }
}
