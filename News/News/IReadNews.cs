using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News
{
    interface IReadNews
    {
        void SubscribeToNews();
        void UnSubscribe();
        void ReadNews(NewsPublisher np);
        void ReceiveNotification(string message);
    }
}
