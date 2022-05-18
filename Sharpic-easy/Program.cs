namespace Sharpic_easy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Давай поболтаем!");
            bool continueWait = true;
            while (continueWait) 
            {
                continueWait = ChatMethods.FindAnswer(Console.ReadLine());
            }
        }
    }
}