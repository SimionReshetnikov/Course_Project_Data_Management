using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    internal class Routes
    {
        public int Id { get; set; }
        public TimeOnly PassingTime { get; set; }
        public int UserId { get; set; }
        public Users User { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public ICollection<RouteContent> RouteContents { get; set; }
    }
}
