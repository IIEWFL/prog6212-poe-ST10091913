using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace ContractMonthlyClaimSystem
{
    public class CoordinatorController
    {
        
        private List<Claim> claims;

        public CoordinatorController()
        {
            claims = new List<Claim>();
            LoadClaims(); // Load existing claims from storage (e.g., database, file, etc.)
        }

        // Loads claims from a data source
        private void LoadClaims()
        {
            
           // claims.Add(new Claim(20, 25, "Lecture on Math", "file1.pdf", "John Doe", "Pending"));
           // claims.Add(new Claim(15, 30, "Lecture on Physics", "file2.pdf", "Jane Smith", "Pending"));
        }

        // View all claims submitted by lecturers
        public List<Claim> ViewClaims()
        {
            return claims;
        }

        // Approve or reject a claim
        public void ApproveClaim(int claimId)
        {
            var claim = claims.FirstOrDefault(c => c.ClaimId == claimId);
            if (claim != null && claim.Status == "Pending")
            {
                claim.Status = "Approved";
                MessageBox.Show($"Claim with ID: {claimId} has been approved.");
            }
            else
            {
                MessageBox.Show($"Claim with ID: {claimId} is not in a pending state.");
            }
        }

        // Reject a claim
        public void RejectClaim(int claimId)
        {
            var claim = claims.FirstOrDefault(c => c.ClaimId == claimId);
            if (claim != null && claim.Status == "Pending")
            {
                claim.Status = "Rejected";
                MessageBox.Show($"Claim with ID: {claimId} has been rejected.");
            }
            else
            {
                MessageBox.Show($"Claim with ID: {claimId} is not in a pending state.");
            }
        }

        
        public Claim GetClaimDetails(int claimId)
        {
            return claims.FirstOrDefault(c => c.ClaimId == claimId);
        }
    }

    // Claim class for handling claim data (for this example)
    public class Claim
    {
        public int ClaimId { get; set; }
        public double HoursWorked { get; set; }
        public double HourlyRate { get; set; }
        public string AdditionalNotes { get; set; }
        public string UploadedFile { get; set; }
        public string LecturerName { get; set; }
        public string Status { get; set; }

        public Claim(double hoursWorked, double hourlyRate, string additionalNotes, string uploadedFile, string lecturerName, string status = "Pending")
        {
            ClaimId = new Random().Next(1000, 9999); // Random claim ID for this example
            HoursWorked = hoursWorked;
            HourlyRate = hourlyRate;
            AdditionalNotes = additionalNotes;
            UploadedFile = uploadedFile;
            LecturerName = lecturerName;
            Status = status;
        }
    }
}
