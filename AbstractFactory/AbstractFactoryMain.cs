using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory
{
    class AbstractFactoryMain
    {
        // Skapa två fabriker som kan köra CreateAnimal() den ena fabriken ska skapa en hund och den andra en katt skapa sedan en abstract factory där man
        // får tillbaka en av de 2 fabrikerna beroende på en sträng parameter
        
        public void Run()
        {
            IAnimal animal;
            AnimalFactory animalFactory;
            string speakSound;

            animalFactory = AnimalFactory.CreateAnimalFactory("Cat");
            animal = animalFactory.GetAnimal("Cat");
            speakSound = animal.Speak();

            Console.WriteLine("Animal Type: " + animal.GetType().Name);
            Console.WriteLine(animal.GetType().Name + " Sounds like: " + speakSound);
            Console.ReadKey();
        }
    }
}
