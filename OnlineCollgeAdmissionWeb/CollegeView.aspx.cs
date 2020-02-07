using OnlineCollegeAdmission.DAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineCollgeAdmissionWeb
{
    public partial class CollegeTable : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindData();
            }
        }

        protected void BindData()
        {
            gvCollegeTable.DataSource = DButils.GetCollegeTable();
            gvCollegeTable.DataBind();
        }
        protected void GvCollegeTable_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string code = gvCollegeTable.DataKeys[e.RowIndex].Values["CollegeCode"].ToString();
                connection.Open();
                SqlCommand sqlcommand = new SqlCommand("Delete from College where CollegeCode =" + code, connection);
                int row = sqlcommand.ExecuteNonQuery();
                BindData();
            }
        }

        protected void GvCollegeTable_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvCollegeTable.EditIndex = -1;
            BindData();
        }

        protected void GvCollegeTable_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string code = gvCollegeTable.DataKeys[e.RowIndex].Values["CollegeCode"].ToString();
            int fee = Convert.ToInt32((gvCollegeTable.Rows[e.RowIndex].FindControl("txtAdmissionFee") as TextBox).Text);
            int seats = Convert.ToInt32((gvCollegeTable.Rows[e.RowIndex].FindControl("txtSeats") as TextBox).Text);
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("sp_UpdateCollege", connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@AdmissionFee", fee);
            sqlCommand.Parameters.AddWithValue("@TotalSeats", seats);
            sqlCommand.Parameters.AddWithValue("@CollegeCode", code);
            int row = sqlCommand.ExecuteNonQuery();
            connection.Close();
            gvCollegeTable.EditIndex = -1;
            BindData();
        }

        protected void GvCollegeTable_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvCollegeTable.EditIndex = e.NewEditIndex;
            BindData();
        }

        protected void LbInsert_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string collegeCode = (gvCollegeTable.FooterRow.FindControl("txtCollegeCodeFooter") as TextBox).Text;
                string collegeName = (gvCollegeTable.FooterRow.FindControl("txtCollegeNameFooter") as TextBox).Text;
                string collegeWebsite = (gvCollegeTable.FooterRow.FindControl("txtCollegeWebsiteFooter") as TextBox).Text;
                int fee = Convert.ToInt32((gvCollegeTable.FooterRow.FindControl("txtAdmissionFeeFooter") as TextBox).Text);
                int seats = Convert.ToInt32((gvCollegeTable.FooterRow.FindControl("txtSeatsFooter") as TextBox).Text);
                using (SqlCommand sqlcommand = new SqlCommand("sp_InsertCollege", connection))
                {
                    sqlcommand.CommandType = CommandType.StoredProcedure;
                    sqlcommand.Parameters.AddWithValue("@CollegeCode", collegeCode);
                    sqlcommand.Parameters.AddWithValue("@CollegeName", collegeName);
                    sqlcommand.Parameters.AddWithValue("@CollegeWebsite", collegeWebsite);
                    sqlcommand.Parameters.AddWithValue("@AdmissionFee", fee);
                    sqlcommand.Parameters.AddWithValue("@TotalSeats", seats);
                    connection.Open();
                    int row = sqlcommand.ExecuteNonQuery();
                    gvCollegeTable.EditIndex = -1;
                    BindData();
                }
            }
                
        }

    }
}