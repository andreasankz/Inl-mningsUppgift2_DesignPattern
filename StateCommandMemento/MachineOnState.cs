using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento
{
    public class MachineOnState : IMachineState
    {
        public string InputFromUser { get; set; }
        public void PowerSwitch()
        {
            Console.WriteLine("Turning Machine Off");
            //Console.Write("Write something!: ");
            //InputFromUser = Console.ReadLine();
        }
    }
}
