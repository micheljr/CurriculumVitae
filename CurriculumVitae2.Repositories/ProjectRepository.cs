using System.Collections.Generic;
using CurriculumVitae2.Core;
using CurriculumVitae2.Domain.Models;
using CurriculumVitae2.Domain.Repositories;

namespace CurriculumVitae2.Repositories
{
    public class ProjectRepository : BaseRepository, IProjectRepository
    {
        public ProjectRepository(IDatabase context) : base(context)
        {
        }

        public IList<Project> ListProjecten()
        {
            return Context.Projecten;
        }
    }
}