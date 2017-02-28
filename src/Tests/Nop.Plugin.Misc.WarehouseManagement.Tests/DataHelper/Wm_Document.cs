namespace Nop.Plugin.Misc.WarehouseManagement.Tests.DataHelper
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Wm_Document
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Wm_Document()
        {
            Wm_Document_Customer_Mapping = new HashSet<Wm_Document_Customer_Mapping>();
            Wm_DocumentRow = new HashSet<Wm_DocumentRow>();
            Wm_DocumentTransformation = new HashSet<Wm_DocumentTransformation>();
            Wm_DocumentTransformation1 = new HashSet<Wm_DocumentTransformation>();
        }

        public int Id { get; set; }

        public int? DocumentType_Id { get; set; }

        public int? Year { get; set; }

        [StringLength(25)]
        public string DocumentNumber { get; set; }

        public DateTime? RegistrationDate { get; set; }

        public DateTime? DocumentDate { get; set; }

        public DateTime? EndDateValidity { get; set; }

        public DateTime? LastUpdateDate { get; set; }

        public DateTime? LastEmailDate { get; set; }

        public bool? Trasformed { get; set; }

        [StringLength(20)]
        public string State { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wm_Document_Customer_Mapping> Wm_Document_Customer_Mapping { get; set; }

        public virtual Wm_DocumentFooter Wm_DocumentFooter { get; set; }

        public virtual Wm_DocumentType Wm_DocumentType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wm_DocumentRow> Wm_DocumentRow { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wm_DocumentTransformation> Wm_DocumentTransformation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wm_DocumentTransformation> Wm_DocumentTransformation1 { get; set; }
    }
}
