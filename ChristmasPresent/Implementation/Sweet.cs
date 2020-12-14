using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasPresent.Implementation
{
    public abstract class Sweet
    {
        public Guid ID { get; private set; }

        public string Name { get; set; }

        public decimal Weight { get; set; }

        public decimal Volume { get; set; }

        public decimal SugarSubstance { get; set; }
    }
}
