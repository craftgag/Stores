namespace Store
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EFModel : DbContext
    {
        public EFModel()
            : base("name=EFModel")
        {
        }

        public virtual DbSet<Album> Albums { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Album>()
                .Property(e => e.CategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<Album>()
                .Property(e => e.ArtistName)
                .IsUnicode(false);
        }
    }
}
