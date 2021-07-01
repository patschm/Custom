using System;

namespace Models
{
    public class MeetResult
    {
        public string SerialNumber { get; set; }
        public string TypeNummer { get; set; }
        public string[] Resultaten { get; set; } = new string[] { };
    }
}
