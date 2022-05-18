namespace Sharpic_easy
{
    internal class ChatMethods
    {
        private Answers answers = new Answers();
        internal string SayHello()
        {
            return GetRandomAnswer(answers.HelloAnswers);
        }
        internal string SayYourName()
        {
            return GetRandomAnswer(answers.WhatsYourNameAnswers);
        }
        internal string TellJoke()
        {
            return GetRandomAnswer(answers.JokeAnswers);
        }
        internal string TellCurrentTime()
        {
            return DateTime.Now.ToShortTimeString();
        }
        internal string TellAphorism()
        {
            return GetRandomAnswer(answers.AphorismAnswers);
        }
        internal string SayGoodBy()
        {
            return GetRandomAnswer(answers.GoodByAnswers);
        }

        internal static bool FindAnswer(string enteredWord)
        {
            if (enteredWord.Contains("Пока"))
            {
                return false;
            }
            return true;
        }

        private string GetRandomAnswer(List<string> list)
        {
            var rnd = new Random();
            rnd.Next(list.Count);
            return list[rnd.Next(list.Count)];
        }
    }
}
