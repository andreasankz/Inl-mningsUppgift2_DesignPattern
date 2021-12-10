using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Facade
{
    public class WordFacade
    {
        public List<char> ListOfChars { get; set; }

        public WordFacade()
        {
            ListOfChars = new List<char>();
        }

        public void SaveWord(string item)
        {
            foreach (var word in item)
            {
                ListOfChars.Add(word);
            }
            
        }

        public void LoadWords()
        {
            Console.Write("Loaded Words: ");
            foreach (var item in ListOfChars)
            {
                Console.Write($"{item}");
            }
        }
    }
}
