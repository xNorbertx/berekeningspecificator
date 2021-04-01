using System.Collections.Generic;

namespace BerekeningSpecificator.Web.Entities
{
    public class RapportVariabelenCollectie
    {
        public ICollection<RapportVariabeleBase> Collectie { get; }

        public RapportVariabelenCollectie()
        {
            Collectie = new List<RapportVariabeleBase>();
        }
    }
}
