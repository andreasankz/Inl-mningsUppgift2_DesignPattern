using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Adapter
{
    class AdapterMain
    {
        public void Run()
        {
            // Skriv en adapter för ReturningStrings som kan konsumeras av PrintingInts           

            // ReturningStrings
            // PrintingInts


            // OBS TRASIG KOD - TA BORT NÄR DU BÖRJAR KODA
            // Det jag vill göra men inte kan är
            
            PrintingInts printingInts = new();

            ReturnStringService returnString = new();
            printingInts.Print(returnString.ReturnStrings());

            //printingInts.Print(returningStrings.ReturnString());
        }
    }
}
