using System;
using System.Collections.Generic;
using System.Text;

namespace BerekeningSpecificator.Web.Entities
{
    public class RapportVariabelen
    {
        public ICollection<RapportVariabeleBase> Normen { get; }
        public ICollection<RapportVariabeleBase> Attributen { get; }

        public RapportVariabelen()
        {
            this.Normen = new List<RapportVariabeleBase>();
            this.Attributen = new List<RapportVariabeleBase>();
        }
    }
}
