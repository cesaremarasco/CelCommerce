using Nop.Core;

namespace Nop.Plugin.Misc.WarehouseManagement.Domain
{
    public class DocumentRow : BaseEntity
    {              
        public int RowNumber { get; set; }
        public int? Product_Id { get; set; }       
        public string ProductDescription { get; set; }        
        public string ExtProductDescription { get; set; }       
        public string Um1 { get; set; }       
        public string Um2 { get; set; }
        public decimal? Qty1 { get; set; }
        public decimal? Qty2 { get; set; }      
        public decimal? Price1 { get; set; }       
        public decimal? Price2 { get; set; }       
        public decimal? Discount1 { get; set; }       
        public decimal? Discount2 { get; set; }
        public string Note { get; set; }
        public decimal? TaxesPerc { get; set; }
        public virtual Document Document { get; set; }
    }
}
