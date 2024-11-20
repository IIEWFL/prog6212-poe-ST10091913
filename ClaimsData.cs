using System.Collections.Generic;

namespace ContractMonthlyClaimSystem
{
    public class ClaimsService
    {
        private static ClaimsService _instance;
        public static ClaimsService Instance => _instance ??= new ClaimsService();

        private List<Claim> _claims;

        private ClaimsService()
        {
            _claims = new List<Claim>();
        }

        public void AddClaim(Claim claim)
        {
            _claims.Add(claim);
        }

        public List<Claim> GetPendingClaims()
        {
            return _claims;
        }

        public class Claim
        {
            public string ClaimID { get; set; }
            public string LecturerName { get; set; }
            public int HoursWorked { get; set; }
            public double HourlyRate { get; set; }
            public string AdditionalNotes { get; set; }
            public string Status { get; set; } = "Pending"; // Default status
        }
    }
}
