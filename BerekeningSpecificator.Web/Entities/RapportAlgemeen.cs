using System;
using System.Collections.Generic;
using System.Text;

namespace BerekeningSpecificator.Web.Entities
{
    public class RapportAlgemeen
    {
        public int SubjectNr { get; set; }
        public string Omgeving { get; set; }
        #pragma warning disable S3996
        public string Url { get; set; }
        #pragma warning restore S3996
        public Periode BerekenPeriode { get; set; }
        public DateTime End { get; set; }
        public DateTime Start { get; set; }
        public TimeSpan DurationOud { get; set; }
        public TimeSpan DurationNieuw { get { return End - Start; } }

    }
}
