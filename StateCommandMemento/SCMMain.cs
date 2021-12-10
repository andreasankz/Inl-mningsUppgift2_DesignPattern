using System;

namespace Assignment2.StateCommandMemento
{
    internal class SCMMain
    {
        /*
         * Skapa en maskin som kan vara av eller på. !Använd State Pattern!
         * Om man ger den ett kommando när den är av så ska den spara det kommandot och sen köra alla sparade kommandon när den sätts på. !Använd Command Pattern!
         * Kommandot ska vara att skriva ut en sträng text som användaren anger.
         * Det ska också finnas en reset funktion som tar bort alla sparade kommandon och stänger av maskinen. !Använd Memento Pattern!
         */
        public void Run()
        {
            Machine machine = new();

            Console.WriteLine("A: Turn on/off machine");
            Console.WriteLine("E: Exit");

            while (true)
            {

                var userInput = Console.ReadKey(true).KeyChar;
                
                switch (userInput)
                {
                    case 'a' or 'A':
                        machine.PowerSwitch();
                        break;

                    case 'e' or 'E':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Not valid!");
                        break;
                }
            }

        }
    }
}