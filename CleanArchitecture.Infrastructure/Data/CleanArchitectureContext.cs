using Microsoft.EntityFrameworkCore;
using CleanArchitecture.Core.Entities;
using CleanArchitecture.Infrastructure.Data.Configurations;

namespace CleanArchitecture.Infrastructure.Data
{
    public partial class CleanArchitectureContext : DbContext
    {
        public CleanArchitectureContext()
        {
        }

        public CleanArchitectureContext(DbContextOptions<CleanArchitectureContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());

            modelBuilder.ApplyConfiguration(new PostConfiguration());

            modelBuilder.ApplyConfiguration(new CommentConfiguration());

            //OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server = (localdb)\\MSSQLLocalDB; Database = CleanArchitecture; Integrated Security = true");
//            }
//        }
