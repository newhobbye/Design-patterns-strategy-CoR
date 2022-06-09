using LivrariaYoda.Model;
using LivrariaYoda.Service.Strategy;

namespace LivrariaYoda.Service
{
    public class ProcessDiscount
    {
        private IDiscount _15percent;
        private IDiscount _30percent;
        private IDiscount _notDiscount;

        public ProcessDiscount()
        {
            _15percent = new Discount15Percent();
            _30percent = new Discount30Percent();
            _notDiscount = new NotDiscount();
        }



        public double CalculateTotalDiscount(List<Item> list)
        {
            double valueDiscount = 0;
            

            foreach (var item in list)
            {
                double sum = 0;
                _15percent.Next = _30percent;
                _30percent.Next = _notDiscount;
                sum += _15percent.Calculate(item);
                

                valueDiscount += sum;
                
            }
           

            return valueDiscount;
            
        }


    }
}
