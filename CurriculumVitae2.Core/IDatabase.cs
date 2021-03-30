using System.Collections.Generic;
using Models;

namespace CurriculumVitae.Core
{
    public interface IDatabase
    {
        public IList<Opleiding> Opleidingen { get; set; }
        public IList<Ervaring> Ervaringen { get; set; }
        void Initialize();
    }
}