using LivrariaYoda.Model;

namespace LivrariaYoda.Service.Strategy
{
    internal class Discount30Percent : IDiscount
    {
        public IDiscount? Next { get; set; }

        public double Calculate(Item item)
        {
            if("LIVRO".Equals(item.Category.ToString()) && "IMPRESSO".Equals(item.MediaType.ToString())){
                double total = item.Value * item.Quantity;
                return total * 0.3;
            }
            else if("REVISTA".Equals(item.Category.ToString()) && "IMPRESSO".Equals(item.MediaType.ToString()))
            {
                double total = item.Value * item.Quantity;
                return total * 0.3;
            }
            else if ("JOGOTABULEIRO".Equals(item.Category.ToString()))
            {
                double total = item.Value * item.Quantity;
                return total * 0.3;
            }
            else
            {
                return Next.Calculate(item);
            }
        }
    }
}
