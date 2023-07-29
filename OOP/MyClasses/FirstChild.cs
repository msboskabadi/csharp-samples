using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.MyClasses
{
    public class FirstChild : Parent
    {
        public string GetChildName() =>
            nameof(FirstChild);
    }
}
