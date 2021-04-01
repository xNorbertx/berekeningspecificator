namespace BerekeningSpecificator.Web.Entities
{
    public class RapportDienstInfo
    {
        public int DienstNr { get; set; }
        public int SoortDienst { get; set; }
        public int SoortVerstrekking { get; set; }
        public Periode Periode { get; set; }
    }
}
