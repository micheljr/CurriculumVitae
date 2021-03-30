using System.Collections;
using System.Collections.Generic;
using Models;

namespace CurriculumVitae.Models
{
    public class HomeViewModel
    {
        public IList<Opleiding> Opleidingen { get; set; }
        public IList<Ervaring> Ervaringen { get; set; }
    }
}