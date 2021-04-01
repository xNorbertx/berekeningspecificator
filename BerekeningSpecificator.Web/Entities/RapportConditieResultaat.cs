namespace BerekeningSpecificator.Web.Entities
{
    public class RapportConditieResultaat
    {
        public int ConditieNr { get; set; }
        public char Resultaat { get; set; }
        public Periode Periode { get; set; }
    }
}
