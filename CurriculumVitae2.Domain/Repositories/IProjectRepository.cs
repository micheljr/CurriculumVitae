using System.Collections.Generic;
using CurriculumVitae2.Domain.Models;

namespace CurriculumVitae2.Domain.Repositories
{
    public interface IProjectRepository
    {
        IList<Project> ListProjecten();
    }
}