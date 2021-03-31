using CurriculumVitae2.Core;

namespace CurriculumVitae2.Repositories
{
    public class BaseRepository
    {
        protected readonly IDatabase Context;

        public BaseRepository(IDatabase context)
        {
            Context = context;
        }
    }
}