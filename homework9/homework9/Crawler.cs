using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace homework9
{
    class Crawler
    {
        public event Action<string> InfoTextChange;
        public static readonly string urlParseRegex = @"^(?<site>(?<protocal>https?)://(?<host>[\w.-]+)(:\d+)?($|/))(\w+/)*(?<file>[^#?]*)";
        public Hashtable urls = new Hashtable();
        private int count = 0;
        private string current = null;
        public int depth { get; set; } = 10;


        public void Crawl()
        {
            while (true)
            {
                try { 
                    foreach (string url in urls.Keys)
                    {
                        if ((bool)urls[url]) continue;
                        current = url;
                    }

                    if (current == null || count > depth) break;
                    string html = DownLoad(current); // 下载
                    urls[current] = true;
                    string info = current + "  SUCCESS"+"\r\n";
                    InfoTextChange(info);
                    count++;
                    Parse(html, current);//解析,并加入新的链接
                    }
                catch(Exception e)
                {
                    string info = current + "  ERROR" + "\r\n";
                    InfoTextChange(info);
                }
            }
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        private void Parse(string html, string currenturl)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\"', '#', '>');
                if (strRef.Length == 0) continue;
                strRef = FixUrl(strRef, currenturl);
                if (urls[strRef] == null) urls[strRef] = false;
            }
        }

        static private string FixUrl(string url, string pageUrl)
        {
            if (url.Contains("://"))
            { 
                return url;
            }
            if (url.StartsWith("//"))
            {
                Match urlMatch = Regex.Match(pageUrl, urlParseRegex);
                string protocal = urlMatch.Groups["protocal"].Value;
                return protocal + ":" + url;
            }
            if (url.StartsWith("/"))
            {
                Match urlMatch = Regex.Match(pageUrl, urlParseRegex);
                String site = urlMatch.Groups["site"].Value;
                return site.EndsWith("/") ? site + url.Substring(1) : site + url;
            }

            if (url.StartsWith("../"))
            {
                url = url.Substring(3);
                int idx = pageUrl.LastIndexOf('/');
                return FixUrl(url, pageUrl.Substring(0, idx));
            }

            if (url.StartsWith("./"))
            {
                return FixUrl(url.Substring(2), pageUrl);
            }
            
            int end = pageUrl.LastIndexOf("/");
            return pageUrl.Substring(0, end) + "/" + url;
        }
    }
}
