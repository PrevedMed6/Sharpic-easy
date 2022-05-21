using Sharpic_easy.Interfaces;
using Sharpic_easy.Models;

namespace Sharpic_easy.Repositories
{
    internal class FakeReplyRepo : IReplyRepo
    {
        public List<Reply> GetByType(string type)
        {
            return FakeData.Replies.Where(m => m.ReplyType == type).ToList();
        }
    }
}
