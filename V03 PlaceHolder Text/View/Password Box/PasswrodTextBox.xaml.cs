using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace V03_PlaceHolder_Text.View.Password_Box
{
    /// <summary>
    /// Interaction logic for PasswrodTextBox.xaml
    /// </summary>
    public partial class PasswrodTextBox : UserControl
    {
        private const string PlaceholderText = "Password";

        public PasswrodTextBox()
        {
            InitializeComponent();
            ShowPlaceholder();
        }

        private void ShowPlaceholder()
        {
            MyPasswordBox.Password = string.Empty;
            MyPasswordBox.PasswordChar = '\0';
            MyPasswordBox.Foreground = Brushes.Gray;
            MyPasswordBox.Password = PlaceholderText;
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            MyPasswordBox.Clear();
            MyPasswordBox.Focus();
        }

        private void MyPasswordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (MyPasswordBox.Password == PlaceholderText)
            {
                MyPasswordBox.Password = string.Empty;
                MyPasswordBox.PasswordChar = '*';
                MyPasswordBox.Foreground = Brushes.Black;
            }
        }

        private void MyPasswordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(MyPasswordBox.Password))
            {
                ShowPlaceholder();
            }
        }
    }
}
