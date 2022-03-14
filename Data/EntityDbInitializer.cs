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
            Entity entity = new Entity { Id = 1, Name = "SuperParent", Description = "Root of everything" };
            Entity entity1 = new Entity { Id = 2, Name = "Child", Description = "Child", ParentId = 1 };
            Entity entity2 = new Entity { Id = 3, Name = "ParentChild", Description = "Child", ParentId = 1 };
            Entity entity3 = new Entity { Id = 4, Name = "ParentChild", Description = "Child", ParentId = 3 };
            Entity entity4 = new Entity { Id = 5, Name = "Child", Description = "Child", ParentId = 4};

            context.Entities.Add(entity);
            context.Entities.Add(entity1);
            context.Entities.Add(entity2);
            context.Entities.Add(entity3);
            context.Entities.Add(entity4);

            context.SaveChanges();


        }


    }
}