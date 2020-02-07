using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using OnlineCollegeAdmission.Entity;

namespace OnlineCollegeAdmission.DAL
{
    public class CollegeRepository
    {
        public static void AddCollege(College college)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Online-College-Admission"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlcommand = new SqlCommand("sp_InsertCollege", connection))
                {
                    sqlcommand.CommandType = CommandType.StoredProcedure;
                    sqlcommand.Parameters.AddWithValue("@CollegeCode", college.collegeCode);
                    sqlcommand.Parameters.AddWithValue("@CollegeName", college.collegeName);
                    sqlcommand.Parameters.AddWithValue("@CollegeWebsite", college.collegeWebsite);
                    sqlcommand.Parameters.AddWithValue("@AdmissionFee", college.admissionFee);
                    sqlcommand.Parameters.AddWithValue("@TotalSeats", college.totalSeats);
                    connection.Open();
                    int row = sqlcommand.ExecuteNonQuery();
                }
            }
        }
        public static void UpdateCollege(string CollegeCode, int fee, int seats)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Online-College-Admission"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {               
                using (SqlCommand sqlCommand = new SqlCommand("sp_UpdateCollege", connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@AdmissionFee", fee);
                    sqlCommand.Parameters.AddWithValue("@TotalSeats", seats);
                    sqlCommand.Parameters.AddWithValue("@CollegeCode", CollegeCode);
                    connection.Open();
                    int row = sqlCommand.ExecuteNonQuery();
                }                  
            }               
        }
        public static void DeleteCollege(string CollegeCode)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Online-College-Admission"].ConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("sp_DeleteCollege" + CollegeCode, sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
        public static DataTable GetCollegeTable()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Online-College-Admission"].ConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("sp_DisplayCollege", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sqlDataAdpater = new SqlDataAdapter(sqlCommand);
                    DataTable dataTable = new DataTable();
                    sqlDataAdpater.Fill(dataTable);
                    return dataTable;
                }
            }
        }
    }
}
