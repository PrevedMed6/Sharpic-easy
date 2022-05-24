using Sharpic_easy.Models;

namespace Sharpic_easy.Interfaces
{
    public interface IMessageRepo
    {
        /// <summary>
        /// Вернуть тип запроса к боту
        /// </summary>
        /// <param name="message">сообщение пользователя</param>
        /// <returns>тип запроса</returns>
        string GetTypeByPart(string message);
    }
}
