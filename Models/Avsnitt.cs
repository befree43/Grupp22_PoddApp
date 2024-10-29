using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class Avsnitt
    {
        public string? Titel {  get; set; }
        public string? Beskrivning { get; set; }
        public string? Id { get; set; }

        public Avsnitt(string? titel, string? beskrivning, string? id)
        {
            Titel = titel;
            Beskrivning = beskrivning;
            Id = id;
        }

        public Avsnitt() { }
    }
}
