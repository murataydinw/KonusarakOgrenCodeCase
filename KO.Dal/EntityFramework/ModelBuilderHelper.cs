using KO.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KO.Dal.EntityFramework
{
    public class ModelBuilderHelper
    {
        public static void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(x => x.Id, "user_id").IsUnique();
                entity.Property(a => a.Name);
                entity.Property(a => a.Surname);
                entity.Property(a => a.Email);
                entity.Property(a => a.Password);
                //entity.HasQueryFilter(x => !x.Deleted);
            });
        }
    }
}
