namespace observer_pattern
{
    // Subject Interface
    public interface INewsPortal
    {
        // Register Observer
        void RegisterMedia(IMedia media);

        // Unregister Observer
        void UnregisterMedia(IMedia media);

        // Notify all Observers
        void NotifyAllMedia(NewsItem news);
    }

}
