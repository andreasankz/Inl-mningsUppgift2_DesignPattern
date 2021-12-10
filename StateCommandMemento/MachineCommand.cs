using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento
{
    public class MachineCommand : ICommand
    {
        private readonly IMachineState MachineState;

        public MachineCommand(IMachineState machineState)
        {
            MachineState = machineState;
        }

        public void ExecuteAction()
        {
            if(MachineState is MachineOffState)
            {
                
            }
        }
    }
}
