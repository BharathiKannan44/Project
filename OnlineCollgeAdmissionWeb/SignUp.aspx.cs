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
        IUserBL userBL = new UserBL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void SignUp_Click(object sender, EventArgs e)
        {
            User user = new User(txtFirstName.Text, txtLastName.Text, lstGender.SelectedValue.ToString(), Convert.ToDateTime(txtDob.Text), txtEmail.Text, txtPhoneNumber.Text, txtPassword.Text, "User");
            if (userBL.SignUp(user))
            {
                Response.Redirect("Login.aspx");
            }
        }
        protected void CheckDob(object source, ServerValidateEventArgs args)
        {
            if (!DateTime.TryParse(args.Value, out DateTime Date))
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
            
        }
        protected void cvGender_ServerValidate(object source, ServerValidateEventArgs args)
        {
           if(args.Value == "Select Gender")
           {
               args.IsValid = false;
           }
           else
           {
              args.IsValid = true;
           }
        }
    }
}