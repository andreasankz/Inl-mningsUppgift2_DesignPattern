using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Facade
{
    class FacadeMain
    {
       public void Run()
        {
            // Write a facade to make it easier to save and load words

            //List<char> one = new();
            //List<char> two = new();
            //List<char> three = new();
            //List<char> four = new();
            //List<char> five = new();

            WordFacade WordFacade = new();


            // Save Word
            string input = Console.ReadLine();

            if (input.Length <= 0)
            {
                Console.WriteLine("Exiting program - Error - The string need to have character in it!");
                Console.ReadKey(true);                
            }
            else
            {
                //one.Add(input[0]);
                //two.Add(input[1]);
                //three.Add(input[2]);
                //four.Add(input[3]);
                //five.Add(input[4]);
                WordFacade.SaveWord(input);
            }

            
            //Load Word
            if (WordFacade.ListOfChars != null)
            {
                //char[] word = { one.Last(), two.Last(), three.Last(), four.Last(), five.Last() };
                //Console.WriteLine(word);
                WordFacade.LoadWords();
            }
        }
    }
}
