using System.Collections.Generic;
using CurriculumVitae2.Domain.Models;

namespace CurriculumVitae2.UI.Mvc.Models
{
    public class HomeViewModel
    {
        public IList<Opleiding> Opleidingen { get; set; }
        public IList<Ervaring> Ervaringen { get; set; }
        public IList<Project> Projecten { get; set; }
    }
}