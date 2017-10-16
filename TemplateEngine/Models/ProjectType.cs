using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateEngine.Models
{
    public class ProjectType
    {
        public string DisplayName { get; set; }
        
        public List<Project> Projects { get; set; }

        public string UsableName
        {
            get
            {
                return DisplayName.Replace(" ", string.Empty);
            }
        }
    }  // End of Class
}
