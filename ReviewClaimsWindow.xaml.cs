using System.Windows;

namespace ContractMonthlyClaimSystem
{
    public partial class ReviewClaimsWindow : Window
    {
        public ReviewClaimsWindow()
        {
            InitializeComponent();
            LoadClaims();
        }

        private void LoadClaims()
        {
            
            ClaimsListView.ItemsSource = ClaimStorage.GetClaims(); 
        }

        private void Approve_Click(object sender, RoutedEventArgs e)
        {
            
            var selectedClaim = ClaimsListView.SelectedItem as Claim;
            if (selectedClaim != null)
            {
                selectedClaim.Status = "Approved";
                MessageBox.Show($"Claim approved for {selectedClaim.LecturerName}");
                LoadClaims(); 
            }
        }

        private void Reject_Click(object sender, RoutedEventArgs e)
        {
            
            var selectedClaim = ClaimsListView.SelectedItem as Claim;
            if (selectedClaim != null)
            {
                selectedClaim.Status = "Rejected";
                MessageBox.Show($"Claim rejected for {selectedClaim.LecturerName}");
                LoadClaims(); 
            }
        }
    }
}
//