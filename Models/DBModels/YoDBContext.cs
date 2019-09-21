using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DotnetTutorial.Models.DBModels {
    public partial class YoDBContext : DbContext {

        public static long InstanceCount;
        public YoDBContext (DbContextOptions<YoDBContext> options) : base (options) => System.Threading.Interlocked.Increment (ref InstanceCount);

        public virtual DbSet<user> user { get; set; }

        //         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //         {
        //             if (!optionsBuilder.IsConfigured)
        //             {
        // #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //                 optionsBuilder.UseSqlServer("Server=.,5269  ;Database=yo;user id=sa;password=yourStrong(!)Password");
        //             }
        //         }

        protected override void OnModelCreating (ModelBuilder modelBuilder) {
            modelBuilder.Entity<user> (entity => {
                entity.Property (e => e.Id).ValueGeneratedNever ();

                entity.Property (e => e.name)
                    .IsRequired ()
                    .HasMaxLength (50);

                entity.Property (e => e.phone)
                    .IsRequired ()
                    .HasMaxLength (50);
            });

            OnModelCreatingPartial (modelBuilder);
        }

        partial void OnModelCreatingPartial (ModelBuilder modelBuilder);
    }
}