using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    internal class UserStatuses
    {
        public int Id { get; set; }
        public string NameStatus { get; set; }
        public ICollection<Users> User { get; set; }
        public ICollection<PriceTicket> PriceTickets { get; set; }
    }
}
