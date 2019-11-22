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

namespace Browser
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

        private void OpenWebSite(object sender, RoutedEventArgs e)
        {
            var uri = new Uri(addressTextBox.Text, UriKind.RelativeOrAbsolute);
            if (!uri.IsAbsoluteUri)
            {
                MessageBox.Show("The Address URI must be absolute. For example, 'http://www.microsoft.com'");
                return;
            }
            browser.Navigate(uri);
        }

        private void TabEnterForOpenWebSite(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                OpenWebSite(sender, e);
            }
        }

        private void AddTab(object sender, RoutedEventArgs e)
        {
            TabItem newTabItem = new TabItem
            {
                Header = "Новая вкладка"
            };
            tabControl.Items.Add(newTabItem);
        }
    }
}
