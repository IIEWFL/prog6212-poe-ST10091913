using System;
using System.IO;
using System.Windows;

namespace ContractMonthlyClaimSystem
{
    public partial class SubmitClaimWindow : Window
    {
        private string uploadedFileName = string.Empty;

        public SubmitClaimWindow()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            // Validate input fields
            if (!ValidateInputs())
                return;

            // Try to parse hours and rate
            if (!double.TryParse(txtHoursWorked.Text, out double hoursWorked) ||
                !double.TryParse(txtHourlyRate.Text, out double hourlyRate))
            {
                MessageBox.Show("Please enter valid numbers for hours worked and hourly rate.");
                return;
            }

            // Create and add the claim to storage
            Claim newClaim = new Claim(hoursWorked, hourlyRate, txtAdditionalNotes.Text, uploadedFileName, txtLecturerName.Text);
            ClaimStorage.AddClaim(newClaim);

            // Show a success message
            MessageBox.Show($"Claim Submitted!\n" +
                            $"Lecturer Name: {txtLecturerName.Text}\n" +
                            $"Hours Worked: {hoursWorked}\n" +
                            $"Hourly Rate: {hourlyRate}\n" +
                            $"Additional Notes: {txtAdditionalNotes.Text}\n" +
                            $"Uploaded File: {uploadedFileName}");

            // Reset the fields after submission
            ResetFields();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtLecturerName.Text))
            {
                MessageBox.Show("Please enter the lecturer's name.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtHoursWorked.Text) || string.IsNullOrWhiteSpace(txtHourlyRate.Text))
            {
                MessageBox.Show("Please enter hours worked and hourly rate.");
                return false;
            }

            return true;
        }

        private void ResetFields_Click(object sender, RoutedEventArgs e)
        {
            ResetFields();
        }

        private void ResetFields()
        {
            txtLecturerName.Clear();
            txtHoursWorked.Clear();
            txtHourlyRate.Clear();
            txtAdditionalNotes.Clear();
            uploadedFileName = string.Empty;
            lblUploadedFile.Content = "No file uploaded"; // Reset uploaded file label
        }

        private void Upload_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog
            {
                DefaultExt = ".pdf",
                Filter = "Documents (*.pdf;*.docx;*.xlsx)|*.pdf;*.docx;*.xlsx"
            };

            bool? result = dlg.ShowDialog();

            if (result == true)
            {
                uploadedFileName = Path.GetFileName(dlg.FileName);
                lblUploadedFile.Content = $"Uploaded File: {uploadedFileName}"; // Display the uploaded file name
                MessageBox.Show($"File uploaded: {uploadedFileName}");
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); // Closes the window
        }
    }
}
