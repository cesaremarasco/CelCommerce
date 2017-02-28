namespace Nop.Plugin.Misc.WarehouseManagement.Tests.DataHelper
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Wm_DocumentType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Wm_DocumentType()
        {
            Wm_Document = new HashSet<Wm_Document>();
            Wm_DocumentType1 = new HashSet<Wm_DocumentType>();
            Wm_DocumentType2 = new HashSet<Wm_DocumentType>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int InOutType_Id { get; set; }

        public int CustomerType_Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Code { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }

        public bool Extended { get; set; }

        public bool HasAmount { get; set; }

        public bool HasBody { get; set; }

        public bool CanBeSentByMail { get; set; }

        public bool OnlyFromTransformation { get; set; }

        public bool CloseParentDoc { get; set; }

        public bool MultipleHead { get; set; }

        public int? TransformationIndex { get; set; }               

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wm_Document> Wm_Document { get; set; }

        public virtual Wm_InOutType Wm_InOutType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wm_DocumentType> Wm_DocumentType1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wm_DocumentType> Wm_DocumentType2 { get; set; }
    }
}
