using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    internal class PriceTicket
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public int UserStatusId { get; set; }
        public UserStatuses UserStatus { get; set; }
        public int AttractionId { get; set; }
        public Attraction Attraction{ get; set; }

    }
}
