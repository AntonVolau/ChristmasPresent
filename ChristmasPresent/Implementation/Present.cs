using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChristmasPresent.Implementation
{
    class Present<ISweet> : IEnumerable<Sweet>
    {
        /// <summary>
        /// Total list of sweets in present box
        /// </summary>
        private readonly List<Sweet> Sweets = new List<Sweet>();

        /// <summary>
        /// Name of present box
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Current volume of present box
        /// </summary>
        public decimal Volume { get; set; }

        /// <summary>
        /// Weight of present box
        /// </summary>
        public decimal Weight { get; set; }

        /// <summary>
        /// Maximum capacity volume of present box
        /// </summary>
        public virtual decimal MaxVolume { get; set; } = 5.00m;

        /// <summary>
        /// Total number of sweets in present box
        /// </summary>
        public int NumberOfSweets => Sweets.Count;

        /// <summary>
        /// Method to find out if present box is overflowed
        /// </summary>
        /// <returns></returns>
        internal bool Overflow()
        {
            if (Volume > MaxVolume)
            {
                return true;
            }
            else return false;
        }

        /// <summary>
        /// Method to add sweet in present box
        /// </summary>
        /// <param name="sweet"></param>
        internal void AddSweets(Sweet sweet)
        {
            Sweets.Add(sweet);
            Weight += sweet.Weight;
            Volume += sweet.Volume;
            if (Overflow())
            {
                throw new OverflowException("Present box can't accommodate so much sweets");
            }
        }

        /// <summary>
        /// Method to add several sweets in present box
        /// </summary>
        /// <param name="sweets"></param>
        internal void AddSweets(Sweet sweet, int count)
        {
            while (count > 0)
            {
                Sweets.Add(sweet);
                Weight += sweet.Weight;
                Volume += sweet.Volume;
                count--;
            }
            if (Overflow())
            {
                throw new OverflowException("Present box can't accommodate so much sweets");
            }
        }

        /// <summary>
        /// Method to remove sweet from present box
        /// </summary>
        /// <param name="sweet"></param>
        internal void RemoveSweets(Sweet sweet)
        {
            Weight -= sweet.Weight;
            Sweets.Remove(sweet);
            Volume -= sweet.Volume;
        }

        /// <summary>
        /// Method to remove several sweets from present box
        /// </summary>
        /// <param name="sweets"></param>
        internal void RemoveSweets(Sweet[] sweets)
        {
            foreach (Sweet i in sweets)
            {
                Weight -= i.Weight;
                Sweets.Remove(i);
                Volume -= i.Volume;
            }
        }

        /// <summary>
        /// Method to sort sweets in present box by weight in descending order
        /// </summary>
        internal void DescendingSortByWeight()
        {
            for (int i = 0; i <= Sweets.Count - 2; i++)
            {
                if (Sweets[i].Weight < Sweets[i+1].Weight)
                {
                    Sweet temp = Sweets[i];
                    Sweets[i] = Sweets[i + 1];
                    Sweets[i+1] = temp;
                }
            }
        }

        /// <summary>
        /// Method to sort sweets in present box by weight in ascending order
        /// </summary>
        internal void AscendingSortByWeight()
        {
            DescendingSortByWeight();
            Sweets.Reverse();
        }

        /// <summary>
        /// Method to get list of sweets with known range of sugar substance
        /// </summary>
        /// <param name="sugarLowerValue"></param>
        /// <param name="sugarUpperValue"></param>
        /// <returns></returns>
        internal List<Sweet> FindCandyesBySugarSubstance(decimal sugarLowerValue, decimal sugarUpperValue)
        {
            List<Sweet> candyesWithSugar = new List<Sweet>();
            for (int i = 0; i < Sweets.Count; i++)
            {
                if (Sweets[i].SugarSubstance >= sugarLowerValue && Sweets[i].SugarSubstance <= sugarUpperValue)
                {
                    candyesWithSugar.Add(Sweets[i]);
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
