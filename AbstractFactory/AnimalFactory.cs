using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory
{
    public abstract class AnimalFactory
    {
        public abstract IAnimal GetAnimal(string AnimalType);

        public static AnimalFactory CreateAnimalFactory(string FactoryType)
        {
            if (FactoryType.Equals("Dog"))
                return new DogFactory();
            else 
                return new CatFactory();
        }
    }
}
