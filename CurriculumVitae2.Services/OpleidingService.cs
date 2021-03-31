using System.Collections.Generic;
using CurriculumVitae2.Core;
using CurriculumVitae2.Domain.Models;
using CurriculumVitae2.Domain.Repositories;
using CurriculumVitae2.Domain.Services;
using CurriculumVitae2.Repositories;

namespace CurriculumVitae2.Services
{
    public class OpleidingService : IOpleidingService
    {
        private readonly IOpleidingRepository _opleidingRepository;

        public OpleidingService(IOpleidingRepository opleidingRepository)
        {
            _opleidingRepository = opleidingRepository;
            
        }

        public IList<Opleiding> ListOpleidingen()
        {
            return _opleidingRepository.ListOpleiding();
        }
    }
}