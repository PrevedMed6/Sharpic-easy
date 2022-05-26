using Sharpic_easy.Enums;
using Sharpic_easy.Interfaces;
using Sharpic_easy.Models;
using System.Text;
using System.Text.Json;

namespace Sharpic_easy.Repositories
{
    public class FileMessageRepo : IMessageRepo
    {
        public string GetTypeByPart(string message)
        {
            message = Utils.CleanMessage(message);
            string type = PhraseTypesEnum.aphorism.ToString();
            
            return GetAll().Where(m=> m.MessageText != null 
                && m.MessageText.ToLowerInvariant().Contains(message.ToLowerInvariant())).FirstOrDefault()?.MessageType ?? PhraseTypesEnum.aphorism.ToString();
        }
        private List<Message> GetAll()
        {
            List<Message> messages = new List<Message>();
            string path = "message.dat";
            if (File.Exists(path))
            {
                using (FileStream fstream = File.OpenRead(path))
                {
                    byte[] buffer = new byte[fstream.Length];
                    fstream.Read(buffer, 0, buffer.Length);
                    string textMessages = Encoding.Default.GetString(buffer);
                    messages = JsonSerializer.Deserialize<List<Message>>(textMessages) ?? messages;
                }
            }
            return messages;
        }
    }
}
