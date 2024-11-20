using System.Windows;

namespace ContractMonthlyClaimSystem
{
    public partial class CoordinatorClaimReviewView : Window
    {
       
        public CoordinatorClaimReviewView()
        {
            InitializeComponent();
        }

        
        public CoordinatorClaimReviewView(string claimStatus)
        {
            InitializeComponent();
            SetClaimStatus(claimStatus);  
        }

        
        private void SetClaimStatus(string claimStatus)
        {
            
            ClaimStatusLabel.Content = claimStatus;
        }

        
        private void ApproveButton_Click(object sender, RoutedEventArgs e)
        {
            
            MessageBox.Show("Claim approved!");
            Close();  
        }

        private void RejectButton_Click(object sender, RoutedEventArgs e)
        {
            
            MessageBox.Show("Claim rejected.");
            Close();  
        }

        
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close(); 
        }
    }
}
