using System.Windows;

namespace ContractMonthlyClaimSystem
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SubmitClaim_Click(object sender, RoutedEventArgs e)
        {
            SubmitClaimWindow submitClaimWindow = new SubmitClaimWindow();
            submitClaimWindow.Show();
        }

        private void ReviewClaims_Click(object sender, RoutedEventArgs e)
        {
            ReviewClaimsWindow reviewClaimsWindow = new ReviewClaimsWindow();
            reviewClaimsWindow.Show();
        }

        private void UploadDocuments_Click(object sender, RoutedEventArgs e)
        {
            UploadDocumentsWindow uploadDocumentsWindow = new UploadDocumentsWindow();
            uploadDocumentsWindow.Show();
        }

        private void TrackStatus_Click(object sender, RoutedEventArgs e)
        {
            TrackStatusWindow trackStatusWindow = new TrackStatusWindow();
            trackStatusWindow.Show();
        }
    }
}
