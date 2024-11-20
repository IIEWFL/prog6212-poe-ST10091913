namespace ContractMonthlyClaimSystem.Models
{
    public class Claim
    {
        public string LecturerName { get; set; }
        public decimal HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }
        public string AdditionalNotes { get; set; }
        public string Status { get; set; }
        public int ClaimId { get; set; }

        public Claim(int claimId, string lecturerName, decimal hoursWorked, decimal hourlyRate, string additionalNotes, string status)
        {
            ClaimId = claimId;
            LecturerName = lecturerName;
            HoursWorked = hoursWorked;
            HourlyRate = hourlyRate;
            AdditionalNotes = additionalNotes;
            Status = status;
        }
    }
}
