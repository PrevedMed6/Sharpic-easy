namespace Sharpic_easy
{
    internal class PossiblePhrases
    {
        private List<string> _helloPhrases = new List<string>()
        {
            "Привет", "Здравствуй", "Здравствуйте", "Добрый день", "Добрый вечер", "Доброе утро", "Доброй ночи"
        };
        private List<string> _whatsYourNamePhrases = new List<string>()
        {
            "Как тебя зовут?", "Как вас зовут?"
        };
        private List<string> _jokePhrases = new List<string>()
        {
            "Анекдот", "Шутка"
        };
        private List<string> _whatTimeIsItPhrases = new List<string>()
        {
            "Сколько времени?", "Который час?"
        };
        private List<string> _goodByPhrases = new List<string>()
        {
            "Пока", "До свидания"
        };
        internal List<string> HelloPhrases
        {
            get 
            {
                return _helloPhrases; 
            } 
        }
        internal List<string> WhatsYourNamePhrases
        {
            get
            {
                return _whatsYourNamePhrases;
            }
        }
        internal List<string> JokePhrases
        {
            get
            {
                return _jokePhrases;
            }
        }
        internal List<string> WhatTimeIsItPhrases
        {
            get
            {
                return _whatTimeIsItPhrases;
            }
        }
        internal List<string> GoodByPhrases
        {
            get
            {
                return _goodByPhrases;
            }
        }
    }
}
