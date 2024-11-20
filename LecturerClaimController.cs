using System;
using System.Collections.Generic;

namespace ContractMonthlyClaimSystem
{
    internal class LecturerClaimController
    {
        private readonly List<LecturerClaim> _claims = new List<LecturerClaim>();

        public void SubmitClaim(string lecturerName, double hoursWorked, double hourlyRate, string additionalNotes, string uploadedFileName)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(lecturerName))
                throw new ArgumentException("Lecturer name cannot be empty.");

            if (hoursWorked <= 0)
                throw new ArgumentException("Hours worked must be greater than zero.");

            if (hourlyRate <= 0)
                throw new ArgumentException("Hourly rate must be greater than zero.");

            if (string.IsNullOrWhiteSpace(uploadedFileName))
                throw new ArgumentException("An uploaded file is required.");

            // Create the claim
            var claim = new LecturerClaim(lecturerName, hoursWorked, hourlyRate, additionalNotes, uploadedFileName);

            // Add to storage
            _claims.Add(claim);

            Console.WriteLine("Claim submitted successfully:");
            Console.WriteLine(claim.ToString());
        }

        public List<LecturerClaim> GetClaims()
        {
            return _claims;
        }

        public void ApproveClaim(int claimIndex)
        {
            if (claimIndex < 0 || claimIndex >= _claims.Count)
                throw new IndexOutOfRangeException("Invalid claim index.");

            _claims[claimIndex].Status = "Approved";
            Console.WriteLine($"Claim approved for {_claims[claimIndex].LecturerName}.");
        }

        public void RejectClaim(int claimIndex)
        {
            if (claimIndex < 0 || claimIndex >= _claims.Count)
                throw new IndexOutOfRangeException("Invalid claim index.");

            _claims[claimIndex].Status = "Rejected";
            Console.WriteLine($"Claim rejected for {_claims[claimIndex].LecturerName}.");
        }

        public void DisplayClaims()
        {
            if (_claims.Count == 0)
            {
                Console.WriteLine("No claims submitted yet.");
                return;
            }

            for (int i = 0; i < _claims.Count; i++)
            {
                Console.WriteLine($"[{i}] {_claims[i]}");
            }
        }
    }
}
