using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    internal class City
    {
        public int Id { get; set; }
        public string Name_city { get; set; }

        public ICollection<Attraction> Attraction { get; set; }
        public ICollection<Routes> Routes { get; set; }
    }
}
