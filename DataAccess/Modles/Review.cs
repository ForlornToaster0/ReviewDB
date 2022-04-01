using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Modles
{
    internal class Review
    {
        public object _id { get; set; }
        public string UserName { get; set; }
        public object ReviewId { get; set; }
        public int points { get; set; }
        public DateTime Watched { get; set; }
    }
}
