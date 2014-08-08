using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Models
{
    public class ProjectViewModel
    {
        IEnumerable<ProjectViewModel> InnerModules { get; set; }

        public string Title { get; set; }

        public string Picture { get; set; }
    }
}