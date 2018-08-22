using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenceSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Sentence that is to be split");
            string sentence = Console.ReadLine();
            String[] words = sentence.Split(' ');
            foreach(String word in words)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();
        }
    }
}
