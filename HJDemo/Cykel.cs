using System;
using System.Collections.Generic;
using System.Text;

namespace HJDemo
{
    class Cykel
    {
        public string Color { get; set; }
        public int NumOfGears { get; private set; }
        public bool HasBell { get; set; }
        public bool HasBasket { get; set; }
        public double SizeInInches { get; private set; }

        //public Cykel()
        //{
        //}

        public Cykel(int numOfGHears, double sizeInInches)
        {
            NumOfGears = numOfGHears;
            SizeInInches = sizeInInches;
        }
    }
}
