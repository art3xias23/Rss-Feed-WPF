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
using System.Collections;

namespace RssFeedWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CommonMethods cm = new CommonMethods();

        public MainWindow()
        {
            InitializeComponent();
            grid2_Topic.Visibility = Visibility.Hidden;
        }

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
           if(txtUrl.Text == "")
            {
                MessageBox.Show("Please enter a value for the url string");
            }
           else
            {
                XmlReader reader = XmlReader.Create(txtUrl.Text);


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

        private void btnPolitics_Click(object sender, RoutedEventArgs e)
        {
            PoliticsFeeds linkFeed = new PoliticsFeeds();
            foreach (var item in linkFeed.listPolitics)
            {
                using (XmlReader reader = XmlReader.Create(item.linkTitle))
                {

                    SyndicationFeed feed = SyndicationFeed.Load(reader);
                    List<string> title = new List<string>();
                    var title1 = from item2 in feed.Items
                                 where item2.Title.Text.Contains("se")
                                 select item2;
                    title.Add(title1.ToString());
                    lstFeedItems.ItemsSource = title1.ToList();

                }
            }
        }
    }
}