using System.Collections.Generic;

namespace Task2___Present
{
    public class PriceSorter : IComparer<Sweet>
    {
        public int Compare(Sweet x, Sweet y)
        {
            if (x.Price > y.Price)
            {
                return 1;
            }
            else if (x.Price < y.Price)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
