﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class Kategori
    {
        public string? namn { get; set; }

        public Kategori(string? kategoriNamn)
        {
            namn = kategoriNamn;
        }
        public Kategori() { }
    }
}
