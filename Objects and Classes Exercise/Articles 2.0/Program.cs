using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles
{
    public class Article
    {
        public string Title;
        public string Content;
        public string Author;

    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Article> articleList = new List<Article>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Article newArticle = new Article();

                newArticle.Title = input.Split(", ")[0];
                newArticle.Content = input.Split(", ")[1];
                newArticle.Author = input.Split(", ")[2];

                articleList.Add(newArticle);
            }

            string orderCriteria = Console.ReadLine();

            if (orderCriteria == "title")
                articleList = articleList.OrderBy(o => o.Title).ToList();
            else if (orderCriteria == "content")
                articleList = articleList.OrderBy(o => o.Content).ToList();
            else if (orderCriteria == "author")
                articleList = articleList.OrderBy(o => o.Author).ToList();

            foreach (var newArticle in articleList)
            {
                Console.WriteLine($"{newArticle.Title} - {newArticle.Content}: {newArticle.Author}");
            }

        }


    }
}
