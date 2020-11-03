using System;

namespace observer_pattern
{
    public class Television : IMedia
    {
        public void Update(NewsItem item)
        {
            Console.WriteLine($"Television: {item.NewsText}");
        }
    }

}
