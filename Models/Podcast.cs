namespace Models
{
    public class Podcast
    {
        public string? Titel { get; set; }
        public string? Namn { get; set; }
        public string? Kategori { get; set; }
        public string? Url { get; set; }
        public List<Avsnitt> Avsnitt { get; set; } = new List<Avsnitt>();



        public Podcast (string? titel, string? kategori, string? namn, string? url)
        {
            Titel = titel;
            Namn = namn;
            Kategori = kategori;
            Url = url;

        }
    }
}
