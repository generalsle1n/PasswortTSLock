using System.Windows;

namespace PasswortTSLock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string installPassword = "WehrleCoolInstall";
        private int trys = 1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void checkPassword_Click(object sender, RoutedEventArgs e)
        {
            string password = passwordBox.Password.ToString();

            if (password.Equals(installPassword)){
                Application.Current.Shutdown();
            }
            else
            {
                passwordLabel.Content = $"{trys}. Wrong Password";
                trys++;
            }
        }
    }
}
