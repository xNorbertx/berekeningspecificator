using System.Collections.Generic;

namespace BerekeningSpecificator.Web.Entities
{
    public class RapportResultaten
    {
        public ICollection<RapportConditieResultaat> ConditieResultaten { get; }
        public ICollection<RapportSleutelTijdlijn> SleutelTijdlijnen { get; }
        public ICollection<RapportOnderwerpResultaat> OnderwerpResultaten { get; }

        public RapportResultaten()
        {
            this.ConditieResultaten = new List<RapportConditieResultaat>();
            this.SleutelTijdlijnen = new List<RapportSleutelTijdlijn>();
            this.OnderwerpResultaten = new List<RapportOnderwerpResultaat>();
        }
    }
}
