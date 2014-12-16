using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Downloader
    {
        public static string DownloadHtml(string url)
        {
            WebClient client = new WebClient();

            Console.WriteLine("Downloading ....");

            var download = client.DownloadString(url);

            return download;
        }
    }
}
