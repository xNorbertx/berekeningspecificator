namespace BerekeningSpecificator.Web.Entities
{
    public class RapportConditie
    {
        public int Nummer { get; set; }
        public string Omschrijving { get; set; }
        public string Vergelijking { get; set; }
        
        public override string ToString()
        {
            return $"Nummer: {Nummer}\nOmschrijving: {Omschrijving}\nVergelijking: {Vergelijking}";
        }
    }
}
