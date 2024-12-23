using System.Collections;
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

namespace V06_List_View
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

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            lvEntries.Items.Add(txtInput.Text);
            txtInput.Clear();
            txtInput.Focus();
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            var items = lvEntries.SelectedItems;
            var itemsList= new ArrayList(items);
            foreach( var item in itemsList )
            {
                lvEntries.Items.Remove(item);
            }
        
        }

        private void btnClr_Click(object sender, RoutedEventArgs e)
        {
            lvEntries.Items.Clear();
        }
    }
}