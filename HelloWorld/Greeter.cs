﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    public class Greeter : IGreeter
    {
        protected string _greeting;
        protected bool _exclamation;

        public Greeter(string greeting, bool exclamation)
        {
            _greeting = greeting;
            _exclamation = exclamation;
        }

        public string Greet(string name)
        {
            return _exclamation
                ? _greeting + ", " + name + "!"
                : _greeting + ", " + name + ".";
        }
    }
}
