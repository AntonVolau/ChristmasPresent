using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChristmasPresent.Implementation
{
    class Present<Sweet> : IEnumerable<Sweet>
    {
        public Guid ID { get; private set; }
        
        public string Name { get; set; }

        public decimal Weight { get; set; }

        public decimal MaxVolume { get; set; }

        private readonly List<Sweet> Sweets = new List<Sweet>();

        public int NumberOfSweets => Sweets.Count;

        private decimal WeightIncrease(ISweet sweet) => Weight += sweet.Weight;

        private decimal WeightDecrease(ISweet sweet) => Weight -= sweet.Weight;

        internal void AddSweet(Sweet sweet)
        {
            Sweets.Add(sweet);
            WeightIncrease((ISweet)sweet);
        }

        internal void RemoveSweet(Sweet sweet)
        {
            Sweets.Remove(sweet);
            WeightDecrease((ISweet)sweet);
        }

        internal void DescendingSortByWeight()
        {
            Sweets.OrderBy(sweet => GetSweet(0).Weight);
        }

        internal void AscendentSortByWeight()
        {
            DescendingSortByWeight();
            Sweets.Reverse();
        }

        internal ISweet GetSweet(int sweetPosition)
        {
            return (ISweet)Sweets[sweetPosition];
        }

        internal List<object> FindCandyesBySugarSubstance(decimal sugarLowerValue, decimal sugarUpperValue)
        {
            List<object> candyesWithSugar = new List<object>();
            foreach (ISweet sw in Sweets)
            {
                if (sw.SugarSubstance >= sugarLowerValue && sw.SugarSubstance <= sugarUpperValue)
                {
                    candyesWithSugar.Add(sw);
                }
            }
            return candyesWithSugar;
        }

        public IEnumerator<Sweet> GetEnumerator()
        {
            return Sweets.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
