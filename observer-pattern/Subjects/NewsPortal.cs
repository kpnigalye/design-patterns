using System.Collections.Generic;

namespace observer_pattern
{
    // Concrete implementation of subject
    public class NewsPortal : INewsPortal
    {
        // List of Observers
        public List<IMedia> Observers { get; set; }

        public NewsPortal()
        {
            Observers = new List<IMedia>();
        }

        public void NotifyAllMedia(NewsItem news)
        {
            Observers.ForEach(a => a.Update(news));
        }

        public void RegisterMedia(IMedia media)
        {
            Observers.Add(media);
        }

        public void UnregisterMedia(IMedia media)
        {
            if (Observers.Contains(media))
            {
                Observers.Remove(media);
            }
        }
    }

}
