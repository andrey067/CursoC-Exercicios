﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioProposto_EnumemracaoEComposicao.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }

        public double Price { get; set; }

        public Product Product { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();


        public OrderItem()
        {

        }
       

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return Product.Name + ",  "
                + Price.ToString("F2", CultureInfo.InvariantCulture) + ", Quantity: " +
                ", Subtotal: $" + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
