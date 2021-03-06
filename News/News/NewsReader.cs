using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News
{
    class NewsReader : IReadNews
    {
        public string name;
        public int id;
        public Queue<string> notifications;

        public NewsReader() { }

        public NewsReader(string name, int id)
        {
            this.name = name;
            this.id = id;
            notifications = new Queue<string>();
        }

        public void SubscribeToNews(NewsPublisher np)
        {
            np.RegisterSub(this);
            Console.WriteLine("You have successfully Subscribed!");
        }

        public void UnSubscribe(NewsPublisher np)
        {
            np.UnRegisterSub(this);
            Console.WriteLine("You have successfully Unsubscribed!");
        }

        public void ReadNews(NewsPublisher np)
        {
            Console.WriteLine(np.currentShownArticle.PrintArticle());
        }

        public void ReceiveNotification(string message)
        {
            notifications.Enqueue(message);
        }

        public void ShowNotifications()
        {
            Console.WriteLine(notifications.Dequeue());
        }
    }
}
