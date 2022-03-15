using Entity_Nested_Structure.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Entity_Nested_Structure.Data
{
    public class EntityContext : DbContext
    {

        static EntityContext()
        {
            Database.SetInitializer<EntityContext>(new EntityDbInitializer());
        }
        public EntityContext() : base("ConnectionString") { }

        public DbSet<Entity> Entities { get; set; }

      
    }

}