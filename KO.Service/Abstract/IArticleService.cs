using KO.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KO.Service.Abstract
{
   public interface IArticleService
    {
        Article Get(int Id);
        List<Article> GetList();
        void ArticleImport();
    }
}
