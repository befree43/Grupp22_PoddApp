using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public class Serializer<T>
    {
        private string filePath;

        public Serializer(string fullPath)
        {
            filePath = fullPath;
        }

        public void Serialize(List<T> list)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
            using (FileStream xmlOut = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(xmlOut, list);
            }
        }

        public List<T> Deserialize()
        {
            List<T> list;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
            using (FileStream xmlIn = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read))
            {
                try
                {
                    list = (List<T>)xmlSerializer.Deserialize(xmlIn);
                }
                catch
                {
                    // If the file is empty or does not exist, return an empty list
                    list = new List<T>();
                }
            }
            return list;
        }
    }
}
