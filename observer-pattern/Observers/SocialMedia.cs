using System;

namespace observer_pattern
{
    // Concrete Implementation of Observers
    public class SocialMedia : IMedia
    {
        public void Update(NewsItem item)
        {
            Console.WriteLine($"Social Media: {item.NewsText}");
        }
    }

}
