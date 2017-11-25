using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RssFeedWpf
{
    public class Politics 
    {
       public int iD { get; set; }
        public string linkTitle { get; set; }
    }

    public class PoliticsFeeds
    {
        public string routersLink = "http://feeds.reuters.com/Reuters/worldNews";
        public string bbcLink = "http://feeds.bbci.co.uk/news/world/rss.xml";
        public List<Politics> listPolitics = new List<Politics>()
        {
            new Politics() {iD = 1, linkTitle = "http://feeds.reuters.com/Reuters/worldNews"},
          { new Politics() {iD = 2, linkTitle = "http://feeds.bbci.co.uk/news/world/rss.xml" } }
        };
    }
    public class Sports 
    {
    }
    public class Tech 
    {
        public string firstUrl;
        public string txtUrl;
        public void GetInfo()
        {
            //using (XmlReader reader = XmlReader.Create(firstU))
            //{
                
            //    SyndicationFeed feed = SyndicationFeed.Load(reader);
            //    lstFeedItems.ItemsSource = feed.Items;
            //}
        }
    }
}
