using System;
using System.Globalization;
using System.Text.Json.Serialization;

namespace BerekeningSpecificator.Web.Entities
{
    public class Periode
    {
        public DateTime Van { get; }
        public DateTime TotEnMet { get; }

        [JsonConstructor]
        public Periode(DateTime van, DateTime totEnMet)
        {
            if (van > totEnMet)
            {
                throw new ArgumentException($"{van} ligt na {totEnMet}");
            }

            Van = van;
            TotEnMet = totEnMet;
        }

        public override string ToString()
        {
            return $"{Van:dd-MM-yyyy} t/m {TotEnMet:dd-MM-yyyy}";
        }
    }
}

