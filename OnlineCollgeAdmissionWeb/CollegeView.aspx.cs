using OnlineCollegeAdmission.BL;
using OnlineCollegeAdmission.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineCollgeAdmissionWeb
{
    public partial class CollegeView : System.Web.UI.Page
    {
        ICollegeBL collegeBL = new CollegeBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {                
                BindData();
            }
        }
        protected void BindData()
        {
            gvCollegeTable.DataSource = collegeBL.GetCollegeTable();
            gvCollegeTable.DataBind();
        }

        protected void GvCollegeTable_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                collegeBL.DeleteCollege(gvCollegeTable.DataKeys[e.RowIndex].Values["CollegeCode"].ToString());
                BindData();
            }
            catch (Exception)
            {
                Response.Write("<script>alert(The data is not Deleted...... ')</script>");
            }
        }

        protected void GvCollegeTable_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvCollegeTable.EditIndex = -1;
            BindData();
        }

        protected void GvCollegeTable_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                string collegeCode = gvCollegeTable.DataKeys[e.RowIndex].Values["CollegeCode"].ToString();
                int fee = Convert.ToInt32((gvCollegeTable.Rows[e.RowIndex].FindControl("txtAdmissionFee") as TextBox).Text);
                int seats = Convert.ToInt32((gvCollegeTable.Rows[e.RowIndex].FindControl("txtSeats") as TextBox).Text);
                collegeBL.UpdateCollege(collegeCode, fee, seats);
                gvCollegeTable.EditIndex = -1;
                BindData();
            }
            catch (Exception)
            {
                Response.Write("<script>alert(The data is not update...... ')</script>");
            }

        }

        protected void GvCollegeTable_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvCollegeTable.EditIndex = e.NewEditIndex;
            BindData();
        }
        protected void LbInsert_Click(object sender, EventArgs e)
        {
            try
            {
                string collegeCode = (gvCollegeTable.FooterRow.FindControl("txtCollegeCodeFooter") as TextBox).Text;
                string collegeName = (gvCollegeTable.FooterRow.FindControl("txtCollegeNameFooter") as TextBox).Text;
                string collegeWebsite = (gvCollegeTable.FooterRow.FindControl("txtCollegeWebsiteFooter") as TextBox).Text;
                int fee = Convert.ToInt32((gvCollegeTable.FooterRow.FindControl("txtAdmissionFeeFooter") as TextBox).Text);
                int seats = Convert.ToInt32((gvCollegeTable.FooterRow.FindControl("txtSeatsFooter") as TextBox).Text);
                College college = new College(collegeCode, collegeName, collegeWebsite, fee, seats);
                collegeBL.AddCollege(college);
                gvCollegeTable.EditIndex = -1;
                BindData();
            }
            catch (Exception)
            {
                Response.Write("<script>alert(The data is not Inserted" +
                    "...... ')</script>");
            }
        }
    }
}