using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News
{
    interface IPublishNews
    {
        void RegisterSub(NewsReader nr);
        void UnRegisterSub(NewsReader nr);
        void SetNewsArticle(NewsArticle na);
        void PrintNotification();
        void NotifySubscribers();
    }
}
