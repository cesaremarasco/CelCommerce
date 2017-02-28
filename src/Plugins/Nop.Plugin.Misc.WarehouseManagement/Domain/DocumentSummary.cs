using System;

namespace Nop.Plugin.Misc.WarehouseManagement.Domain
{
    public class DocumentSummary
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Number { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? EndDateValidity { get; set; }       
        public DateTime? LastEmailDate { get; set; }
        public string Company { get; set; }
        public string State { get; set; }
        public int TypeId { get; set; }
        public string TypeDescription { get; set; }
        public string TypeCode { get; set; }
        public decimal? Amount { get; set; }
        public decimal? RemainingAmout { get; set; }
    }
}
