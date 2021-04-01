using System.Collections.Generic;

namespace BerekeningSpecificator.Web.Entities
{
    public class RapportProduct
    {
        public int Nummer { get; set; }
        public string Omschrijving { get; set; }
        #pragma warning disable S4004
        public ICollection<int> OnderwerpNrs { get; set; }
        #pragma warning restore S4004
    }
}
