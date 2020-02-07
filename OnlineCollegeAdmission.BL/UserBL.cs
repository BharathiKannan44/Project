
using OnlineCollegeAdmission.DAL;
using OnlineCollegeAdmission.Entity;

namespace OnlineCollegeAdmission.BL
{
    public class UserBL
    {
        public static bool Login(string EmailId, string password)
        {
            return UserRepository.Login(EmailId, password);
        }
        public static bool SignUp(User user)
        {
            return UserRepository.SignUp(user);
        }
        public static int GetId(User user)
        {
            return UserRepository.GetId(user);
        }
    }
}
