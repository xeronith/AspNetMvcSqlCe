using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetMvcSqlCe.Models
{
    public class Item
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }

        public virtual int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}