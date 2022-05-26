using Sharpic_easy.Autofac;
using Sharpic_easy.Repositories;
using Autofac;

namespace Sharpic_easy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintAnswer("Давай поболтаем!");
            bool continueWait = true;
            var container = AutofacConfig.ConfigureContainer();
            Sharpic? bot = container.Resolve<Sharpic>();
            bot.Reply += PrintAnswer;
            while (continueWait) 
            {
                continueWait = bot.FindReply(Console.ReadLine());
            }
            Console.ReadLine();
        }

        static void PrintAnswer(string answer)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(answer);
            Console.ResetColor();
        }
    }
}