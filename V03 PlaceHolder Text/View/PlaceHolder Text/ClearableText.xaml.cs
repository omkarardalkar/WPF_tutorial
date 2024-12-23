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

namespace V03_PlaceHolder_Text.View.PlaceHolder_Text
{
    /// <summary>
    /// Interaction logic for ClearableText.xaml
    /// </summary>
    public partial class ClearableText : UserControl
    {
        public ClearableText()
        {
            InitializeComponent();
        }

        private string placeholder;
        public string Placeholder
        {
            get { return placeholder; }
            set
            {
                placeholder = value;
                txtPlaceHolder.Text = placeholder;
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Clear();
            txtInput.Focus();
        }

        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(string.IsNullOrEmpty(txtInput.Text))
            {
                txtPlaceHolder.Visibility = Visibility.Visible;
            }
            else
            {
                txtPlaceHolder.Visibility = Visibility.Hidden;
            }
        }
    }
}
