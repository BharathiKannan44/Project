using System;
using System.Data.SqlClient;
using OnlineCollegeAdmission.Entity;

namespace OnlineCollegeAdmission.DAL
{
    public class UserRepository
    {
        public static bool Login(string EmailId, string password)
        {
            using (SqlConnection sqlConnection = DButils.GetDbconnection())
            {
                string command = "sp_Login";
                using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                {
                    try
                    {
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@EmailId", EmailId);
                        sqlCommand.Parameters.AddWithValue("@Password", password);
                        sqlConnection.Open();
                        string flag = sqlCommand.ExecuteScalar().ToString();
                        if (flag == "true")
                            return true;
                        return false;
                    }
                    catch (NullReferenceException)
                    {
                        return false;
                    }
                }
            }
        }
        public static bool SignUp(User user)
        {
            try
            {
                using (SqlConnection sqlConnection = DButils.GetDbconnection())
                {
                    string command = "sp_InsertUser";
                    using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                    {

                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@FirstName", user.firstName);
                        sqlCommand.Parameters.AddWithValue("@SecondName", user.lastName);
                        sqlCommand.Parameters.AddWithValue("@EmailID", user.emailId);
                        sqlCommand.Parameters.AddWithValue("@phoneNumber", user.phoneNumber);
                        sqlCommand.Parameters.AddWithValue("@Dob", user.dob);
                        sqlCommand.Parameters.AddWithValue("@Gender", user.gender);
                        sqlCommand.Parameters.AddWithValue("@Password", user.password);
                        sqlCommand.Parameters.AddWithValue("@Role", "User");
                        sqlConnection.Open();
                        int affectedRows = sqlCommand.ExecuteNonQuery();
                        if (affectedRows >= 1)
                            return true;
                        return false;
                    }
                }
            }
            catch (SqlException)
            {
                return false;
            }
        }
        public static int GetId(User user)
        {
            using (SqlConnection sqlConnection = DButils.GetDbconnection())
            {
                string command = "sp_GetId";
                using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                {
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@EmailId", user.emailId);
                    sqlConnection.Open();
                    return (int)sqlCommand.ExecuteScalar();
                }
            }
        }
    }
}
