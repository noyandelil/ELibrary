using ELibrary.Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ELibrary.DAL.Concrete.EntityFramework
{
    public class ELibraryDBContext : IdentityDbContext<ApplicationUser> 
    {
        public virtual DbSet<Author> Authors { get; set; }
        public ELibraryDBContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
