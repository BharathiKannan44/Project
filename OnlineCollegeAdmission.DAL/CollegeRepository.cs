using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using OnlineCollegeAdmission.Entity;

namespace OnlineCollegeAdmission.DAL
{
    public class CollegeRepository
    {
        public void AddCollege(College college)
        {          
            using (SqlConnection connection = DButils.GetDbconnection())
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
        public void UpdateCollege(string CollegeCode, int fee, int seats)
        {          
            using (SqlConnection connection = DButils.GetDbconnection())
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
        public void DeleteCollege(string collegeCode)
        {
            using (SqlConnection sqlConnection = DButils.GetDbconnection())
            {
                using (SqlCommand sqlCommand = new SqlCommand("sp_DeleteCollege", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@CollegeCode", collegeCode);
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
        public DataTable GetCollegeTable()
        {
            using (SqlConnection sqlConnection = DButils.GetDbconnection())
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
