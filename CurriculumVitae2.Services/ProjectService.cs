using System.Collections.Generic;
using CurriculumVitae2.Domain.Models;
using CurriculumVitae2.Domain.Repositories;
using CurriculumVitae2.Domain.Services;

namespace CurriculumVitae2.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository _projectRepository;

        public ProjectService(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public IList<Project> ListProjecten()
        {
            return _projectRepository.ListProjecten();
        }
    }
}