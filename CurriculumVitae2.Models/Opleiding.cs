using System;

namespace Models
{
    public class Opleiding
    {
        public string Naam { get; set; }
        public string Instituut { get; set; }
        public string Image { get; set; }
        public DateTime StartDatum { get; set; }
        public DateTime EindDatum { get; set; }
        public string Beschrijving { get; set; }
    }
}