using System.Collections.Generic;
using CurriculumVitae2.Domain.Models;

namespace CurriculumVitae2.Domain.Services
{
    public interface IOpleidingService
    {
        public IList<Opleiding> ListOpleidingen();
    }
}