using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Xml;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace KO.Utility.Helper
{
    public static class HapHelper
    {
        public static string GetTitle(HtmlNode htmlNode)
        {
            var title = htmlNode?.SelectSingleNode("//h1[@class='sechead']")?.InnerText.Trim();
            return title;
        }
        public static void RemoveEmptyNodes(HtmlNode htmlNode)
        {
            var notToRemove = new List<string> { "br" };
            if (!notToRemove.Contains(htmlNode.Name) && string.IsNullOrEmpty(htmlNode.InnerText.Replace(Environment.NewLine, string.Empty).Trim()) && !htmlNode.OuterHtml.Contains("<img"))
            {
                htmlNode.Remove();
            }
            else
            {
                for (var i = htmlNode.ChildNodes.Count - 1; i >= 0; i--)
                {
                    RemoveEmptyNodes(htmlNode.ChildNodes[i]);
                }
            }
        }
        static string HtmlOutputFix(string htmlOutput)
        {

            htmlOutput = htmlOutput.Replace("<span>", string.Empty).Replace("</span>", string.Empty);
            htmlOutput = htmlOutput.Replace("<div>", string.Empty).Replace("</div>", string.Empty);
            htmlOutput = htmlOutput.Replace("< ", "<").Replace(" >", ">");
            htmlOutput = Regex.Replace(htmlOutput, "<!--.*?-->", "", RegexOptions.Singleline);
            return htmlOutput;
        }
        public static string GetFirstImage(string htmlOutput, string srcAttiribute = "src")
        {
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(htmlOutput);
            if (htmlDoc.DocumentNode.SelectNodes("//img") == null)
            {
                return string.Empty;
            }
            var images = htmlDoc.DocumentNode.SelectNodes("//img");
            foreach (var img in images)
            {
                var src = img.Attributes[srcAttiribute]?.Value;
                if (src == null)
                {
                    continue;
                }
                if (!src.Contains("data:image"))
                {
                    return img.Attributes[srcAttiribute]?.Value;
                }
            }
            return images[0]?.Attributes[srcAttiribute]?.Value;
        }
        public static string RemoveFirstImage(string htmlOutput)
        {
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(htmlOutput);
            htmlDoc.DocumentNode.SelectSingleNode("//img")?.Remove();
            return htmlDoc.DocumentNode.OuterHtml;
        }
        public static HtmlNode GetHtmlNode(HtmlNode htmlNode, string tagName, string attiributeName = "", string attiributeValue = "")
        {
            return string.IsNullOrEmpty(attiributeName) ?
                htmlNode.SelectSingleNode("//" + tagName) :
                htmlNode.SelectSingleNode("//" + tagName + "[@" + attiributeName + "='" + attiributeValue + "']");
        }
        public static HtmlNodeCollection GetHtmlNodes(HtmlNode htmlNode, string tagName, string attiributeName = "", string attiributeValue = "")
        {
            return string.IsNullOrEmpty(attiributeName) ?
                htmlNode.SelectNodes("//" + tagName) :
                htmlNode.SelectNodes("//" + tagName + "[@" + attiributeName + "='" + attiributeValue + "']");
        }
        public static string GetHtmlCode(string url)
        {
            var data = string.Empty;

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Accept = "text/html, application/xhtml+xml, */*";
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; Trident/7.0; rv:11.0) like Gecko";
            var response = (HttpWebResponse)request.GetResponse();

            using (var dataStream = response.GetResponseStream())
            {
                if (dataStream == null) return data;
                using (var sr = new StreamReader(dataStream))
                {
                    data = sr.ReadToEnd();
                }
            }
            return data;
        }
        public static string GetHtmlOutputWithWebClient(string domain, WebProxy proxyObject = null, int timeOut = 0)
        {
            var htmlOutput = string.Empty;
            try
            {
                var webClient = new WebClient { Encoding = Encoding.UTF8 };
                webClient.Headers.Add("Accept-Language", " en-US");
                webClient.Headers.Add("Accept", " text/html, application/xhtml+xml, */*");
                webClient.Headers.Add("User-Agent", "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; Trident/5.0)");
                if (proxyObject != null)
                {
                    webClient.Proxy = proxyObject;
                }
                var uri = new Uri(domain.StartsWith("http") ? domain : "http://" + domain);
                htmlOutput = webClient.DownloadString(uri);
                webClient.Dispose();
                htmlOutput = HttpUtility.HtmlDecode(htmlOutput);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                /**/
            }
            return htmlOutput;
        }

        public static List<string> GetLastArticleUrls(string url)
        {
            List<string> result = new List<string>();
            var htmlDownloandString = HapHelper.GetHtmlOutputWithWebClient("https://www.wired.com/feed/google-latest-news/sitemap-google-news");
            XmlDocument urldoc = new XmlDocument();
            urldoc.LoadXml(htmlDownloandString);
            /*Create an list of XML nodes from the url nodes in the sitemap*/
            XmlNodeList xmlSitemapList = urldoc.GetElementsByTagName("url");
            /*Loops through the node list and prints the values of each node*/
            foreach (XmlNode node in xmlSitemapList)
            {
                result.Add(node["loc"].InnerText);
            }
            return result;
        }
    }
}
