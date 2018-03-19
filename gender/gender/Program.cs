using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gender
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string lastChar;
            int counter = 0;
            var vowels = new HashSet<char> { 'A', 'E', 'I', 'O', 'U', 'Y', 'a', 'e', 'i', 'o', 'u', 'y' };
            Console.WriteLine("Give me your name: ");
            name = Console.ReadLine();
            for (int i = 0; i < name.Length; i++)
            {
                if (vowels.Contains(name[i]))
                {
                    counter++;
                }
            }
            lastChar = name.Last().ToString();
            if (lastChar == "a")
            {
                Console.WriteLine("Hello: " + name + " you are a female, " + "number of vowels: " + counter);
            }
            else
            {
                Console.WriteLine("Hello: " + name + " you are a male, " + "number of vowels: " + counter);
            }
            Console.ReadLine();
        }
    }
}
