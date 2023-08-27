using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionSamples
{
    // this is custom exception we need to create new instance
    public class MyCustomeException: Exception
    {
        public DateOnly MyDate { get; set; }
        public TimeOnly MyTime { get; set; }
    }
}
