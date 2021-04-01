using System;
using System.Collections.Generic;

namespace BerekeningSpecificator.Web.Entities
{
    public class RapportOnderwerp
    {
        public int Nummer { get; set; }
        public string Omschrijving { get; set; }
#pragma warning disable S4004
        public ICollection<RapportOnderwerpVersie> Versies { get; set; }
#pragma warning restore S4004


        public override bool Equals(object obj)
        {
            return obj is RapportOnderwerp onderwerp &&
                   Nummer == onderwerp.Nummer &&
                   Omschrijving == onderwerp.Omschrijving &&
                   EqualityComparer<ICollection<RapportOnderwerpVersie>>.Default.Equals(Versies, onderwerp.Versies);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nummer, Omschrijving, Versies);
        }
    }
}
