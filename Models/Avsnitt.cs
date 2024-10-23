using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Avsnitt
    {
        private string? titel;
        private string? beskrivning;
        private string? id;

        public Avsnitt(string? titel, string? beskrivning, string? id)
        {
            this.titel = titel;
            this.beskrivning = beskrivning;
            this.id = id;
        }
    }
}
