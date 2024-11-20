namespace ClaimsService
{
    internal class Claim
    {
        public string ClaimID { get; set; }
        public string LecturerName { get; set; }
        public int HoursWorked { get; set; }
        public double HourlyRate { get; set; }
        public string AdditionalNotes { get; set; }
    }
}