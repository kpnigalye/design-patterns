using System;

namespace observer_pattern
{
    public class Radio : IMedia
    {
        public void Update(NewsItem item)
        {
            Console.WriteLine($"Radio: {item.NewsText}");
        }
    }

}
