namespace BerekeningSpecificator.Web.Entities
{
    public class RapportVariabeleBase
    {
        public string Nummer { get; set; }
        public string Werkgever { get; set; }
        public decimal Waarde { get; set; }
        public Periode Periode { get; set; }
        public string Data { get; set; }


    }
}
