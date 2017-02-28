namespace Nop.Plugin.Misc.WarehouseManagement.Tests.DataHelper
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Wm_DocumentTransformation
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ChildDocument_Id { get; set; }

        [Required]
        public int Customer_Id { get; set; }

        [Required]
        public DateTime TransformationDate { get; set; }

        public virtual Wm_Document Wm_Document { get; set; }

        public virtual Wm_Document Wm_Document1 { get; set; }
    }
}
