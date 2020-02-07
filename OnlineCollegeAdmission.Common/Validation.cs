using System.Text.RegularExpressions;

namespace OnlineCollegeAdmission.Common
{
    static class Validation
    {
        public static bool IsValidName(string name)
        {
            Regex regex = new Regex(@"^[A-Za-z]+$", RegexOptions.IgnoreCase);
            return regex.IsMatch(name);
        }
        public static bool IsValidMailId(string mail)
        {
            Regex regex = new Regex("^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+.)+[a-z]{2,5}$");
            return regex.IsMatch(mail);
        }
        public static bool IsValidMobileNumber(string number)
        {
            Regex regex = new Regex(@"^[6789]\d{9}$");
            return regex.IsMatch(number);
        }
        public static bool IsValidPassword(string password)
        {
            Regex regex = new Regex("^(?=.{8,})(?=.*[a-z])(?=.*[A-Z])(?!.*s).*$");
            return regex.IsMatch(password);
        }
        public static bool IsValidWebsite(string website)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            return regex.IsMatch(website);
        }
        public static bool IsValidCode(string code)
        {
            if (code.Length > 6)
            {
                return true;
            }
            return false;
        }
    }
}
