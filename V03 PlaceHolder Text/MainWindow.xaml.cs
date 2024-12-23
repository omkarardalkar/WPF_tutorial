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

namespace V03_PlaceHolder_Text
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private const string PlaceholderText = "Password";
        public MainWindow()
        {
            //ShowPlaceholder();
            InitializeComponent();
            ShowPlaceholder();
        }
        private void ShowPlaceholder()
        {
            MyPasswordBox.PasswordChar = '\0'; // Remove masking to show the placeholder
            MyPasswordBox.Foreground = Brushes.Gray; // Set placeholder text color
            MyPasswordBox.Password = string.Empty;
            txtPlaceHolder.Visibility = Visibility.Visible;
        }
        private void PasswordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(MyPasswordBox.Password) && txtPlaceHolder.Visibility == Visibility.Visible)
            {
                MyPasswordBox.PasswordChar = '*'; // Enable password masking
                txtPlaceHolder.Visibility = Visibility.Hidden; // Hide placeholder text
            }
            
        }

        private void PasswordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(MyPasswordBox.Password))
            {
                ShowPlaceholder();
            }
        }
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            MyPasswordBox.Clear();
            MyPasswordBox.Focus();
        }
    }
}