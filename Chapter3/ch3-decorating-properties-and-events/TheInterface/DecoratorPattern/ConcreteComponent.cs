﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class ConcreteComponent : IComponent
    {
        public string Property
        {
            get;
            set;
        }

        public event EventHandler Event = delegate { };
    }
}
