using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vestel_Demo_Api.DAL.Entities
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
