using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateEngine.Models
{
    public class Settings
    {
        public string DefaultDirectory { get; set; }

        public List<Keywords> Keywords { get; set; }

        public List<ProjectType> ProjectTypes { get; set; }
    }  // End of Class
}
