using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Adapter
{
    class ReturnStringService : IReturnStringService
    {
        public ReturningStrings ReturningStrings { get; set; }

        public ReturnStringService()
        {
            ReturningStrings = new ReturningStrings();
        }
        public int ReturnStrings()
        {
            var number = Convert.ToInt32(ReturningStrings.ReturnString());
            return number;
        }
    }
}
