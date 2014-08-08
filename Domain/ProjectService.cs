using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Domain
{
    public class ProjectService
    {
        private readonly ProjectRepository _repository;

        public ProjectService(ProjectRepository repository)
        {
            if (repository == null)
            {
                throw new ArgumentException();
            }
            _repository = repository;
        }

        public IEnumerable<Project> GetFeaturedProjects()
        {
            var items = _repository.GetFeaturedProject();
            //apply some actions like discount
        }
    }
}
