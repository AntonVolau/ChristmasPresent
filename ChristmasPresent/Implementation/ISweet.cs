using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasPresent.Implementation
{
    public interface ISweet
    {
        public Guid ID { get; }

        public string Name { get; set; }

        public decimal Weight { get; set; }

        public decimal Volume { get; set; }

        public decimal SugarSubstance { get; set; }
    }
}
