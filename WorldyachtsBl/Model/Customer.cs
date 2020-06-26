﻿using System.Collections.Generic;

namespace WorldyachtsBl.Model
{
    public class Customer
    {
        /// <summary>
        /// This class works with the Customer object.
        /// </summary>
        public int CustomerId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Check> Checks { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
