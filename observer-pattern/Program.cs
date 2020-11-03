using System;

namespace observer_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Subject or Observable
            INewsPortal portal = new NewsPortal();

            // Observers
            IMedia socialMedia = new SocialMedia();
            IMedia radio = new Radio();
            IMedia tv = new Television();
            NewsPaper newsPaper = new NewsPaper();

            // Observers subscribing to Observable
            portal.RegisterMedia(socialMedia);
            portal.RegisterMedia(radio);
            portal.RegisterMedia(tv);
            portal.RegisterMedia(newsPaper);

            // Notifying observers
            portal.NotifyAllMedia(new NewsItem("Microsoft is hiring!"));
            Console.WriteLine();

            // Unsubscribing from Observable
            portal.UnregisterMedia(radio);
            
            // Notifying observers
            portal.NotifyAllMedia(new NewsItem("Twitter is hiring!"));
            Console.WriteLine();

            // NewsPaper class maintains a list for news items and prints all news at once
            Console.WriteLine("News Paper:");
            newsPaper.PrintAllNews();

            Console.ReadLine();
        }
    }
}
