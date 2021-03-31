using System.Collections.Generic;
using CurriculumVitae2.Core;
using CurriculumVitae2.Domain.Models;
using CurriculumVitae2.Domain.Services;

namespace CurriculumVitae2.Services
{
    public class OpleidingService : IOpleidingService
    {
        private readonly IDatabase _database;

        public OpleidingService(IDatabase database)
        {
            _database = database;
        }

        public IList<Opleiding> ListOpleidingen()
        {
            return _database.Opleidingen;
        }
    }
}