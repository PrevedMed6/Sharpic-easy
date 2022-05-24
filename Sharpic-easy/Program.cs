using Sharpic_easy.Autofac;
using Sharpic_easy.Repositories;
using Autofac;

namespace Sharpic_easy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Давай поболтаем!");
            bool continueWait = true;
            var container = AutofacConfig.ConfigureContainer();
            Sharpic? bot = container.Resolve<Sharpic>();
            bot.Reply += PrintAnswer;
            //Sharpic bot = new Sharpic(PrintAnswer,new FakeMessageRepo(),new FakeReplyRepo());
            while (continueWait) 
            {
                continueWait = bot.FindReply(Console.ReadLine());
            }
            Console.ReadLine();
        }

        static void PrintAnswer(string answer)
        {
            Console.WriteLine(answer);
        }
    }
}