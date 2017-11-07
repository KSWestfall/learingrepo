using System.Collections.Generic;

namespace Test.Domain.Models
{
    public class PoInfo
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public int UnitType { get; set; }
        public string Po { get; set; }
        public string Notes { get; set; }
        public string Sidemark { get; set; }
        public string StName { get; set; }
        public string StAddress1 { get; set; }
        public string StAddress2 { get; set; }
        public string StCity { get; set; }
        public string StState { get; set; }
        public string StZip { get; set; }
        public string StPhone { get; set; }
        public virtual IList<LineItem> LineItems { get; set; }
    }
}
