using System;
using System.Collections.Generic;

namespace observer_pattern
{
    public class NewsPaper : IMedia
    {
        private List<NewsItem> newsItems;

        public NewsPaper()
        {
            newsItems = new List<NewsItem>(); 
        }

        public void Update(NewsItem item)
        {
            newsItems.Add(item);
        }

        public void PrintAllNews()
        {
            newsItems.ForEach(a => Console.WriteLine(a.NewsText));
        }
    }
}
