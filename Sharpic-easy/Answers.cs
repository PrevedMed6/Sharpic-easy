namespace Sharpic_easy
{
    internal class Answers
    {
        private List<string> _helloAnswers = new List<string>()
        {
            "Привет", "Рад встрече!"
        };
        private List<string> _whatsYourNameAnswers = new List<string>()
        {
            "Шарпик", "Я забыл..."
        };
        private List<string> _jokeAnswers = new List<string>()
        {
            "— Какие у вас красивые зубы.\n— Это от мамы.\n— Повезло, что подошли", 
            "- Блин, как сесть за курсовой?\n- Напиши про Навального.",
            "- Стой! Стрелять буду!\n- Стою!\nСтреляю!"
        };

        private List<string> _goodByAnswers = new List<string>()
        {
            "Пока", "До свидания"
        };
        private List<string> _aphorismAnswers = new List<string>()
        {
            "Я не огорчаюсь, если люди меня не понимают, — огорчаюсь, если я не понимаю людей.",
            "Похоже, между мной и остальным миром какое-то недопонимание...",
            "Счастье - это когда тебя понимают"
        };
        internal List<string> HelloAnswers
        {
            get
            {
                return _helloAnswers;
            }
        }
        internal List<string> WhatsYourNameAnswers
        {
            get
            {
                return _whatsYourNameAnswers;
            }
        }
        internal List<string> JokeAnswers
        {
            get
            {
                return _jokeAnswers;
            }
        }
        internal List<string> GoodByAnswers
        {
            get
            {
                return _goodByAnswers;
            }
        }
        internal List<string> AphorismAnswers
        {
            get 
            { 
                return _aphorismAnswers; 
            }
        }
    }
}
