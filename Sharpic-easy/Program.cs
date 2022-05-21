namespace Sharpic_easy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Давай поболтаем!");
            bool continueWait = true;
            Sharpic bot = new Sharpic(PrintAnswer);
            while (continueWait) 
            {
                continueWait = bot.FindReply(Console.ReadLine());
            }
            Console.ReadLine();
        }

        /// <summary>
        /// Метод передается боту для обработки ответа
        /// </summary>
        /// <param name="answer">полученный ответ</param>
        static void PrintAnswer(string answer)
        {
            Console.WriteLine(answer);
        }
    }
}