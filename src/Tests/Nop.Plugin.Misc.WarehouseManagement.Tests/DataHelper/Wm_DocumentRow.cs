namespace Nop.Plugin.Misc.WarehouseManagement.Tests.DataHelper
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Wm_DocumentRow
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RowNumber { get; set; }

        public int? Product_Id { get; set; }

        [StringLength(100)]
        public string ProductDescription { get; set; }

        [Column(TypeName = "ntext")]
        public string ExtProductDescription { get; set; }

        [StringLength(20)]
        public string Um1 { get; set; }

        [StringLength(20)]
        public string Um2 { get; set; }

        public decimal? Qty1 { get; set; }

        public decimal? Qty2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? Discount1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? Discount2 { get; set; }

        [Column(TypeName = "ntext")]
        public string Note { get; set; }

        public decimal? TaxesPerc { get; set; }

        public virtual Wm_Document Wm_Document { get; set; }
    }
}
