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
using System.Xml;
using System.ServiceModel;
using System.ServiceModel.Syndication;

namespace RssFeedWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            grid2_Topic.Visibility = Visibility.Hidden;
        }

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            using (XmlReader reader = XmlReader.Create(txtUrl.Text))
            {
                SyndicationFeed feed = SyndicationFeed.Load(reader);
                lstFeedItems.ItemsSource = feed.Items;
            }
        }

        private void btnLink_Click(object sender, RoutedEventArgs e)
        {
            grid2_Topic.Visibility = Visibility.Hidden;
            btnGo.Visibility = Visibility.Visible;
            txtUrl.Visibility = Visibility.Visible;
        }

        private void btnTopic_Click(object sender, RoutedEventArgs e)
        {
grid2_Topic.Visibility = Visibility.Visible;
            btnGo.Visibility = Visibility.Hidden;
            txtUrl.Visibility = Visibility.Hidden;
        }
    }
}
