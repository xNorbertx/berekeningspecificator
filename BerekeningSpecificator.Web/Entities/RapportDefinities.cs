using System.Collections.Generic;

namespace BerekeningSpecificator.Web.Entities
{
    public class RapportDefinities
    {
        public ICollection<RapportProduct> Producten { get; }
        public ICollection<RapportOnderwerp> Onderwerpen { get; }
        public ICollection<RapportConditie> Condities { get; }
        public ICollection<RapportSleutel> Sleutels { get; }
        public ICollection<RapportAttribuut> Attributen { get; }

        public RapportDefinities()
        {
            this.Producten = new List<RapportProduct>();
            this.Onderwerpen = new List<RapportOnderwerp>();
            this.Condities = new List<RapportConditie>();
            this.Sleutels = new List<RapportSleutel>();
            this.Attributen = new List<RapportAttribuut>();
        }
    }
}
