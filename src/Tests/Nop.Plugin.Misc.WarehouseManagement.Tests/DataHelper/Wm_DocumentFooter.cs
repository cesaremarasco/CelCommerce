namespace Nop.Plugin.Misc.WarehouseManagement.Tests.DataHelper
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Wm_DocumentFooter
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(10)]
        public string PaymentCode { get; set; }

        [StringLength(100)]
        public string PaymentDescr { get; set; }

        [StringLength(20)]
        public string PaymentStatus { get; set; }

        public virtual Wm_Document Wm_Document { get; set; }
    }
}
