namespace Sharpic_easy.Models
{
    internal class Message
    {
        internal Message(int id, string? messageType, string? messageText)
        {
            Id = id;
            MessageType = messageType;
            MessageText = messageText;
        }

        internal int Id { get; set; }
        internal string? MessageType { get; set; }
        internal string? MessageText { get; set; }
    }
}
