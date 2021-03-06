﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentals.DependancyInjection
{
    public class ClassDependingOnInterface
    {
        private readonly IClassWithInterface classWithInterface;

        public ClassDependingOnInterface(IClassWithInterface classWithInterface)
        {
            this.classWithInterface = classWithInterface;
        }
    }
}
