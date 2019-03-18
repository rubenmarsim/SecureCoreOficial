namespace RARR
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

        public virtual DbSet<AssemblyInstructions> AssemblyInstructions { get; set; }
        public virtual DbSet<AssemblyInstructionsDetail> AssemblyInstructionsDetail { get; set; }
        public virtual DbSet<FactoryUsers> FactoryUsers { get; set; }
        public virtual DbSet<FinalProduct> FinalProduct { get; set; }
        public virtual DbSet<FinalProductDetails> FinalProductDetails { get; set; }
        public virtual DbSet<IntermediateProduct> IntermediateProduct { get; set; }
        public virtual DbSet<LOP> LOP { get; set; }
        public virtual DbSet<LOPDetails> LOPDetails { get; set; }
        public virtual DbSet<OperationParts> OperationParts { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<OrdersDetail> OrdersDetail { get; set; }
        public virtual DbSet<References> References { get; set; }
        public virtual DbSet<ReferenceTypes> ReferenceTypes { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<StockMovements> StockMovements { get; set; }
        public virtual DbSet<StockMovementTypes> StockMovementTypes { get; set; }
        public virtual DbSet<Stocks> Stocks { get; set; }
        public virtual DbSet<Structure> Structure { get; set; }
        public virtual DbSet<UserTypes> UserTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AssemblyInstructions>()
                .HasMany(e => e.AssemblyInstructionsDetail)
                .WithRequired(e => e.AssemblyInstructions)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FinalProduct>()
                .HasMany(e => e.FinalProductDetails)
                .WithRequired(e => e.FinalProduct)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IntermediateProduct>()
                .HasMany(e => e.FinalProductDetails)
                .WithRequired(e => e.IntermediateProduct)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOP>()
                .HasMany(e => e.LOPDetails)
                .WithRequired(e => e.LOP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOPDetails>()
                .HasMany(e => e.FinalProduct)
                .WithRequired(e => e.LOPDetails)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOPDetails>()
                .HasMany(e => e.IntermediateProduct)
                .WithRequired(e => e.LOPDetails)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Orders>()
                .HasMany(e => e.LOP)
                .WithRequired(e => e.Orders)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<References>()
                .HasMany(e => e.Structure)
                .WithOptional(e => e.References)
                .HasForeignKey(e => e.idReferenceFinal);

            modelBuilder.Entity<References>()
                .HasMany(e => e.Structure1)
                .WithOptional(e => e.References1)
                .HasForeignKey(e => e.idReferencePart);

            modelBuilder.Entity<ReferenceTypes>()
                .HasMany(e => e.References)
                .WithRequired(e => e.ReferenceTypes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.FinalProduct)
                .WithRequired(e => e.Status)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.IntermediateProduct)
                .WithRequired(e => e.Status)
                .WillCascadeOnDelete(false);
        }
    }
}
