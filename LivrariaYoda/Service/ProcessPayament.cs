using LivrariaYoda.Model;

namespace LivrariaYoda.Service
{

    public class ProcessPayament
    {
        private ProcessDiscount _processDiscount;

        public ProcessPayament(ProcessDiscount processDiscount)
        {
            this._processDiscount = processDiscount;
        }

        public double CalculatePayament(List<Item> list)
        {
            double totalDiscount = _processDiscount.CalculateTotalDiscount(list);

            double totalValue = 0;
            foreach (var item in list)
            {
                totalValue += item.Value * item.Quantity;


            }

            return totalValue - totalDiscount;
            

            
            
        }

        
    }
}
