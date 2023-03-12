﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm
{
    public abstract class Food
    {
        protected Food(int quantity)
        {
            Quantity = quantity;
        }

        public int Quantity { get; set; }
    }
}
