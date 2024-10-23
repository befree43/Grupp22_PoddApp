namespace Models
{
    public class Podcast
    {
        private string? titel;
        private string? kategori;
        private string? url;

        public Podcast (string? titel, string? kategori, string? url)
        {
            this.titel = titel;
            this.kategori = kategori;
            this.url = url;
        }
    }
}
