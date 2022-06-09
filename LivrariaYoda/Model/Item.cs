using LivrariaYoda.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaYoda.Model
{
    public class Item
    {
        public Item(string name, int quantity, double value, string description, Category category, MediaType mediaType)
        {
            Name = name;
            Quantity = quantity;
            Value = value;
            Description = description;
            Category = category;
            MediaType = mediaType;
        }

        public string Name { get; private set; }
        public int Quantity { get; private set; }
        public double Value { get; private set; }
        public string Description { get; private set; }
        public Category Category { get; private set; }
        public MediaType MediaType { get; private set; }
    }
}
