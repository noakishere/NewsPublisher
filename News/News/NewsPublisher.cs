using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News
{
    class NewsPublisher
    {
        public Dictionary<int, NewsReader> newsSubscribers;
        public Dictionary<int, NewsArticle> newsArticles;

        public string newsUpdateMessage;
        public NewsArticle currentShownArticle;

        public NewsPublisher()
        {
            newsSubscribers = new Dictionary<int, NewsReader>();
            newsArticles = new Dictionary<int, NewsArticle>();

            newsUpdateMessage = "NewsPublisher : A new Article is Published";

            currentShownArticle = new NewsArticle("Test", 0);
        }

        public void RegisterSub(NewsReader nr)
        {
            newsSubscribers.Add(nr.id, nr);


            Console.WriteLine("new subscriber is registered: " + nr.name);
        }

        public void UnRegisterSub(NewsReader nr)
        {
            newsSubscribers.Remove(nr.id);

            Console.WriteLine("subscriber is unregistered: " + nr.name);
            ShowSubscribers();
        }

        public void SetNewsArticle(NewsArticle article)
        {
            newsArticles.Add(article.newsNumber, article);
            currentShownArticle = article;
            PrintNotification();
        }

        public void PrintNotification()
        {
            Console.WriteLine(newsUpdateMessage);
            NotifySubscribers();
        }

        public void NotifySubscribers()
        {
            for (int i = 0; i <= newsSubscribers.Count; i++)
            {
                if (newsSubscribers.ContainsKey(i))
                {
                    newsSubscribers[i].ReceiveNotification("Notification : " + newsUpdateMessage);
                }
            }
        }

        public void ShowSubscribers()
        {
            for(int i = 0; i <= newsSubscribers.Count; i++)
            {
                if (newsSubscribers.ContainsKey(i))
                {
                    Console.WriteLine(newsSubscribers[i].name);
                }
            }
        }
    }
}
