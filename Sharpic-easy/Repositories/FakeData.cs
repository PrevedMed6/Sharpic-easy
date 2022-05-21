using Sharpic_easy.Enums;
using Sharpic_easy.Models;

namespace Sharpic_easy.Repositories
{
    internal static class FakeData
    {
        static List<Message> _messages = new List<Message>()
        {
            new Message(1, PhraseTypesEnum.hello.ToString(), "Привет"),
            new Message(2, PhraseTypesEnum.hello.ToString(), "Здравствуй"),
            new Message(3, PhraseTypesEnum.hello.ToString(), "Здравствуйте"),
            new Message(4, PhraseTypesEnum.hello.ToString(), "Добрый день"),
            new Message(5, PhraseTypesEnum.hello.ToString(), "Добрый вечер"),
            new Message(6, PhraseTypesEnum.hello.ToString(), "Доброе утро"),
            new Message(7, PhraseTypesEnum.hello.ToString(), "Доброй ночи"),
            new Message(8, PhraseTypesEnum.whatsYourName.ToString(), "Как тебя зовут?"),
            new Message(9, PhraseTypesEnum.whatsYourName.ToString(), "Как вас зовут?"),
            new Message(10, PhraseTypesEnum.joke.ToString(), "Анекдот"),
            new Message(11, PhraseTypesEnum.joke.ToString(), "Шутка"),
            new Message(12, PhraseTypesEnum.currentTime.ToString(), "Сколько времени?"),
            new Message(13, PhraseTypesEnum.currentTime.ToString(), "Который час?"),
            new Message(14, PhraseTypesEnum.goodBy.ToString(), "Пока"),
            new Message(15, PhraseTypesEnum.goodBy.ToString(), "До свидания")
        };

        static List<Reply> _replies = new List<Reply>()
        {
            new Reply(1, PhraseTypesEnum.hello.ToString(), "Привет"),
            new Reply(2, PhraseTypesEnum.hello.ToString(), "Рад встрече!"),
            new Reply(3, PhraseTypesEnum.whatsYourName.ToString(), "Шарпик"),
            new Reply(4, PhraseTypesEnum.whatsYourName.ToString(), "Я забыл..."),
            new Reply(5, PhraseTypesEnum.joke.ToString(), "— Какие у вас красивые зубы.\n— Это от мамы.\n— Повезло, что подошли"),
            new Reply(6, PhraseTypesEnum.joke.ToString(), "- Блин, как сесть за курсовой?\n- Напиши про Навального."),
            new Reply(7, PhraseTypesEnum.joke.ToString(), "- Стой! Стрелять буду!\n- Стою!\nСтреляю!"),
            new Reply(8, PhraseTypesEnum.goodBy.ToString(), "Пока"),
            new Reply(9, PhraseTypesEnum.goodBy.ToString(), "До свидания"),
            new Reply(10, PhraseTypesEnum.goodBy.ToString(), "Всё! Я пошел..."),
            new Reply(11, PhraseTypesEnum.aphorism.ToString(), "Я не огорчаюсь, если люди меня не понимают, — огорчаюсь, если я не понимаю людей."),
            new Reply(12, PhraseTypesEnum.aphorism.ToString(), "Похоже, между мной и остальным миром какое-то недопонимание..."),
            new Reply(13, PhraseTypesEnum.aphorism.ToString(), "Счастье - это когда тебя понимают")
        };

        internal static List<Message> Messages 
        { 
            get
            { 
                return _messages;
            } 
        }
        internal static List<Reply> Replies
        {
            get
            {
                return _replies;
            }
        }
    }
}
