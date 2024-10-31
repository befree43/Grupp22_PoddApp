namespace Models
{
    [Serializable]
    public class Podcast
    {
        public string? Titel { get; set; }
        public string? Namn { get; set; }
        public Kategori? Kategori { get; set; }
        public string? Url { get; set; }
        public List<Avsnitt> Avsnitt { get; set; } = new List<Avsnitt>();



        public Podcast (string? titel, Kategori? kategori, string? namn, string? url)
        {
            Titel = titel;
            Namn = namn;
            Kategori = kategori;
            Url = url;

        }

        public Podcast() { }
    }
}
