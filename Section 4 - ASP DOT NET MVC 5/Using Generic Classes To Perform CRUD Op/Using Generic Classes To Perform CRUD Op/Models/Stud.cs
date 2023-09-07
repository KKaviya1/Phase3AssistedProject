
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Using_Generic_Classes_To_Perform_CRUD_Op.Models
{
    public class GenericDBContext : DbContext
    {
        public GenericDBContext()
           : base("School1AssEntities")
        {
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}

