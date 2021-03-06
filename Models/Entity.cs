using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity_Nested_Structure.Models
{
    public class Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ParentId { get; set; }
        public Entity Parent { get; set; }
    }   
}