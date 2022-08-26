using System.Diagnostics;
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
        private const int maxWrongPassword = 5;
        private const string wpeName = "wpeutil.exe";
        private const string wpeAction = "shutdown";
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
                if(trys == maxWrongPassword)
                {
                    Process wpe = new Process();
                    wpe.StartInfo.FileName = wpeName;
                    wpe.StartInfo.Arguments = wpeAction;

                    wpe.Start();
                    wpe.WaitForExit();

                }
                passwordLabel.Content = $"{trys}. Wrong Password";
                trys++;

            }
        }
    }
}
