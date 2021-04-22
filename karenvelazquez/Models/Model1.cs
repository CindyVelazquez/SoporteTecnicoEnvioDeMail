namespace karenvelazquez.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<articulo> articulo { get; set; }
        public virtual DbSet<estado> estado { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<estado>()
                .HasMany(e => e.articulo)
                .WithRequired(e => e.estado)
                .WillCascadeOnDelete(false);
        }
    }
}
