﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public static bool Validate(int age)
        {
            if (age < 0)
            {
                return false;
            }
            return true;
        }
    }

}
