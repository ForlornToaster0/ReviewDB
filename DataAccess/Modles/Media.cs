using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Modles
{
    public class Media
    {
        public object _id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public DateTime Release { get; set; }
        public string Summery { get; set; }
        public int Length { get; set; }
        public string[] Stars { get; set; }
        public string Medias { get; set; }
    }
}
