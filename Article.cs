
namespace NewsHub
{
    //record type for Article with properties Title, Author, Category, Priority, Id, and PublishedAt
    public record Article(string Title, string Author, Category Category, Priority Priority)

    {
        private static int _nextId = 1;//static field to keep the next id for articles
        public int Id { get; } = _nextId++;
        public DateTime PublishedAt { get; } = DateTime.Now;//this property set to the date/time article is created



    }
}
