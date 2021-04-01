using System;
using System.Collections.Generic;

namespace BerekeningSpecificator.Web.Entities
{
    public class RapportOnderwerpVersie
    {
        public Periode Geldig { get; set; }
#pragma warning disable S4004
        public ICollection<int> Condities { get; set; }
        public ICollection<int> Sleutels { get; set; }
#pragma warning restore S4004

        public override bool Equals(object obj)
        {
            return obj is RapportOnderwerpVersie versie &&
                   Equals(Geldig, versie.Geldig) &&
                   Equals(Condities, versie.Condities) &&
                   Equals(Sleutels, versie.Sleutels);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Geldig, Condities, Sleutels);
        }
    }
}
