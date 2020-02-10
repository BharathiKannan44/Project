using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineCollegeAdmission.BL;


namespace OnlineCollgeAdmissionWeb
{
    public partial class Login : System.Web.UI.Page
    {
        IUserBL userBL = new UserBL();
        protected void Page_Load(object sender, EventArgs e)
        {
                
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string role = userBL.Login(txtEmailId.Text, txtPassword.Text);
            if (role == "User")
                Response.Write("<script>alert('Login sucessfully')</script>");
            else if(role == "Admin")
                Response.Write("<script>alert('Admin Login sucessfully')</script>");
            else
                Response.Write("<script>alert('Incorrect Email ID or Passsword ')</script>");

        }

    }
}