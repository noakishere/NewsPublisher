using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News
{
    class Program
    {
        static void Main(string[] args)
        {
            NewsReader currentNewsReader = new NewsReader();


            NewsPublisher newsPublisher = new NewsPublisher();
            NewsReader nr = new NewsReader("Mohammad", 0);
            NewsReader nr2 = new NewsReader("Ali", 1);

            newsPublisher.RegisterSub(nr);
            newsPublisher.RegisterSub(nr2);

            NewsArticle na1 = new NewsArticle("Test content", 0);
            NewsArticle na2 = new NewsArticle("Test content", 1);
            NewsArticle na3 = new NewsArticle("Test content", 2);

            newsPublisher.SetNewsArticle(na1);
            newsPublisher.SetNewsArticle(na3);
            newsPublisher.SetNewsArticle(na2);

            newsPublisher.ShowSubscribers();

            Console.WriteLine("----------");

            currentNewsReader = nr;

            currentNewsReader.ShowNotifications();
            currentNewsReader.ReadNews(newsPublisher);
            Console.ReadLine();
        }
    }
}
