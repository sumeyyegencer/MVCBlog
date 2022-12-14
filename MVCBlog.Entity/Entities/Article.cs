using MVCBlog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBlog.Entity.Entities
{
    public class Article:EntityBase,IEntityBase
    {
      
        public string Title { get; set; }
        public string Content { get; set; }
        public int ViewCount { get; set; }


        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

        public Guid ImageId { get; set; }
        public Image Image { get; set; }
    }

 
}
  