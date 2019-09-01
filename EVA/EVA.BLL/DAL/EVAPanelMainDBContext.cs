namespace EVA.BLL.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EVAPanelMainDBContext : DbContext
    {
        public EVAPanelMainDBContext()
            : base("EVAPanelMainDBContext2")
        {
        }

        public virtual DbSet<tblCanBusKey> tblCanBusKeys { get; set; }
        public virtual DbSet<tblValue> tblValues { get; set; }
        public virtual DbSet<vwGetValuesByGroup> vwGetValuesByGroups { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblCanBusKey>()
                .HasMany(e => e.tblValues)
                .WithRequired(e => e.tblCanBusKey)
                .HasForeignKey(e => e.CanBusKeyId);
        }
    }
}
