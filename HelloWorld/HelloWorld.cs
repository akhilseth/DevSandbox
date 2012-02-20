using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    public class HelloWorld
    {
        public string SayHelloWorld()
        {
            return SayHello("World");
        }

        public string SayHello(string name)
        {
            return "Hello, " + name;
        }
    }
}
