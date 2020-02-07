
namespace OnlineCollegeAdmission.Entity
{
    public class College
    {
        public string collegeCode { get; set; }
        public string collegeName { get; set; }
        public string collegeWebsite { get; set; }
        public int admissionFee { get; set; }
        public int totalSeats { get; set; }
        public College(string collegeCode, string collegeName, string collegeWebsite, int admissionfee, int totalSeats)
        {
            this.collegeCode = collegeCode;
            this.collegeName = collegeName;
            this.collegeWebsite = collegeWebsite;
            this.admissionFee = admissionfee;
            this.totalSeats = totalSeats;
        }
    }
}
