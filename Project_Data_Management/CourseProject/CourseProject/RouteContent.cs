using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    internal class RouteContent
    {
        public int Id { get; set; }
        public int RouteId { get; set; }
        public int SerialNumberAttraction { get; set; }
        public Routes Route { get; set; }
        public int AttractionId { get; set; }
        public Attraction Attraction { get; set; }
    }
}
