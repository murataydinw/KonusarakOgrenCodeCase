using HtmlAgilityPack;
using KO.Dal.EntityFramework;
using KO.Entities.Entities;
using KO.Service.Abstract;
using System.Collections.Generic;
using System.Linq;
using KO.Utility.Helper;
using System.Xml;
using System.Xml.Linq;
using System.Net;
using System.Threading.Tasks;

namespace KO.Service.Concrete
{
    public class ArticleService : IArticleService
    {
        public void ArticleImport()
        {
            using var context = new EfContext();
            var urls = HapHelper.GetLastArticleUrls("https://www.wired.com/feed/google-latest-news/sitemap-google-news");
            int count = 0;
            #region eski makaleleri temizler
            if (urls.Count > 0)
            {
                var items = context.Articles.Where(x => true);
                foreach (var item in items)
                {
                    context.Articles.Remove(item);
                    context.SaveChanges();
                }
            }
            #endregion
            foreach (var item in urls)
            {
                if (count == 5)
                    break;

                var html = HapHelper.GetHtmlCode(item);
                HtmlDocument htmlDoc = new HtmlDocument();
                htmlDoc.LoadHtml(html);
                var title = htmlDoc.DocumentNode?.SelectSingleNode("//h1")?.InnerText.Trim();
                var body = htmlDoc.DocumentNode?.SelectSingleNode("//div[@data-journey-hook='client-content']")?.InnerText.Trim();


                var test = context.Articles.FirstOrDefault(x => x.Title == title);
                var article = context.Articles.FirstOrDefault(x => x.Title == title) != null ? context.Articles.FirstOrDefault(x => x.Title == title) : new Article();

                article.Title = title;
                article.Body = body;

                if (article.Id > 0)
                {
                    //user.UpdatedAt = DateTime.Now;
                }
                else
                {
                    context.Articles.Add(article);
                }
                context.SaveChanges();
                //string body = HapHelper.HtmlOutputFix(html);
                count++;
            }

        }
        public Article Get(int Id)
        {
            using var context = new EfContext();
            var article = context.Articles.Select(x => new Article
            {
                Id = x.Id,
                Title = x.Title,
                Body = x.Body,

            }).FirstOrDefault(x => x.Id == Id);
            return article;
        }
        public List<Article> GetList()
        {
            using var context = new EfContext();
            var article = context.Articles.Select(x => new Article
            {
                Id = x.Id,
                Title = x.Title,
                Body = x.Body,

            }).Where(x => true).OrderByDescending(x => x.Id).Take(5).ToList();
            return article;
        }

    }
}
