using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PersonligProfil
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenUrl("https://drive.google.com/file/d/1rp4VIyaLU7GiKf0tpeVV771bYZvbhObY/view?usp=drive_link");
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OpenUrl("https://github.com/darlinghaven");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            OpenUrl("https://instagram.com/darlinghaven");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            OpenUrl("https://linkedin.com/in/darlinghaven");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            OpenUrl("https://twitch.tv/darlinghaven");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            OpenUrl("https://youtube.com/@darlinghavenDK");
        }
        private void OpenUrl(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (System.Exception ex)
            {
                MessageBox.Show($"Failed to open link: {ex.Message}");
            }
        }
    }
}