using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News
{
    interface IReadNews
    {
        void SubscribeToNews(NewsPublisher np);
        void UnSubscribe(NewsPublisher np);
        void ReadNews(NewsPublisher np);
        void ReceiveNotification(string message);
    }
}
