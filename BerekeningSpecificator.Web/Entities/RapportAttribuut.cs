namespace BerekeningSpecificator.Web.Entities
{
    public class RapportAttribuut
    {
        public int Nummer { get; set; }
        public string Omschrijving { get; set; }
        public string Discriminator { get; set; }
        public string Source { get; set; }
        public string Property { get; set; }
        public string Value { get; set; }
        public string Filter { get; set; }
        public string Target { get; set; }
        public bool Prorato { get; set; }

        public override string ToString()
        {
            return $"Nummer: {Nummer}\n" +
                $"Omschrijving: {Omschrijving}\n" +
                $"Discriminator: {Discriminator}\n" +
                $"Source: {Source}\n" +
                $"Property: {Property}\n" +
                $"Value: {Value}\n" +
                $"Filter: {Filter}\n" +
                $"Target: {Target}\n" +
                $"Prorato: {Prorato}";
        }
    }
}
