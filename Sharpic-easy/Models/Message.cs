namespace Sharpic_easy.Models
{
    public class Message
    {
        public Message(int id, string? messageType, string? messageText)
        {
            Id = id;
            MessageType = messageType;
            MessageText = messageText;
        }

        public int Id { get; set; }
        public string? MessageType { get; set; }
        public string? MessageText { get; set; }
    }
}
