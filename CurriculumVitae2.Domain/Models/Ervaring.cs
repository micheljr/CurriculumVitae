using System;

namespace CurriculumVitae2.Domain.Models
{
    public class Ervaring
    {
        public string Name { get; set; }
        public string BedrijfName { get; set; }
        public string Image { get; set; }
        public DateTime StartDatum { get; set; }
        public DateTime EindDatum { get; set; }
        public string Beschrijving { get; set; }
    }
}