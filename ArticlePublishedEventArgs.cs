namespace NewsHub
{
    // EventArgs class for ArticlePublished event
    public class ArticlePublishedEventArgs : EventArgs
    {
        public Article Article { get; }

        public ArticlePublishedEventArgs(Article article)
        {
            Article = article;
        }
    }
}
