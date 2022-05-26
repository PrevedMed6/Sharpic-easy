using Sharpic_easy.Repositories;
using System.Text;
using System.Text.Json;

namespace PrepareBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "message.dat";
            using (FileStream fstream = new FileStream(path, FileMode.OpenOrCreate))
            {
                string writingString = JsonSerializer.Serialize(FakeData.Messages);
                byte[] buffer = Encoding.Default.GetBytes(writingString);
                fstream.Write(buffer, 0, buffer.Length);
            }
        }
    }
}
