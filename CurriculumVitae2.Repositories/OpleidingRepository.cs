using System.Collections.Generic;
using CurriculumVitae2.Core;
using CurriculumVitae2.Domain.Models;
using CurriculumVitae2.Domain.Repositories;

namespace CurriculumVitae2.Repositories
{
    public class OpleidingRepository : BaseRepository,IOpleidingRepository
    {
        public OpleidingRepository(IDatabase context) : base(context)
        {
        }

        public IList<Opleiding> ListOpleiding()
        {
            return Context.Opleidingen;
        }
    }
}