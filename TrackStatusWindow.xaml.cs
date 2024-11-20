using System;
using System.Linq;
using System.Windows;

namespace ContractMonthlyClaimSystem
{
    public partial class TrackStatusWindow : Window
    {
        public TrackStatusWindow()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            string lecturerName = txtLecturerNameSearch.Text;

            if (string.IsNullOrWhiteSpace(lecturerName))
            {
                MessageBox.Show("Please enter a lecturer name to search.");
                return;
            }

            // Search for claims by lecturer's name
            var filteredClaims = ClaimStorage.GetClaims().Where(c => c.LecturerName.Equals(lecturerName, StringComparison.OrdinalIgnoreCase)).ToList();

            if (filteredClaims.Any())
            {
                ClaimsListView.ItemsSource = filteredClaims;
            }
            else
            {
                MessageBox.Show("No claims found for the given lecturer.");
                ClaimsListView.ItemsSource = null;
            }
        }
    }
}
