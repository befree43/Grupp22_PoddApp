namespace Models
{
    public class Podcasts
    {
        private string? titel;
        private string? kategori;
        private string? url;

        public Podcasts (string? titel, string? kategori, string? url)
        {
            this.titel = titel;
            this.kategori = kategori;
            this.url = url;
        }
    }
}
