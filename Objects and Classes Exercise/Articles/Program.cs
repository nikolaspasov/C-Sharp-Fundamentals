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
    //public class EditedArticle
    //{
    //    public string EditedTitle;
    //    public string EditedContent;
    //    public string EditedAuthor;

    //}
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Article newArticle = new Article();

            newArticle.Title = input.Split(", ")[0];
            newArticle.Content = input.Split(", ")[1];
            newArticle.Author = input.Split(", ")[2];

            List<Article> articleList = new List<Article> { };
            articleList.Add(newArticle);

            int n = int.Parse(Console.ReadLine());
            string command = "";
            for (int i = 0; i < n; i++)
            {
                command = Console.ReadLine();

                if (command.Contains("Edit:"))
                {
                    string editedContent = Edit(articleList, command);
                    newArticle.Content = editedContent;
                    articleList.Add(newArticle);
                   
                }
                else if (command.Contains("ChangeAuthor:"))
                {
                    string changedAuthor = ChangeAuthor(articleList, command);
                    newArticle.Author = changedAuthor;
                    articleList.Add(newArticle);

                }
                else if (command.Contains("Rename:"))
                {
                    string renamedTitle =RenameTitle(articleList, command);
                    newArticle.Title = renamedTitle;
                    articleList.Add(newArticle);

                }

            }
            Console.WriteLine($"{newArticle.Title} - {newArticle.Content}: {newArticle.Author}");
        }
        static string Edit (List<Article> articleList, string command )
        {
            
             string editedContent = command.Split(": ")[1];
            return editedContent;
            
        }
        static string ChangeAuthor (List<Article> articleList, string command)
        {
            string changedAuthor = command.Split(": ")[1];
            return changedAuthor;
        }
        static string RenameTitle (List<Article> articleList, string command)
        {
            string renamedTitle = command.Split(": ")[1];
            return renamedTitle;
        }
    }
}
