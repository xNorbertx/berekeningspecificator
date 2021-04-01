using System;
using System.Globalization;
using System.Text.Json.Serialization;

namespace BerekeningSpecificator.Web.Entities
{
    public class Periode
    {
        public DateTime Van { get; }
        public DateTime TotEnMet { get; }
    }
}

