﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
    internal class Product
    {
        private string name;
        public string Name { get; set; }

        public Product(string name)
        {
            this.name = name;
        }
        void Print(string prefix) => Console.WriteLine($"{prefix}");

    }
}
