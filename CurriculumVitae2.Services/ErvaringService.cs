using System.Collections.Generic;
using CurriculumVitae2.Core;
using CurriculumVitae2.Domain.Models;
using CurriculumVitae2.Domain.Repositories;
using CurriculumVitae2.Domain.Services;

namespace CurriculumVitae2.Services
{
    public class ErvaringService : IErvaringService
    {
        private readonly IErvaringRepository _ervaringRepository;

        public ErvaringService(IErvaringRepository ervaringRepository)
        {
            _ervaringRepository = ervaringRepository;
        }

        public IList<Ervaring> ListErvaringen()
        {
            return _ervaringRepository.ListErvaringen();
        }
    }
}