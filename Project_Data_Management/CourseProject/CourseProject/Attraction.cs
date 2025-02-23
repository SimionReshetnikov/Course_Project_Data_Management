using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    internal class Attraction
    {
        public int Id { get; set; }
        public string NameAttraction { get; set; }
        public string Website { get; set; }
        public decimal Latitude { get; set; } 
        public decimal Longitude { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public ICollection<PriceTicket> PriceTickets { get; set; }
        public ICollection<RouteContent> RouteContents { get; set; }
        public ICollection<WorkingShedule> WorkingSchedules { get; set; }

    }
}
