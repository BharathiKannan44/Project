using OnlineCollegeAdmission.DAL;
using OnlineCollegeAdmission.Entity;

namespace OnlineCollegeAdmission.BL
{
    public class UserBL
    {
        UserRepository userRepository;
        public UserBL()
        {
            userRepository = new UserRepository();
        }
        public bool Login(string EmailId, string password)
        {
            return userRepository.Login(EmailId, password);
        }
        public bool SignUp(User user)
        {
            return userRepository.SignUp(user);
        }
        public int GetId(User user)
        {
            return userRepository.GetId(user);
        }
    }
}
