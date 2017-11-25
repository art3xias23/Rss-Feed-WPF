using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RssFeedWpf
{
    public class CommonMethods
    {
        //xaml date fixes
        public byte[] GetLoader(string url)
        {
            string xml;
            using (WebClient webclient = new WebClient())
            {
                WebClient web = new WebClient();
                xml = Encoding.UTF8.GetString(web.DownloadData(url));
            }
            xml = xml.Replace("+00:00", "");
            byte[] bytes = System.Text.UTF8Encoding.ASCII.GetBytes(xml);
            return bytes; 
        }

    }
}
