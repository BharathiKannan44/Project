using OnlineCollegeAdmission.DAL;
using OnlineCollegeAdmission.Entity;
using System.Data;

namespace OnlineCollegeAdmission.BL
{
    public interface ICollegeBL
    {
        void AddCollege(College college);
        void UpdateCollege(string CollegeCode, int fee, int seats);
        void DeleteCollege(string collegeCode);
        DataTable GetCollegeTable();
    }
    public class CollegeBL : ICollegeBL
    {
        ICollegeRepository collegeRepository;
        public CollegeBL()
        {
            collegeRepository = new CollegeRepository();
        }
        public void AddCollege(College college)
        {
            collegeRepository.AddCollege(college);
        }
        public void UpdateCollege(string collegeCode, int fee, int seats)
        {
            collegeRepository.UpdateCollege(collegeCode, fee, seats);
        }
        public void DeleteCollege(string collegeCode)
        {
            collegeRepository.DeleteCollege(collegeCode);
        }
        public DataTable GetCollegeTable()
        {
            return collegeRepository.GetCollegeTable();
        }
    }
}
