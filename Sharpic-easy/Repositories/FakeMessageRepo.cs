using Sharpic_easy.Enums;
using Sharpic_easy.Interfaces;
using Sharpic_easy.Models;

namespace Sharpic_easy.Repositories
{
    public class FakeMessageRepo : IMessageRepo
    {
        public string GetTypeByPart(string message)
        {
            message = Utils.CleanMessage(message);
            return FakeData.Messages.Where(m=> m.MessageText != null 
                && m.MessageText.ToLowerInvariant().Contains(message.ToLowerInvariant())).FirstOrDefault()?.MessageType ?? PhraseTypesEnum.aphorism.ToString();
        }
    }
}
