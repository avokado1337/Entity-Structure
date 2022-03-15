using Entity_Nested_Structure.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Entity_Nested_Structure.Data
{
    public class EntityDbInitializer : DropCreateDatabaseAlways<EntityContext>
    {
        protected override void Seed(EntityContext context)
        {
            var entites = new List<Entity>
            {
                new Entity { Id = 1, Name = "SuperParent", Description = "Root of everything" },
                new Entity { Id = 2, Name = "Child", Description = "Child", ParentId = 1 },
                new Entity { Id = 3, Name = "ParentChild", Description = "Child", ParentId = 2},
                new Entity { Id = 4, Name = "ParentChild", Description = "Child", ParentId = 2 },
                new Entity { Id = 5, Name = "Child", Description = "Child", ParentId = 4}
            };
            entites.ForEach(x => context.Entities.Add(x));
            context.SaveChanges();
        }
    }
}