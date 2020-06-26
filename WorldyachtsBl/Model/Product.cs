﻿using System.Collections.Generic;
namespace WorldyachtsBl.Model
{
    public class Product
    {
        /// <summary>
        /// This class works with Product object.
        /// </summary>
        /// 
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal ProductType { get; set; }
        public int Count { get; set; }

        public virtual ICollection<Sell> Sells { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Price}";
        }

        public override int GetHashCode()
        {
            return ProductId;
        }

        public override bool Equals(object obj)
        {
            if (obj is Product product)
            {
                return ProductId.Equals(product.ProductId);
            }
            return false;
        }
    }
}
