using LivrariaYoda.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaYoda.Service.Strategy
{
    public interface IDiscount
    {
        public IDiscount Next { get; set; }
        double Calculate(Item item);
    }
}
