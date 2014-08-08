using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class ModuleController : Controller
    {
        private readonly IProjectRepository _repository;

        public ModuleController(IProjectRepository repository)
        {
            if (repository == null)
            {
                throw new ArgumentException();
            }
            _repository = repository;
        }

        //
        // GET: /FeaturedProjectsViewModel/

        public ViewResult Index()
        {
            var projectService = new ProjectService(_repository);

            var model = new FeaturedProjectsViewModel();

            var projects = projectService.GetFeaturedProject(this.User);

            foreach (var project in projects)
            {
                model.Projects.Add(new ProjectViewModel(project));
            }
            

            return View(model);
        }
    }

    public interface IProjectRepository
    {
        IEnumerable<Module> GetFeaturedProjects();
        IEnumerable<Module> GetProjects(IModuleFilter filter);
    }

    public interface IModuleFilter
    {
    }
}
