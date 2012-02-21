using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    public class Greeter : IGreeter
    {
        protected string _greeting;

        public Greeter(string greeting)
        {
            _greeting = greeting;
        }

        public string Greet(string name)
        {
            return _greeting + ", " + name;
        }
    }
}
