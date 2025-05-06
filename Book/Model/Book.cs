public class Book
{
    public int BookId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string Genre { get; set; } = string.Empty;
    public string ISBN { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public DateTime PublishedDate { get; set; } = DateTime.UtcNow;
    public int Pages { get; set; }
    public int StockCount { get; set; }
    public string Synopsis { get; set; } = string.Empty;
    public string CoverImageUrl { get; set; } = string.Empty;
}