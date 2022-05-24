using Sharpic_easy.Models;

namespace Sharpic_easy.Interfaces
{
    public interface IReplyRepo
    {
        /// <summary>
        /// Взять ответы по типу
        /// </summary>
        /// <param name="type">тип ответа</param>
        /// <returns>Список ответов указанного типа</returns>
        List<Reply> GetByType(string type);
    }
}
