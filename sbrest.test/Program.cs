using System.Threading.Channels;

namespace sbrest.test
{
    internal class Program
    {
        static RestChannel channel = new("https://banks.data.fdic.gov/api/");

        static void Main(string[] args)
        {
            string result = channel.GetAsync("institutions?STALP:IA").Result;
            Console.WriteLine(result);
        }
    }
}
