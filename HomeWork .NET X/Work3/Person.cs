﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Work3
{
    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public IEnumerable<string> PhoneNumbers { get; set; }
    }
}
