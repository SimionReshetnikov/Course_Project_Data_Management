using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    internal class Users
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int StatusId { get; set; }
        public UserStatuses Status { get; set; }
        public ICollection<Routes> Routes { get; set; }
    }
}
