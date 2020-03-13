namespace PickupImage.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class pickupimageDb : DbContext
    {
        public pickupimageDb()
            : base("name=pickupimageDb")
        {
        }

        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
