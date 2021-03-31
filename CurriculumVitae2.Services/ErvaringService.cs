using System.Collections.Generic;
using CurriculumVitae2.Core;
using CurriculumVitae2.Domain.Models;
using CurriculumVitae2.Domain.Services;

namespace CurriculumVitae2.Services
{
    public class ErvaringService : IErvaringService
    {
        private readonly IDatabase _database;

        public ErvaringService(IDatabase database)
        {
            _database = database;
        }

        public IList<Ervaring> ListErvaringen()
        {
            return _database.Ervaringen;
        }
    }
}