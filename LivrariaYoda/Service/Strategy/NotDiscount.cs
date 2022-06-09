using LivrariaYoda.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaYoda.Service.Strategy
{
    public class NotDiscount : IDiscount
    {
        public IDiscount? Next { get;  set; }

        public double Calculate(Item item)
        {
            return 0;
        }
    }
}
