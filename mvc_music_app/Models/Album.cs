namespace mvc_music_app.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Album : DbContext
    {
        public Album()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<genre> genres { get; set; }
        public virtual DbSet<unit> units { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<genre>()
                .Property(e => e.Genres)
                .IsUnicode(false);

            modelBuilder.Entity<genre>()
                .Property(e => e.Language)
                .IsUnicode(false);

            modelBuilder.Entity<genre>()
                .Property(e => e.Album)
                .IsUnicode(false);

            modelBuilder.Entity<unit>()
                .Property(e => e.Song)
                .IsUnicode(false);

            modelBuilder.Entity<unit>()
                .Property(e => e.Genres)
                .IsUnicode(false);

            modelBuilder.Entity<unit>()
                .Property(e => e.Language)
                .IsUnicode(false);

            modelBuilder.Entity<unit>()
                .Property(e => e.Album)
                .IsUnicode(false);
        }
    }
}
