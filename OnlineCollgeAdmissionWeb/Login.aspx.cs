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
        UserBL userBL = new UserBL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (userBL.Login(txtEmailId.Text, txtPassword.Text))
                Response.Write("<script>alert('Login sucessfully')</script>");
            else
                Response.Write("<script>alert('Incorrect password or userId')</script>");
        }

    }
}