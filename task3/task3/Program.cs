using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
         string ex = generate(" HELLO WORLD! ");
            Console.WriteLine(ex);
        Console.ReadKey();
        }
      
        static string generate(string text)
        {
         


            text = Regex.Replace(text, @"[^\p{L}\d\s-_]", "").Trim().ToLower();      
           
            text = Regex.Replace(text, @"[\s_-]+", "-");

           
            return text;
        }
        

        static string Reverse(string text)
        {
            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return new String(array);
        }


    }
}
