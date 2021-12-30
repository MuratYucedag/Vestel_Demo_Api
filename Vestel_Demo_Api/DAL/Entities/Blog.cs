using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vestel_Demo_Api.DAL.Entities
{
    public class Blog
    {
        public int BlogID { get; set; }
        public string Name { get; set; }
        public int CategoryID { get; set; }
        public Category category { get; set; }
    }
}
