using Sharpic_easy.Interfaces;
using Sharpic_easy.Models;
using System.Xml.Serialization;

namespace Sharpic_easy.Repositories
{
    public class FileReplyRepo : IReplyRepo
    {
        public List<Reply> GetByType(string type)
        {
            return GetAll().Where(m => m.ReplyType == type).ToList();
        }

        private List<Reply> GetAll()
        {
            List<Reply> replies = new List<Reply>();
            string path = "replies.xml";
            if (File.Exists(path))
            {
                using (FileStream fstream = File.OpenRead(path))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Reply>));
                    replies = xmlSerializer.Deserialize(fstream) as List<Reply>?? replies;
                }
            }
            return replies;
        }
    }
}
