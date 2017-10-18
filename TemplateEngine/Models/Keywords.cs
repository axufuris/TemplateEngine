using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateEngine.Models
{
    public class Keywords
    {
        public string Before { get; set; }
        public string After { get; set; }

        public string KeywordDisplay
        {
            get
            {
                return $"{Before} => {After}";
            }
        }

        public bool ShouldSerializeKeywordDisplay()
        {
            return false;
        }
    }  // End of Class
}
