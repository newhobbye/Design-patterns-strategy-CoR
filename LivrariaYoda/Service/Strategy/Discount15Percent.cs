using LivrariaYoda.Model;

namespace LivrariaYoda.Service.Strategy
{
    internal class Discount15Percent : IDiscount
    {
        public IDiscount? Next { get; set; }
        public double Calculate(Item item)
        {
            if ("LIVRO".Equals(item.Category.ToString()) && "DIGITAL".Equals(item.MediaType.ToString()))
            {
                double total = item.Value * item.Quantity;
                return total * 0.15;
            }
            else if ("REVISTA".Equals(item.Category.ToString()) && "DIGITAL".Equals(item.MediaType.ToString()))
            {
                double total = item.Value * item.Quantity;
                return total * 0.15;
            }
            else
            {
                return Next.Calculate(item);
            }
        }
    }
}
