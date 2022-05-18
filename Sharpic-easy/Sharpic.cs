namespace Sharpic_easy
{
    internal class Sharpic
    {
        public event Func<string,bool> OnEnter;

        public bool Raise(string enteredString)
        {
            return OnEnter(enteredString);
        }
    }
}
