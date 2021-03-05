using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News
{
    class NewsArticle
    {
        public string content;
        public int newsNumber;

        public NewsArticle(string content, int newsNumber)
        {
            this.content = content;
            this.newsNumber = newsNumber;
        }
        
        public string PrintArticle()
        {
            return newsNumber + " - " + content;
        }
    }
}
