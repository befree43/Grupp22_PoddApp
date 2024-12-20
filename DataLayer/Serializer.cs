﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace DataAccessLayer
{
    public class Serializer<T>
    {
        private string fileName;
        public string FileName
        {
            set
            {
                fileName = value;
            }
        }
        public Serializer(string fName)
        {
            FileName = fName + ".xml";
        }
        public void Serialize(List<T> list)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
            using (FileStream xmlOut =
                new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(xmlOut, list);
            }
        }

        public List<T> Deserialize()
        {
            if (!File.Exists(fileName) || new FileInfo(fileName).Length == 0)
            {
                return new List<T>();
            }

            try
            {
                List<T> listan;
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
                using (FileStream xmlIn = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                {
                    listan = (List<T>)xmlSerializer.Deserialize(xmlIn);
                }
                return listan;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fel vid deserialisering: {ex.Message}");
                return new List<T>(); 
            }
        }
    }
}
