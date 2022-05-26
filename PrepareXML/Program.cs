using Sharpic_easy.Models;
using Sharpic_easy.Repositories;
using System.Xml.Serialization;

namespace PrepareXML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "replies.xml";
            using (FileStream fstream = new FileStream(path, FileMode.OpenOrCreate))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Reply>));
                xmlSerializer.Serialize(fstream, FakeData.Replies);
            }
        }
    }
}
