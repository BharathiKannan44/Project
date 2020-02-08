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
    public partial class SignUp : System.Web.UI.Page
    {
        UserBL userBL = new UserBL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SignUp_Click(object sender, EventArgs e)
        {
            User user = new User(txtFirstName.Text, txtLastName.Text, lstGender.SelectedValue.ToString(), Convert.ToDateTime(txtDob.Text), txtEmail.Text, txtPhoneNumber.Text, txtPassword.Text, "User");
            if (userBL.SignUp(user))
            {
                Response.Write("<script>alert('Sign Up sucessfully...... ')</script>");
                //Response.Write("Sign Up sucessfully......");
                //Response.Write(UserBL.GetId(user) + "is your Id");
                Response.Redirect("Login.aspx");

            }
        }
    }

}