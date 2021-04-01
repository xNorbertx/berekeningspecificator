using System;
using System.Collections.Generic;
using System.Text;

namespace BerekeningSpecificator.Web.Entities
{
    public class RapportExceptie
    {
        public string ExceptieType { get; set; }
        public string Melding { get; set; }
        public string StackTrace { get; set; }
    }
}
