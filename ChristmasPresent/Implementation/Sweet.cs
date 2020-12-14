using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasPresent.Implementation
{
    public abstract class Sweet
    {
        /// <summary>
        /// Name of sweet
        /// </summary>
        public string Name { get;  set; }
        /// <summary>
        /// Weight of sweet
        /// </summary>
        public decimal Weight { get; set; }
        /// <summary>
        /// Volume of sweet
        /// </summary>
        public decimal Volume { get; set; }
        /// <summary>
        /// Sugar Substance of sweet
        /// </summary>
        public decimal SugarSubstance { get; set; }
    }
}
