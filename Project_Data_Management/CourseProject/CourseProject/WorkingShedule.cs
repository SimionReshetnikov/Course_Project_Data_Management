using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    internal class WorkingShedule
    {
        public int Id { get; set; }
        public string DayOfWeek { get; set; }
        public TimeOnly OpeningTime { get; set; }
        public TimeOnly ClosingTime { get; set; }
        public int AttractionId { get; set; }
        public Attraction Attraction { get; set; }
    }
}
