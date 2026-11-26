
namespace NewsHub
{
    public abstract class Publisher
    {
        // Name of the publisher
        public string Name { get; }
        public event EventHandler<ArticlePublishedEventArgs>? ArticlePublished;  
        protected Publisher(string name)                             
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(name);//throw exception if name is null or whitespace
            Name = name;
        }
        public bool Publish(Article article)
        {
            if (!CanPublish(article))
            {
                Console.WriteLine($"[{Name}] rejected: {article.Title}");
                return false;
            }

            Console.WriteLine($"[{Name}] published: {article.Title}");
            OnArticlePublished(new ArticlePublishedEventArgs(article));
            return true;
        }

       
        protected virtual bool CanPublish(Article article) => true;

       
        protected virtual void OnArticlePublished(ArticlePublishedEventArgs e)
            => ArticlePublished?.Invoke(this, e);

        

    }  
}      

    

