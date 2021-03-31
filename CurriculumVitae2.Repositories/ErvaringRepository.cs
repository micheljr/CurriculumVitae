using System.Collections.Generic;
using CurriculumVitae2.Core;
using CurriculumVitae2.Domain.Models;
using CurriculumVitae2.Domain.Repositories;

namespace CurriculumVitae2.Repositories
{
    public class ErvaringRepository : BaseRepository, IErvaringRepository
    {
        public ErvaringRepository(IDatabase context) : base(context)
        {
        }

        public IList<Ervaring> ListErvaringen()
        {
            return Context.Ervaringen;
        }
    }
}