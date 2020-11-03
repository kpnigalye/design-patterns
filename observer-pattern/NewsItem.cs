namespace observer_pattern
{
    public class NewsItem
    {
        public string NewsText { get; set; }

        public NewsItem(string text)
        {
            NewsText = text;
        }
    }

}
