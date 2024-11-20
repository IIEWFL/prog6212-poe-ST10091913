using System;

namespace ContractMonthlyClaimSystem
{
    internal class LecturerClaim
    {
        public string LecturerName { get; set; }
        public double HoursWorked { get; set; }
        public double HourlyRate { get; set; }
        public string AdditionalNotes { get; set; }
        public string UploadedFileName { get; set; }
        public string Status { get; set; }
        public double TotalClaimAmount => HoursWorked * HourlyRate; // Auto-calculated property

        public LecturerClaim(string lecturerName, double hoursWorked, double hourlyRate, string additionalNotes, string uploadedFileName)
        {
            LecturerName = lecturerName;
            HoursWorked = hoursWorked;
            HourlyRate = hourlyRate;
            AdditionalNotes = additionalNotes;
            UploadedFileName = uploadedFileName;
            Status = "Pending"; // Default status
        }

        public override string ToString()
        {
            return $"Lecturer: {LecturerName}, Hours: {HoursWorked}, Rate: {HourlyRate:C}, Total: {TotalClaimAmount:C}, Notes: {AdditionalNotes}, File: {UploadedFileName}, Status: {Status}";
        }
    }
}
