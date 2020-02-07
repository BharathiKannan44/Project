using OnlineCollegeAdmission.DAL;
using OnlineCollegeAdmission.Entity;
using System.Data;

namespace OnlineCollegeAdmission.BL
{
    public class CollegeBL
    {
        public static void AddCollege(College college)
        {
            CollegeRepository.AddCollege(college);
        }
        public static void UpdateCollege(string collegeCode, int fee, int seats)
        {
            CollegeRepository.UpdateCollege(collegeCode, fee, seats);
        }
        public static void DeleteCollege(string collegeCode)
        {
            CollegeRepository.DeleteCollege(collegeCode);
        }
        public static DataTable GetCollegeTable()
        {
            return CollegeRepository.GetCollegeTable();
        }
    }
}
