namespace Nop.Plugin.Misc.WarehouseManagement.Tests.DataHelper
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WmEntity : DbContext
    {
        public WmEntity()
            : base("name=WmEntity")
        {
        }
               
        public virtual DbSet<Wm_Document> Wm_Document { get; set; }
        public virtual DbSet<Wm_Document_Customer_Mapping> Wm_Document_Customer_Mapping { get; set; }
        public virtual DbSet<Wm_DocumentRow> Wm_DocumentBody { get; set; }
        public virtual DbSet<Wm_DocumentFooter> Wm_DocumentFooter { get; set; }
        public virtual DbSet<Wm_DocumentTransformation> Wm_DocumentTransformation { get; set; }
        public virtual DbSet<Wm_DocumentType> Wm_DocumentType { get; set; }
        public virtual DbSet<Wm_InOutType> Wm_InOutType { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {           

            modelBuilder.Entity<Wm_Document>()
                .Property(e => e.DocumentNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Wm_Document>()
                .Property(e => e.State)
                .IsUnicode(false);

            // mappato
            modelBuilder.Entity<Wm_Document>()
                .HasMany(e => e.Wm_Document_Customer_Mapping)
                .WithRequired(e => e.Wm_Document)
                .WillCascadeOnDelete(false);

            // mappato
            modelBuilder.Entity<Wm_Document>()
                .HasMany(e => e.Wm_DocumentRow)
                .WithRequired(e => e.Wm_Document)
                .WillCascadeOnDelete(false);

            // mappato
            modelBuilder.Entity<Wm_Document>()
                .HasMany(e => e.Wm_DocumentTransformation)
                .WithRequired(e => e.Wm_Document)
                .HasForeignKey(e => e.Id)
                .WillCascadeOnDelete(false);

            // mappato
            modelBuilder.Entity<Wm_Document>()
                .HasMany(e => e.Wm_DocumentTransformation1)
                .WithRequired(e => e.Wm_Document1)
                .HasForeignKey(e => e.ChildDocument_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Wm_DocumentRow>()
                .Property(e => e.ProductDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Wm_DocumentRow>()
                .Property(e => e.Um1)
                .IsUnicode(false);

            modelBuilder.Entity<Wm_DocumentRow>()
                .Property(e => e.Um2)
                .IsUnicode(false);

            modelBuilder.Entity<Wm_DocumentRow>()
                .Property(e => e.Price1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Wm_DocumentRow>()
                .Property(e => e.Price2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Wm_DocumentRow>()
                .Property(e => e.Discount1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Wm_DocumentRow>()
                .Property(e => e.Discount2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Wm_DocumentFooter>()
                .Property(e => e.PaymentCode)
                .IsUnicode(false);

            modelBuilder.Entity<Wm_DocumentFooter>()
                .Property(e => e.PaymentDescr)
                .IsUnicode(false);

            modelBuilder.Entity<Wm_DocumentFooter>()
                .Property(e => e.PaymentStatus)
                .IsUnicode(false);

            // mappato
            modelBuilder.Entity<Wm_DocumentFooter>()
                .HasOptional(e => e.Wm_Document)
                .WithRequired(e => e.Wm_DocumentFooter);            

            modelBuilder.Entity<Wm_DocumentType>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Wm_DocumentType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            // mappato
            modelBuilder.Entity<Wm_DocumentType>()
                .HasMany(e => e.Wm_Document)
                .WithOptional(e => e.Wm_DocumentType)
                .HasForeignKey(e => e.DocumentType_Id);

            // mappato
            modelBuilder.Entity<Wm_DocumentType>()
                .HasMany(e => e.Wm_DocumentType1)
                .WithMany(e => e.Wm_DocumentType2)
                .Map(m => m.ToTable("Wm_DocumentTypeTransformation").MapLeftKey("Id").MapRightKey("DocumentChild_Id"));

            modelBuilder.Entity<Wm_InOutType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            // mappato
            modelBuilder.Entity<Wm_InOutType>()
                .HasMany(e => e.Wm_DocumentType)
                .WithRequired(e => e.Wm_InOutType)
                .HasForeignKey(e => e.InOutType_Id)
                .WillCascadeOnDelete(false);
        }
    }
}
